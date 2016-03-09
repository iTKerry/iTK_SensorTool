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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cmbSensors = new System.Windows.Forms.ComboBox();
            this.cmbActuators = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.groupboxPorts = new System.Windows.Forms.GroupBox();
            this.labelSensor = new System.Windows.Forms.Label();
            this.labelActuator = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.textBox_ConsoleOutput = new System.Windows.Forms.TextBox();
            this.statusStrip_ = new System.Windows.Forms.StatusStrip();
            this.toolStrip_RunningStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_IlluminationStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip_TemperatureStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.taskbarNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.taskbarNotify_contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tEXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupboxPorts.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabChart.SuspendLayout();
            this.statusStrip_.SuspendLayout();
            this.taskbarNotify_contextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSensors
            // 
            this.cmbSensors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSensors.FormattingEnabled = true;
            this.cmbSensors.Location = new System.Drawing.Point(98, 27);
            this.cmbSensors.Name = "cmbSensors";
            this.cmbSensors.Size = new System.Drawing.Size(201, 21);
            this.cmbSensors.TabIndex = 0;
            this.cmbSensors.SelectedIndexChanged += new System.EventHandler(this.cmbSensors_SelectedIndexChanged);
            // 
            // cmbActuators
            // 
            this.cmbActuators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActuators.FormattingEnabled = true;
            this.cmbActuators.Location = new System.Drawing.Point(98, 65);
            this.cmbActuators.Name = "cmbActuators";
            this.cmbActuators.Size = new System.Drawing.Size(201, 21);
            this.cmbActuators.TabIndex = 1;
            this.cmbActuators.SelectedIndexChanged += new System.EventHandler(this.cmbActuators_SelectedIndexChanged);
            // 
            // btnStop
            // 
            this.btnStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStop.Location = new System.Drawing.Point(468, 483);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(387, 483);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 3;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // groupboxPorts
            // 
            this.groupboxPorts.Controls.Add(this.labelSensor);
            this.groupboxPorts.Controls.Add(this.labelActuator);
            this.groupboxPorts.Controls.Add(this.cmbSensors);
            this.groupboxPorts.Controls.Add(this.cmbActuators);
            this.groupboxPorts.Location = new System.Drawing.Point(6, 6);
            this.groupboxPorts.Name = "groupboxPorts";
            this.groupboxPorts.Size = new System.Drawing.Size(341, 128);
            this.groupboxPorts.TabIndex = 4;
            this.groupboxPorts.TabStop = false;
            this.groupboxPorts.Text = "PORTS";
            // 
            // labelSensor
            // 
            this.labelSensor.AutoSize = true;
            this.labelSensor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSensor.Location = new System.Drawing.Point(6, 30);
            this.labelSensor.Name = "labelSensor";
            this.labelSensor.Size = new System.Drawing.Size(77, 13);
            this.labelSensor.TabIndex = 5;
            this.labelSensor.Text = "Sensor Port:";
            // 
            // labelActuator
            // 
            this.labelActuator.AutoSize = true;
            this.labelActuator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActuator.Location = new System.Drawing.Point(6, 68);
            this.labelActuator.Name = "labelActuator";
            this.labelActuator.Size = new System.Drawing.Size(86, 13);
            this.labelActuator.TabIndex = 6;
            this.labelActuator.Text = "Actuator Port:";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabChart);
            this.tabControl1.Location = new System.Drawing.Point(2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 475);
            this.tabControl1.TabIndex = 5;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.groupboxPorts);
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(545, 449);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.Chart);
            this.tabChart.Controls.Add(this.textBox_ConsoleOutput);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(545, 449);
            this.tabChart.TabIndex = 1;
            this.tabChart.Text = "Chart";
            this.tabChart.UseVisualStyleBackColor = true;
            // 
            // textBox_ConsoleOutput
            // 
            this.textBox_ConsoleOutput.Location = new System.Drawing.Point(6, 6);
            this.textBox_ConsoleOutput.Multiline = true;
            this.textBox_ConsoleOutput.Name = "textBox_ConsoleOutput";
            this.textBox_ConsoleOutput.ReadOnly = true;
            this.textBox_ConsoleOutput.Size = new System.Drawing.Size(155, 437);
            this.textBox_ConsoleOutput.TabIndex = 0;
            // 
            // statusStrip_
            // 
            this.statusStrip_.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_RunningStatus,
            this.toolStrip_IlluminationStatus,
            this.toolStrip_TemperatureStatus});
            this.statusStrip_.Location = new System.Drawing.Point(0, 509);
            this.statusStrip_.Name = "statusStrip_";
            this.statusStrip_.Size = new System.Drawing.Size(557, 22);
            this.statusStrip_.TabIndex = 6;
            this.statusStrip_.Text = "StatusBar";
            // 
            // toolStrip_RunningStatus
            // 
            this.toolStrip_RunningStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStrip_RunningStatus.Name = "toolStrip_RunningStatus";
            this.toolStrip_RunningStatus.Size = new System.Drawing.Size(60, 17);
            this.toolStrip_RunningStatus.Text = "Stopped...";
            // 
            // toolStrip_IlluminationStatus
            // 
            this.toolStrip_IlluminationStatus.Name = "toolStrip_IlluminationStatus";
            this.toolStrip_IlluminationStatus.Size = new System.Drawing.Size(82, 17);
            this.toolStrip_IlluminationStatus.Text = "Illumination: -";
            // 
            // toolStrip_TemperatureStatus
            // 
            this.toolStrip_TemperatureStatus.Name = "toolStrip_TemperatureStatus";
            this.toolStrip_TemperatureStatus.Size = new System.Drawing.Size(85, 17);
            this.toolStrip_TemperatureStatus.Text = "Temperature: -";
            // 
            // taskbarNotify
            // 
            this.taskbarNotify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.taskbarNotify.BalloonTipText = "This is text";
            this.taskbarNotify.BalloonTipTitle = "This is title";
            this.taskbarNotify.ContextMenuStrip = this.taskbarNotify_contextMenu;
            this.taskbarNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarNotify.Icon")));
            this.taskbarNotify.Text = "iTK Sensor Tool :: ";
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
            // Chart
            // 
            this.Chart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            this.Chart.BorderSkin.BorderWidth = 3;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 94F;
            chartArea1.Position.Width = 60.02174F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 3F;
            this.Chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Chart.Legends.Add(legend1);
            this.Chart.Location = new System.Drawing.Point(168, 7);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Illumination";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Temperature";
            this.Chart.Series.Add(series1);
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(369, 330);
            this.Chart.TabIndex = 1;
            this.Chart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnStop;
            this.ClientSize = new System.Drawing.Size(557, 531);
            this.Controls.Add(this.statusStrip_);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(573, 570);
            this.MinimumSize = new System.Drawing.Size(573, 570);
            this.Name = "Form1";
            this.Text = "iTKerry\'s Sensor Tool :: INFO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupboxPorts.ResumeLayout(false);
            this.groupboxPorts.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabChart.ResumeLayout(false);
            this.tabChart.PerformLayout();
            this.statusStrip_.ResumeLayout(false);
            this.statusStrip_.PerformLayout();
            this.taskbarNotify_contextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSensors;
        private System.Windows.Forms.ComboBox cmbActuators;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.GroupBox groupboxPorts;
        private System.Windows.Forms.Label labelActuator;
        private System.Windows.Forms.Label labelSensor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.StatusStrip statusStrip_;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_RunningStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_IlluminationStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_TemperatureStatus;
        private System.Windows.Forms.TextBox textBox_ConsoleOutput;
        private System.Windows.Forms.NotifyIcon taskbarNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip taskbarNotify_contextMenu;
        private System.Windows.Forms.ToolStripMenuItem tEXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
    }
}

