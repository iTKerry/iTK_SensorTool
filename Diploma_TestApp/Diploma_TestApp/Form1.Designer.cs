namespace Diploma_TestApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnClearChat = new System.Windows.Forms.Button();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox_ConsoleOutput = new System.Windows.Forms.TextBox();
            this.groupboxPorts = new System.Windows.Forms.GroupBox();
            this.labelSensor = new System.Windows.Forms.Label();
            this.labelActuator = new System.Windows.Forms.Label();
            this.cmbSensors = new System.Windows.Forms.ComboBox();
            this.cmbActuators = new System.Windows.Forms.ComboBox();
            this.taskbarNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.taskbarNotify_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tEXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StopWatchTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.AboutButton = new System.Windows.Forms.Button();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.ChartButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Header = new System.Windows.Forms.Panel();
            this.ApplicationMinimizeBtn = new System.Windows.Forms.Button();
            this.ApplicationMaximizeBtn = new System.Windows.Forms.Button();
            this.ApplicationExitBtn = new System.Windows.Forms.Button();
            this.MainLable = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChartCheckListBox = new System.Windows.Forms.CheckedListBox();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.StatusBar = new System.Windows.Forms.Panel();
            this.StopwatchLable = new System.Windows.Forms.Label();
            this.TemperatureLable = new System.Windows.Forms.Label();
            this.IlluminationLabel = new System.Windows.Forms.Label();
            this.RunningStatusLabel = new System.Windows.Forms.Label();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.groupboxPorts.SuspendLayout();
            this.taskbarNotify_contextMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            this.SettingsPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.LightGray;
            this.btnStop.Location = new System.Drawing.Point(0, 491);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(182, 51);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRun.FlatAppearance.BorderSize = 0;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.ForeColor = System.Drawing.Color.LightGray;
            this.btnRun.Location = new System.Drawing.Point(0, 440);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(182, 51);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnClearLog
            // 
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearLog.FlatAppearance.BorderSize = 0;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.ForeColor = System.Drawing.Color.LightGray;
            this.btnClearLog.Location = new System.Drawing.Point(614, 0);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(95, 37);
            this.btnClearLog.TabIndex = 3;
            this.btnClearLog.Text = "Clear LOG";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // btnClearChat
            // 
            this.btnClearChat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearChat.FlatAppearance.BorderSize = 0;
            this.btnClearChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearChat.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearChat.ForeColor = System.Drawing.Color.LightGray;
            this.btnClearChat.Location = new System.Drawing.Point(511, 0);
            this.btnClearChat.Name = "btnClearChat";
            this.btnClearChat.Size = new System.Drawing.Size(103, 37);
            this.btnClearChat.TabIndex = 4;
            this.btnClearChat.Text = "Clear Chart";
            this.btnClearChat.UseVisualStyleBackColor = true;
            this.btnClearChat.Click += new System.EventHandler(this.btnClearChat_Click);
            // 
            // Chart
            // 
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart.BackColor = System.Drawing.Color.Gainsboro;
            this.Chart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            this.Chart.BorderlineColor = System.Drawing.Color.Black;
            this.Chart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.Chart.BorderlineWidth = 0;
            this.Chart.BorderSkin.BorderWidth = 3;
            chartArea10.Name = "ChartArea1";
            chartArea10.Position.Auto = false;
            chartArea10.Position.Height = 94F;
            chartArea10.Position.Width = 93.49358F;
            chartArea10.Position.X = 1F;
            chartArea10.Position.Y = 3F;
            this.Chart.ChartAreas.Add(chartArea10);
            legend10.BackColor = System.Drawing.Color.Silver;
            legend10.BorderWidth = 0;
            legend10.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            legend10.IsTextAutoFit = false;
            legend10.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend10.Name = "Legend1";
            legend10.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.Chart.Legends.Add(legend10);
            this.Chart.Location = new System.Drawing.Point(6, 6);
            this.Chart.Name = "Chart";
            series19.BorderWidth = 2;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Enabled = false;
            series19.Legend = "Legend1";
            series19.Name = "Illumination";
            series20.BorderWidth = 2;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Enabled = false;
            series20.Legend = "Legend1";
            series20.Name = "Temperature";
            this.Chart.Series.Add(series19);
            this.Chart.Series.Add(series20);
            this.Chart.Size = new System.Drawing.Size(550, 472);
            this.Chart.TabIndex = 1;
            // 
            // textBox_ConsoleOutput
            // 
            this.textBox_ConsoleOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_ConsoleOutput.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox_ConsoleOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_ConsoleOutput.Enabled = false;
            this.textBox_ConsoleOutput.Location = new System.Drawing.Point(562, 6);
            this.textBox_ConsoleOutput.Multiline = true;
            this.textBox_ConsoleOutput.Name = "textBox_ConsoleOutput";
            this.textBox_ConsoleOutput.ReadOnly = true;
            this.textBox_ConsoleOutput.Size = new System.Drawing.Size(144, 472);
            this.textBox_ConsoleOutput.TabIndex = 0;
            // 
            // groupboxPorts
            // 
            this.groupboxPorts.Controls.Add(this.labelSensor);
            this.groupboxPorts.Controls.Add(this.labelActuator);
            this.groupboxPorts.Controls.Add(this.cmbSensors);
            this.groupboxPorts.Controls.Add(this.cmbActuators);
            this.groupboxPorts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPorts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.groupboxPorts.Location = new System.Drawing.Point(44, 15);
            this.groupboxPorts.Name = "groupboxPorts";
            this.groupboxPorts.Size = new System.Drawing.Size(432, 138);
            this.groupboxPorts.TabIndex = 4;
            this.groupboxPorts.TabStop = false;
            this.groupboxPorts.Text = "PORTS";
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSensor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.labelSensor.Location = new System.Drawing.Point(6, 52);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(93, 20);
            this.labelSensor.TabIndex = 5;
            this.labelSensor.Text = "Sensor Port:";
            // 
            // labelActuator
            // 
            this.labelActuator.AutoSize = true;
            this.labelActuator.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActuator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.labelActuator.Location = new System.Drawing.Point(6, 103);
            this.labelActuator.Name = "labelActuator";
            this.labelActuator.Size = new System.Drawing.Size(111, 20);
            this.labelActuator.TabIndex = 6;
            this.labelActuator.Text = "Actuator Port:";
            // 
            // cmbSensors
            // 
            this.cmbSensors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensors.FormattingEnabled = true;
            this.cmbSensors.Location = new System.Drawing.Point(159, 48);
            this.cmbSensors.Name = "cmbSensors";
            this.cmbSensors.Size = new System.Drawing.Size(201, 29);
            this.cmbSensors.TabIndex = 0;
            this.cmbSensors.SelectedIndexChanged += new System.EventHandler(this.cmbSensors_SelectedIndexChanged);
            // 
            // cmbActuators
            // 
            this.cmbActuators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActuators.FormattingEnabled = true;
            this.cmbActuators.Location = new System.Drawing.Point(159, 99);
            this.cmbActuators.Name = "cmbActuators";
            this.cmbActuators.Size = new System.Drawing.Size(201, 29);
            this.cmbActuators.TabIndex = 1;
            this.cmbActuators.SelectedIndexChanged += new System.EventHandler(this.cmbActuators_SelectedIndexChanged);
            // 
            // taskbarNotify
            // 
            this.taskbarNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.taskbarNotify.BalloonTipText = "This is text";
            this.taskbarNotify.BalloonTipTitle = "This is title";
            this.taskbarNotify.ContextMenuStrip = this.taskbarNotify_contextMenu;
            this.taskbarNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarNotify.Icon")));
            this.taskbarNotify.Text = "iTK Sensor Tool :: INFO";
            this.taskbarNotify.Visible = true;
            // 
            // taskbarNotify_contextMenu
            // 
            this.taskbarNotify_contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator1,
            this.tEXTToolStripMenuItem});
            this.taskbarNotify_contextMenu.Name = "taskbarNotify_contextMenu";
            this.taskbarNotify_contextMenu.Size = new System.Drawing.Size(99, 76);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // tEXTToolStripMenuItem
            // 
            this.tEXTToolStripMenuItem.Name = "tEXTToolStripMenuItem";
            this.tEXTToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.tEXTToolStripMenuItem.Text = "Exit";
            this.tEXTToolStripMenuItem.Click += new System.EventHandler(this.tEXTToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.panel2.Controls.Add(this.AboutButton);
            this.panel2.Controls.Add(this.SettingsButton);
            this.panel2.Controls.Add(this.ChartButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Controls.Add(this.btnStop);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 579);
            this.panel2.TabIndex = 7;
            // 
            // AboutButton
            // 
            this.AboutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AboutButton.FlatAppearance.BorderSize = 0;
            this.AboutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.AboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutButton.ForeColor = System.Drawing.Color.LightGray;
            this.AboutButton.Location = new System.Drawing.Point(0, 160);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(182, 51);
            this.AboutButton.TabIndex = 5;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.LightGray;
            this.SettingsButton.Location = new System.Drawing.Point(0, 109);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(182, 51);
            this.SettingsButton.TabIndex = 7;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // ChartButton
            // 
            this.ChartButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChartButton.FlatAppearance.BorderSize = 0;
            this.ChartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChartButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartButton.ForeColor = System.Drawing.Color.LightGray;
            this.ChartButton.Location = new System.Drawing.Point(0, 58);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(182, 51);
            this.ChartButton.TabIndex = 6;
            this.ChartButton.Text = "Chart";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 58);
            this.panel3.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "SensorTool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 542);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 37);
            this.panel1.TabIndex = 8;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Gainsboro;
            this.Header.Controls.Add(this.ApplicationMinimizeBtn);
            this.Header.Controls.Add(this.ApplicationMaximizeBtn);
            this.Header.Controls.Add(this.ApplicationExitBtn);
            this.Header.Controls.Add(this.MainLable);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(182, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(709, 58);
            this.Header.TabIndex = 8;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown_1);
            // 
            // ApplicationMinimizeBtn
            // 
            this.ApplicationMinimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationMinimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ApplicationMinimizeBtn.BackgroundImage")));
            this.ApplicationMinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApplicationMinimizeBtn.FlatAppearance.BorderSize = 0;
            this.ApplicationMinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationMinimizeBtn.Location = new System.Drawing.Point(594, 21);
            this.ApplicationMinimizeBtn.Name = "ApplicationMinimizeBtn";
            this.ApplicationMinimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.ApplicationMinimizeBtn.TabIndex = 3;
            this.ApplicationMinimizeBtn.UseVisualStyleBackColor = true;
            this.ApplicationMinimizeBtn.Click += new System.EventHandler(this.ApplicationMinimizeBtn_Click);
            // 
            // ApplicationMaximizeBtn
            // 
            this.ApplicationMaximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationMaximizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ApplicationMaximizeBtn.BackgroundImage")));
            this.ApplicationMaximizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApplicationMaximizeBtn.FlatAppearance.BorderSize = 0;
            this.ApplicationMaximizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationMaximizeBtn.Location = new System.Drawing.Point(631, 21);
            this.ApplicationMaximizeBtn.Name = "ApplicationMaximizeBtn";
            this.ApplicationMaximizeBtn.Size = new System.Drawing.Size(20, 20);
            this.ApplicationMaximizeBtn.TabIndex = 2;
            this.ApplicationMaximizeBtn.UseVisualStyleBackColor = true;
            this.ApplicationMaximizeBtn.Click += new System.EventHandler(this.ApplicationMaximizeBtn_Click);
            // 
            // ApplicationExitBtn
            // 
            this.ApplicationExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ApplicationExitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ApplicationExitBtn.BackgroundImage")));
            this.ApplicationExitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApplicationExitBtn.FlatAppearance.BorderSize = 0;
            this.ApplicationExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ApplicationExitBtn.Location = new System.Drawing.Point(666, 21);
            this.ApplicationExitBtn.Name = "ApplicationExitBtn";
            this.ApplicationExitBtn.Size = new System.Drawing.Size(20, 20);
            this.ApplicationExitBtn.TabIndex = 1;
            this.ApplicationExitBtn.UseVisualStyleBackColor = true;
            this.ApplicationExitBtn.Click += new System.EventHandler(this.ApplicationExitBtn_Click);
            // 
            // MainLable
            // 
            this.MainLable.AutoSize = true;
            this.MainLable.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.MainLable.Location = new System.Drawing.Point(40, 17);
            this.MainLable.Name = "MainLable";
            this.MainLable.Size = new System.Drawing.Size(73, 24);
            this.MainLable.TabIndex = 0;
            this.MainLable.Text = "About";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.SettingsPanel.Controls.Add(this.groupBox1);
            this.SettingsPanel.Controls.Add(this.groupboxPorts);
            this.SettingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SettingsPanel.Location = new System.Drawing.Point(182, 58);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(709, 521);
            this.SettingsPanel.TabIndex = 9;
            this.SettingsPanel.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChartCheckListBox);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.groupBox1.Location = new System.Drawing.Point(44, 192);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 157);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHART";
            // 
            // ChartCheckListBox
            // 
            this.ChartCheckListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.ChartCheckListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ChartCheckListBox.CheckOnClick = true;
            this.ChartCheckListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.ChartCheckListBox.FormattingEnabled = true;
            this.ChartCheckListBox.Items.AddRange(new object[] {
            "\tIllumination",
            "\tTemperature",
            "\tEnable  Log",
            "\t3D Chart"});
            this.ChartCheckListBox.Location = new System.Drawing.Point(25, 45);
            this.ChartCheckListBox.Name = "ChartCheckListBox";
            this.ChartCheckListBox.Size = new System.Drawing.Size(188, 110);
            this.ChartCheckListBox.TabIndex = 5;
            this.ChartCheckListBox.UseTabStops = false;
            this.ChartCheckListBox.SelectedIndexChanged += new System.EventHandler(this.ChartCheckListBox_SelectedIndexChanged);
            // 
            // ChartPanel
            // 
            this.ChartPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.ChartPanel.Controls.Add(this.StatusBar);
            this.ChartPanel.Controls.Add(this.textBox_ConsoleOutput);
            this.ChartPanel.Controls.Add(this.Chart);
            this.ChartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChartPanel.Location = new System.Drawing.Point(182, 58);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(709, 521);
            this.ChartPanel.TabIndex = 10;
            this.ChartPanel.Visible = false;
            // 
            // StatusBar
            // 
            this.StatusBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.StatusBar.Controls.Add(this.btnClearChat);
            this.StatusBar.Controls.Add(this.btnClearLog);
            this.StatusBar.Controls.Add(this.StopwatchLable);
            this.StatusBar.Controls.Add(this.TemperatureLable);
            this.StatusBar.Controls.Add(this.IlluminationLabel);
            this.StatusBar.Controls.Add(this.RunningStatusLabel);
            this.StatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.StatusBar.Location = new System.Drawing.Point(0, 484);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Size = new System.Drawing.Size(709, 37);
            this.StatusBar.TabIndex = 6;
            // 
            // StopwatchLable
            // 
            this.StopwatchLable.Dock = System.Windows.Forms.DockStyle.Left;
            this.StopwatchLable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopwatchLable.ForeColor = System.Drawing.Color.LightGray;
            this.StopwatchLable.Location = new System.Drawing.Point(361, 0);
            this.StopwatchLable.Name = "StopwatchLable";
            this.StopwatchLable.Size = new System.Drawing.Size(130, 37);
            this.StopwatchLable.TabIndex = 3;
            this.StopwatchLable.Text = "Time: - : - : - : -";
            this.StopwatchLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TemperatureLable
            // 
            this.TemperatureLable.Dock = System.Windows.Forms.DockStyle.Left;
            this.TemperatureLable.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TemperatureLable.ForeColor = System.Drawing.Color.LightGray;
            this.TemperatureLable.Location = new System.Drawing.Point(228, 0);
            this.TemperatureLable.Name = "TemperatureLable";
            this.TemperatureLable.Size = new System.Drawing.Size(133, 37);
            this.TemperatureLable.TabIndex = 2;
            this.TemperatureLable.Text = "Temperature: -";
            this.TemperatureLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IlluminationLabel
            // 
            this.IlluminationLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.IlluminationLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IlluminationLabel.ForeColor = System.Drawing.Color.LightGray;
            this.IlluminationLabel.Location = new System.Drawing.Point(95, 0);
            this.IlluminationLabel.Name = "IlluminationLabel";
            this.IlluminationLabel.Size = new System.Drawing.Size(133, 37);
            this.IlluminationLabel.TabIndex = 1;
            this.IlluminationLabel.Text = "Illumination: -";
            this.IlluminationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RunningStatusLabel
            // 
            this.RunningStatusLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RunningStatusLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunningStatusLabel.ForeColor = System.Drawing.Color.LightGray;
            this.RunningStatusLabel.Location = new System.Drawing.Point(0, 0);
            this.RunningStatusLabel.Name = "RunningStatusLabel";
            this.RunningStatusLabel.Size = new System.Drawing.Size(95, 37);
            this.RunningStatusLabel.TabIndex = 0;
            this.RunningStatusLabel.Text = "Stopped...";
            this.RunningStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AboutPanel
            // 
            this.AboutPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.AboutPanel.Controls.Add(this.pictureBox2);
            this.AboutPanel.Controls.Add(this.linkLabel2);
            this.AboutPanel.Controls.Add(this.linkLabel1);
            this.AboutPanel.Controls.Add(this.label9);
            this.AboutPanel.Controls.Add(this.label8);
            this.AboutPanel.Controls.Add(this.label7);
            this.AboutPanel.Controls.Add(this.label6);
            this.AboutPanel.Controls.Add(this.label5);
            this.AboutPanel.Controls.Add(this.label4);
            this.AboutPanel.Controls.Add(this.label3);
            this.AboutPanel.Controls.Add(this.label2);
            this.AboutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AboutPanel.Location = new System.Drawing.Point(182, 58);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(709, 521);
            this.AboutPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label5.Location = new System.Drawing.Point(74, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Alexander Katrinets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label4.Location = new System.Drawing.Point(40, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contacts:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label3.Location = new System.Drawing.Point(50, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Application was created by:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "iTKerry\'s SensorTool";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label6.Location = new System.Drawing.Point(50, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phone numbers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label7.Location = new System.Drawing.Point(74, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "+380938010331";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label8.Location = new System.Drawing.Point(74, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "+380968949962";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.label9.Location = new System.Drawing.Point(50, 325);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Links:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.linkLabel1.Location = new System.Drawing.Point(74, 352);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(215, 21);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/iTKerry";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.linkLabel2.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.linkLabel2.Location = new System.Drawing.Point(74, 382);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(179, 21);
            this.linkLabel2.TabIndex = 9;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://vk.com/itkerry";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(342, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(344, 172);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(891, 579);
            this.Controls.Add(this.AboutPanel);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(686, 579);
            this.Name = "Form1";
            this.Text = "iTKerry\'s Sensor Tool :: INFO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.groupboxPorts.ResumeLayout(false);
            this.groupboxPorts.PerformLayout();
            this.taskbarNotify_contextMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.SettingsPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ChartPanel.ResumeLayout(false);
            this.ChartPanel.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_ConsoleOutput;
        private System.Windows.Forms.NotifyIcon taskbarNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip taskbarNotify_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem tEXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnClearChat;
        private System.Windows.Forms.Timer StopWatchTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button ChartButton;
        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Label MainLable;
        private System.Windows.Forms.Button ApplicationMinimizeBtn;
        private System.Windows.Forms.Button ApplicationMaximizeBtn;
        private System.Windows.Forms.Button ApplicationExitBtn;
        private System.Windows.Forms.GroupBox groupboxPorts;
        private System.Windows.Forms.Label labelSensor;
        private System.Windows.Forms.Label labelActuator;
        private System.Windows.Forms.ComboBox cmbSensors;
        private System.Windows.Forms.ComboBox cmbActuators;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox ChartCheckListBox;
        private System.Windows.Forms.Panel StatusBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label StopwatchLable;
        private System.Windows.Forms.Label TemperatureLable;
        private System.Windows.Forms.Label IlluminationLabel;
        private System.Windows.Forms.Label RunningStatusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

