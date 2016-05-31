using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PP_ComLib_Wrapper;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.InteropServices;

namespace Diploma_TestApp
{
    public partial class Form1 : Form
    {
        PP_ComLib_WrapperClass ppSensor, ppActuator;        

        int I2C_ADDR = 0x00;
        bool WindowMaximizeState = false;

        string lastActiveSensorPort;
        string lastActiveActuatorPort;

        DateTime date;        

        bool guiRunState = false;
        Thread ioThread = null;

        struct threadParams
        {
            public string sensorPort;
            public string actuatorPort;
        }

        struct threadDECdata
        {
            public int DECillumination;
            public int DECtemperature;
        }

        public struct GUI_State
        {
            public string sensorPort;
            public string actuatorPort;

            public bool threadRunning;

            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }

                GUI_State instance = (GUI_State)obj;

                return (this.sensorPort == instance.sensorPort) &&
                       (this.actuatorPort == instance.actuatorPort) &&
                       (this.threadRunning == instance.threadRunning);
            }

            public override int GetHashCode()
            {
                return 0; //not needed, added just to remove compiler warning
            }

        }
        GUI_State guiStatePrev;

        
        public Form1()
        {
            InitializeComponent();
        }

        //------------------------------------------------------------------------------------------
        // Auxiliary Methods
        //------------------------------------------------------------------------------------------
        #region Aux_Methods

        void LoadPorts()
        {
            string[] ports;
            string strError;
            string activeSensorPort, activeActuatorPort;

            ppSensor.GetPorts(out ports, out strError);

            //0.  Remember current active ports
            activeSensorPort = cmbSensors.Text;
            activeActuatorPort = cmbActuators.Text;

            //1. Load current device list in Sensor List
            cmbSensors.Items.Clear();
            for (int i = 0; i < ports.Length; i++)
            {
                cmbSensors.Items.Add(ports[i]);
                //if (ports[i] == activeSensorPort) cmbSensors.Text = activeSensorPort;
                if (ports[i] == lastActiveSensorPort) cmbSensors.Text = lastActiveSensorPort;
            }

            //2. Load current device list in Actuator List
            cmbActuators.Items.Clear();
            for (int i = 0; i < ports.Length; i++)
            {
                cmbActuators.Items.Add(ports[i]);
                //if (ports[i] == activeActuatorPort) cmbActuators.Text = activeActuatorPort;
                if (ports[i] == lastActiveActuatorPort) cmbActuators.Text = lastActiveActuatorPort;
            }
        }

        void GetActivePorts(out string sensorPort, out string actuatorPort)
        {
            sensorPort = cmbSensors.Text;
            actuatorPort = cmbActuators.Text;
        }

        delegate void DlgOneStringParam(string port);

        void Connect(string portName)
        {
            //1. Executed only in PPCOM thread
            if (this.InvokeRequired)
            {
                this.Invoke(new DlgOneStringParam(Connect), new object[] { portName });
                return;
            }

            //2. Executed only in Main Thread
            LoadPorts();
        }

        void Disconnect(string portName)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new DlgOneStringParam(Disconnect), new object[] { portName });
                return;
            }

            StopIO_Process();
            LoadPorts();
        }

        bool SUCCEEDED(int hr)
        {
            return hr >= 0;
        }

        void GetGuiState(out GUI_State guiState)
        {
            guiState = new GUI_State();
            
            GetActivePorts(out guiState.sensorPort, out guiState.actuatorPort);

            //if ((ioThread != null) && (guiRunState == true))
            //    guiState.threadRunning = true;
            //else
            //    guiState.threadRunning = false;
            guiState.threadRunning = (ioThread != null) && (guiRunState == true);
        }

        #endregion Aux_Methods

        //------------------------------------------------------------------------------------------
        // Thread Operations
        //------------------------------------------------------------------------------------------
        #region IO_Operations

        int SetLampState(int state, out string strError)
        {
            int hr;

            byte[] data = new byte[] { 0x04, 0x01, (byte)((state == 0x00) ? 0x00 : 0xFF), 0x01 };
            hr = ppActuator.I2C_SendData(I2C_ADDR, data, out strError);
            Thread.Sleep(100);

            return hr;
        }

        void StopIO_Process()
        {
            guiRunState = false;

            if (ioThread != null)
            {
                ioThread.Join(200); //10 sec to give user time to react on I2C Error Msg box and close it

                if (ioThread.ThreadState != System.Threading.ThreadState.Stopped)
                    ioThread.Abort();
            }
        }

        void RunIO_Process(object parameters)
        {
            //--->>> Execute Run in separate Thread! <<<--------------
            //--->>> Also add error handling, if port is busy, or bad port name, etc <<<----------                       

            int hr;
            string strError;
            

            //1. OpenPorts
            ppActuator.ClosePort(out strError);
            ppSensor.ClosePort(out strError);

            threadParams threadParameters = (threadParams)parameters;

            if (threadParameters.actuatorPort == threadParameters.sensorPort)
            {
                MessageBox.Show("Actuator and Sensor Ports both have same Name!", "Failed to Start!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hr = ppSensor.OpenPort(threadParameters.sensorPort, out strError);
            if (!SUCCEEDED(hr))
            {
                MessageBox.Show(strError, "Failed to Open Port!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            hr = ppActuator.OpenPort(threadParameters.actuatorPort, out strError);
            if (!SUCCEEDED(hr))
            {
                MessageBox.Show(strError, "Failed to Open Port!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //2. SetProtocol, Speed, Power
            ppActuator.SetProtocol(enumInterfaces.I2C, out strError);
            ppActuator.I2C_SetSpeed(enumI2Cspeed.CLK_100K, out strError);
            ppActuator.SetPowerVoltage("5.0", out strError);
            ppActuator.PowerOn(out strError);

            ppSensor.SetProtocol(enumInterfaces.I2C, out strError);
            ppSensor.I2C_SetSpeed(enumI2Cspeed.CLK_100K, out strError);
            ppSensor.SetPowerVoltage("5.0", out strError);
            ppSensor.PowerOn(out strError);

            //Fade off LEDs on Sensor Port
            ppSensor.I2C_SendData(I2C_ADDR, new byte[] { 0x04, 0x01, 0x0, 0x01 }, out strError);
            Thread.Sleep(170);
            ppSensor.I2C_SendData(I2C_ADDR, new byte[] { 0x04, 0x02, 0x0, 0x01 }, out strError);
            Thread.Sleep(170);

            ppActuator.I2C_SendData(I2C_ADDR, new byte[] { 0x04, 0x01, 0x0, 0x01 }, out strError);
            Thread.Sleep(170);
            ppActuator.I2C_SendData(I2C_ADDR, new byte[] { 0x04, 0x02, 0x10, 0x01 }, out strError);
            Thread.Sleep(170);

            //3. Run working loop
            int Illumination_Reference = 0x370;
            int Illumination_Delta = 0x10;

            guiRunState = true;
            while (guiRunState)
            {
                Application.DoEvents(); //Read this ....

                //1. Read Sensors
                byte[] sensorData;
                int illumination, temperature;

                hr = ppSensor.I2C_ReadDataFromReg(I2C_ADDR, new byte[] { 0x00 }, 4, out sensorData, out strError);
                if (!SUCCEEDED(hr))
                {
                    MessageBox.Show(strError, "I2C Comm Failed with Sensor Port!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }

                temperature = (sensorData[0] << 8) + sensorData[1];
                illumination = (sensorData[2] << 8) + sensorData[3];

                threadDECdata DECdata = new threadDECdata();
                DECdata.DECtemperature = Convert.ToInt32(temperature);
                DECdata.DECillumination = Convert.ToInt32(illumination);

                if (InvokeRequired)
                    this.Invoke(new MethodInvoker(() =>
                    {                        
                        IlluminationLabel.Text = "Illumination: " + DECdata.DECillumination.ToString();
                        TemperatureLable.Text = "Temperature: " + DECdata.DECtemperature.ToString();
                    } ));

                if (InvokeRequired)
                    this.Invoke(new MethodInvoker(() => 
                    {
                        if (textBox_ConsoleOutput.Enabled == true)                       
                            textBox_ConsoleOutput.AppendText("\r\n>>> Illum: " + DECdata.DECillumination.ToString() + "   Temp: " + DECdata.DECtemperature.ToString());
                    } ));

                int ChartXPointer_illumination = 0;
                int ChartXPointer_temperature = 0;

                if (InvokeRequired)
                    this.Invoke(new MethodInvoker(() =>
                    {                        
                        if (Chart.Series["Illumination"].Points.Count > 150)
                            Chart.Series["Illumination"].Points.RemoveAt(0);
                        this.Chart.Series["Illumination"].Points.AddXY(ChartXPointer_illumination++, DECdata.DECillumination);
                        if (Chart.Series["Temperature"].Points.Count > 150)
                            Chart.Series["Temperature"].Points.RemoveAt(0);
                        this.Chart.Series["Temperature"].Points.AddXY(ChartXPointer_temperature++, DECdata.DECtemperature);
                        Chart.ResetAutoValues();
                    }));

                // Use Debugger.Log only for debugging
                //Debugger.Log(0, "", "\r\n>>> Illum: " + illumination.ToString("X4") + "   Temp: " + temperature.ToString("X4"));

                //2. Act upon Sensor State
                if (illumination < (Illumination_Reference - Illumination_Delta))
                    hr = SetLampState(0, out strError);
                else
                    if (illumination > (Illumination_Reference + Illumination_Delta))
                        hr = SetLampState(1, out strError);
                if (!SUCCEEDED(hr))
                {
                    MessageBox.Show(strError, "I2C Comm Failed with Sensor Port!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                
                //3. Display Current Data

            }
            guiRunState = false;

            //4. Thread Complete - shutdown LEDs on Actuator/Sensor
            ppActuator.PowerOff(out strError);
            ppSensor.PowerOff(out strError);
        }

        #endregion IO_Operations

        //------------------------------------------------------------------------------------------
        // GUI Event Handlers
        //------------------------------------------------------------------------------------------
        #region GUI_Events

        private void Form1_Load(object sender, EventArgs e)
        {            
            ppActuator = new PP_ComLib_WrapperClass();
            ppSensor = new PP_ComLib_WrapperClass();

            ppActuator.w_ConnectToLatest();
            ppSensor.w_ConnectToLatest();            

            ppActuator.OnConnect += Connect;
            ppActuator.OnDisconnect += Disconnect;            

            LoadPorts();
            //LoadGraph();
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopIO_Process();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            threadParams data = new threadParams();
            GetActivePorts(out data.sensorPort, out data.actuatorPort);

            if ((ioThread != null) && (ioThread.ThreadState == System.Threading.ThreadState.Running))
                return;

            // StopWatch
            date = DateTime.Now;            
            StopWatchTimer.Interval = 10;
            StopWatchTimer.Tick += new EventHandler(tickStopWatchTimer);

            ioThread = new Thread(RunIO_Process);
            ioThread.Start(data);

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopIO_Process();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //1. Get Current GUI State
            //threadDECdata DECdata = new threadDECdata();
            GUI_State guiStateNow;
            GetGuiState(out guiStateNow);

            string DefaultText = "iTKerry's Sensor Tool :: ";            

            //2. Check if it was changed
            if (guiStateNow.Equals(guiStatePrev)) return;

            //3. Apply Changes to Controls
            btnRun.Enabled = (guiStateNow.actuatorPort != String.Empty) &&
                             (guiStateNow.sensorPort != String.Empty) &&
                             (guiStateNow.threadRunning == false);
            runToolStripMenuItem.Enabled = (guiStateNow.actuatorPort != String.Empty) &&
                                           (guiStateNow.sensorPort != String.Empty) &&
                                           (guiStateNow.threadRunning == false);

            btnStop.Enabled = guiStateNow.threadRunning;
            stopToolStripMenuItem.Enabled = guiStateNow.threadRunning;

            cmbActuators.Enabled = !guiStateNow.threadRunning;
            cmbSensors.Enabled = !guiStateNow.threadRunning;

            //Read data from sensor

            //4. Set status labels            
            if (guiStateNow.threadRunning == true)
            {
                RunningStatusLabel.Text = "Running . . .";
                taskbarNotify.Text = DefaultText + "Running";
                this.Text = DefaultText + "Running";

                StopWatchTimer.Start();
            }
            else
            {
                RunningStatusLabel.Text = "Stopped . . .";
                IlluminationLabel.Text = "Illumination: -";
                TemperatureLable.Text = "Temperature: -";
                taskbarNotify.Text = DefaultText + "Stopped";
                this.Text = DefaultText + "Stopped";

                StopWatchTimer.Dispose();
            }                                    

            //6. Remember current state
            guiStatePrev = guiStateNow;

            guiStateNow.threadRunning = false;
        }

        private void tickStopWatchTimer(object sender, EventArgs e)
        {
            long tick = DateTime.Now.Ticks - date.Ticks;
            DateTime stopWatch = new DateTime();

            stopWatch = stopWatch.AddTicks(tick);
            StopwatchLable.Text = String.Format("Time: " + "{0:HH:mm:ss:ff}", stopWatch);
        }

        private void cmbSensors_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastActiveSensorPort = cmbSensors.Text;
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRun_Click(sender, e);
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
        }

        private void tEXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Close Form1.
            Application.Exit();
        }

        private void ChartCheckListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Allow illumination on chart
            bool illumState = ChartCheckListBox.GetItemChecked(0);
            if (illumState == true)            
                Chart.Series[0].Enabled = true;            
            else            
                Chart.Series[0].Enabled = false;            

            // Allow temperature on chart
            bool tempState = ChartCheckListBox.GetItemChecked(1);
            if (tempState == true)            
                Chart.Series[1].Enabled = true;            
            else            
                Chart.Series[1].Enabled = false;

            // Allow logging into textbox
            bool logState = ChartCheckListBox.GetItemChecked(2);
            if (logState == true)
                textBox_ConsoleOutput.Enabled = true;
            else
                textBox_ConsoleOutput.Enabled = false;

            // Set chart in 3D
            bool ChartStyleState = ChartCheckListBox.GetItemChecked(3);
            if (ChartStyleState == true)
                Chart.ChartAreas[0].Area3DStyle.Enable3D = true;
            else
                Chart.ChartAreas[0].Area3DStyle.Enable3D = false;
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            textBox_ConsoleOutput.Clear();
        }

        private void btnClearChat_Click(object sender, EventArgs e)
        {
            Chart.Series[0].Points.Clear();
            Chart.Series[1].Points.Clear();
        }

        private void cmbActuators_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastActiveActuatorPort = cmbActuators.Text;
        }

        #endregion

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();        

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MainLable.Text = "Settings";
            SettingsPanel.Visible = true;
            AboutPanel.Visible = false;
            ChartPanel.Visible = false;
        }

        private void ChartButton_Click(object sender, EventArgs e)
        {
            MainLable.Text = "Chart";
            SettingsPanel.Visible = false;
            AboutPanel.Visible = false;
            ChartPanel.Visible = true;
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MainLable.Text = "About";
            SettingsPanel.Visible = false;
            AboutPanel.Visible = true;
            ChartPanel.Visible = false;
        }

        private void ApplicationExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ApplicationMinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ApplicationMaximizeBtn_Click(object sender, EventArgs e)
        {
            if (!WindowMaximizeState)
            {
                this.WindowState = FormWindowState.Maximized;
                WindowMaximizeState = true;
                return;
            }
            this.WindowState = FormWindowState.Normal;
            WindowMaximizeState = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/iTKerry");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/itkerry");
        }

        private void Header_MouseDown_1(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
