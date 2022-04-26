namespace Forms
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabSerial = new System.Windows.Forms.TabPage();
            this.buttonGetTask = new System.Windows.Forms.Button();
            this.textBoxOutputValue = new System.Windows.Forms.TextBox();
            this.textBoxDataID = new System.Windows.Forms.TextBox();
            this.buttonClearFeed = new System.Windows.Forms.Button();
            this.buttonClearStatus = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonConfigWindow = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxStatus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonManual2 = new System.Windows.Forms.Button();
            this.buttonShowCommands = new System.Windows.Forms.Button();
            this.buttonAuto2 = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxCommunication = new System.Windows.Forms.TextBox();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelBitRate = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxBitRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxScaledLive = new System.Windows.Forms.TextBox();
            this.textBoxAverage = new System.Windows.Forms.TextBox();
            this.labelAverage = new System.Windows.Forms.Label();
            this.textBoxRawLive = new System.Windows.Forms.TextBox();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.chartSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonScaled = new System.Windows.Forms.RadioButton();
            this.radioButtonRaw = new System.Windows.Forms.RadioButton();
            this.StatusStrip2 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialogData = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBoxFreq = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabs.SuspendLayout();
            this.tabSerial.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).BeginInit();
            this.panel1.SuspendLayout();
            this.StatusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabSerial);
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(902, 552);
            this.tabs.TabIndex = 0;
            this.tabs.Tag = "";
            // 
            // tabSerial
            // 
            this.tabSerial.Controls.Add(this.buttonGetTask);
            this.tabSerial.Controls.Add(this.textBoxOutputValue);
            this.tabSerial.Controls.Add(this.textBoxDataID);
            this.tabSerial.Controls.Add(this.buttonClearFeed);
            this.tabSerial.Controls.Add(this.buttonClearStatus);
            this.tabSerial.Controls.Add(this.buttonStatus);
            this.tabSerial.Controls.Add(this.statusStrip1);
            this.tabSerial.Controls.Add(this.buttonConfigWindow);
            this.tabSerial.Controls.Add(this.groupBox2);
            this.tabSerial.Controls.Add(this.label3);
            this.tabSerial.Controls.Add(this.groupBox1);
            this.tabSerial.Controls.Add(this.toolStrip1);
            this.tabSerial.Controls.Add(this.textBoxCommunication);
            this.tabSerial.Controls.Add(this.buttonDisconnect);
            this.tabSerial.Controls.Add(this.buttonConnect);
            this.tabSerial.Controls.Add(this.labelBitRate);
            this.tabSerial.Controls.Add(this.labelPort);
            this.tabSerial.Controls.Add(this.comboBoxBitRate);
            this.tabSerial.Controls.Add(this.comboBoxCOM);
            this.tabSerial.Location = new System.Drawing.Point(4, 25);
            this.tabSerial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSerial.Name = "tabSerial";
            this.tabSerial.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabSerial.Size = new System.Drawing.Size(894, 523);
            this.tabSerial.TabIndex = 3;
            this.tabSerial.Text = "Serial";
            this.tabSerial.UseVisualStyleBackColor = true;
            // 
            // buttonGetTask
            // 
            this.buttonGetTask.Location = new System.Drawing.Point(463, 366);
            this.buttonGetTask.Name = "buttonGetTask";
            this.buttonGetTask.Size = new System.Drawing.Size(75, 23);
            this.buttonGetTask.TabIndex = 28;
            this.buttonGetTask.Text = "get task";
            this.buttonGetTask.UseVisualStyleBackColor = true;
            this.buttonGetTask.Click += new System.EventHandler(this.buttonGetTask_Click);
            // 
            // textBoxOutputValue
            // 
            this.textBoxOutputValue.Location = new System.Drawing.Point(582, 394);
            this.textBoxOutputValue.Name = "textBoxOutputValue";
            this.textBoxOutputValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxOutputValue.TabIndex = 27;
            // 
            // textBoxDataID
            // 
            this.textBoxDataID.Location = new System.Drawing.Point(463, 395);
            this.textBoxDataID.Name = "textBoxDataID";
            this.textBoxDataID.Size = new System.Drawing.Size(100, 22);
            this.textBoxDataID.TabIndex = 26;
            // 
            // buttonClearFeed
            // 
            this.buttonClearFeed.Location = new System.Drawing.Point(546, 315);
            this.buttonClearFeed.Name = "buttonClearFeed";
            this.buttonClearFeed.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFeed.TabIndex = 25;
            this.buttonClearFeed.Text = "Clear";
            this.buttonClearFeed.UseVisualStyleBackColor = true;
            this.buttonClearFeed.Click += new System.EventHandler(this.buttonClearFeed_Click);
            // 
            // buttonClearStatus
            // 
            this.buttonClearStatus.Location = new System.Drawing.Point(228, 452);
            this.buttonClearStatus.Name = "buttonClearStatus";
            this.buttonClearStatus.Size = new System.Drawing.Size(75, 23);
            this.buttonClearStatus.TabIndex = 24;
            this.buttonClearStatus.Text = "Clear";
            this.buttonClearStatus.UseVisualStyleBackColor = true;
            this.buttonClearStatus.Click += new System.EventHandler(this.buttonClearStatus_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(29, 452);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(116, 23);
            this.buttonStatus.TabIndex = 23;
            this.buttonStatus.Text = "Update Status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 492);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 29);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "ToolStripStatus";
            // 
            // StatusLabel1
            // 
            this.StatusLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel1.Name = "StatusLabel1";
            this.StatusLabel1.Size = new System.Drawing.Size(156, 23);
            this.StatusLabel1.Text = "Waiting for status...";
            // 
            // buttonConfigWindow
            // 
            this.buttonConfigWindow.Location = new System.Drawing.Point(22, 187);
            this.buttonConfigWindow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConfigWindow.Name = "buttonConfigWindow";
            this.buttonConfigWindow.Size = new System.Drawing.Size(204, 23);
            this.buttonConfigWindow.TabIndex = 4;
            this.buttonConfigWindow.Text = "Configure Device";
            this.buttonConfigWindow.UseVisualStyleBackColor = true;
            this.buttonConfigWindow.Click += new System.EventHandler(this.buttonConfigWindow_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxStatus);
            this.groupBox2.Location = new System.Drawing.Point(22, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 219);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status History";
            // 
            // textBoxStatus
            // 
            this.textBoxStatus.Location = new System.Drawing.Point(7, 22);
            this.textBoxStatus.Multiline = true;
            this.textBoxStatus.Name = "textBoxStatus";
            this.textBoxStatus.Size = new System.Drawing.Size(274, 191);
            this.textBoxStatus.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Communication Feed";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxFreq);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonManual2);
            this.groupBox1.Controls.Add(this.buttonShowCommands);
            this.groupBox1.Controls.Add(this.buttonAuto2);
            this.groupBox1.Controls.Add(this.textBoxSend);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Location = new System.Drawing.Point(329, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 160);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual commands";
            // 
            // buttonManual2
            // 
            this.buttonManual2.Location = new System.Drawing.Point(100, 93);
            this.buttonManual2.Name = "buttonManual2";
            this.buttonManual2.Size = new System.Drawing.Size(74, 23);
            this.buttonManual2.TabIndex = 24;
            this.buttonManual2.Text = "Manual";
            this.buttonManual2.UseVisualStyleBackColor = true;
            this.buttonManual2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonShowCommands
            // 
            this.buttonShowCommands.BackgroundImage = global::Forms.Properties.Resources.info;
            this.buttonShowCommands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonShowCommands.Location = new System.Drawing.Point(173, 42);
            this.buttonShowCommands.Name = "buttonShowCommands";
            this.buttonShowCommands.Size = new System.Drawing.Size(26, 24);
            this.buttonShowCommands.TabIndex = 15;
            this.buttonShowCommands.UseVisualStyleBackColor = true;
            this.buttonShowCommands.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAuto2
            // 
            this.buttonAuto2.Location = new System.Drawing.Point(17, 93);
            this.buttonAuto2.Name = "buttonAuto2";
            this.buttonAuto2.Size = new System.Drawing.Size(74, 23);
            this.buttonAuto2.TabIndex = 23;
            this.buttonAuto2.Text = "Auto";
            this.buttonAuto2.UseVisualStyleBackColor = true;
            this.buttonAuto2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(100, 43);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(71, 22);
            this.textBoxSend.TabIndex = 7;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(17, 42);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(74, 23);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(3, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(888, 31);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(111, 28);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // textBoxCommunication
            // 
            this.textBoxCommunication.Location = new System.Drawing.Point(543, 72);
            this.textBoxCommunication.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxCommunication.Multiline = true;
            this.textBoxCommunication.Name = "textBoxCommunication";
            this.textBoxCommunication.ReadOnly = true;
            this.textBoxCommunication.Size = new System.Drawing.Size(335, 237);
            this.textBoxCommunication.TabIndex = 9;
            this.textBoxCommunication.TabStop = false;
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(127, 160);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(99, 23);
            this.buttonDisconnect.TabIndex = 3;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(22, 160);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(99, 23);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelBitRate
            // 
            this.labelBitRate.AutoSize = true;
            this.labelBitRate.Location = new System.Drawing.Point(19, 116);
            this.labelBitRate.Name = "labelBitRate";
            this.labelBitRate.Size = new System.Drawing.Size(54, 16);
            this.labelBitRate.TabIndex = 3;
            this.labelBitRate.Tag = "";
            this.labelBitRate.Text = "Bit Rate";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(19, 72);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(64, 16);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "COM Port";
            // 
            // comboBoxBitRate
            // 
            this.comboBoxBitRate.FormattingEnabled = true;
            this.comboBoxBitRate.Location = new System.Drawing.Point(93, 113);
            this.comboBoxBitRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBitRate.Name = "comboBoxBitRate";
            this.comboBoxBitRate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBitRate.TabIndex = 1;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(93, 67);
            this.comboBoxCOM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCOM.TabIndex = 0;
            this.comboBoxCOM.SelectedIndexChanged += new System.EventHandler(this.comboBoxCOM_SelectedIndexChanged);
            this.comboBoxCOM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.StatusStrip2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(894, 523);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.buttonAuto);
            this.groupBox3.Controls.Add(this.buttonManual);
            this.groupBox3.Controls.Add(this.chartSeries);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 475);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Chart";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxScaledLive);
            this.groupBox4.Controls.Add(this.textBoxAverage);
            this.groupBox4.Controls.Add(this.labelAverage);
            this.groupBox4.Controls.Add(this.textBoxRawLive);
            this.groupBox4.Location = new System.Drawing.Point(599, 156);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(245, 161);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Live Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Scaled Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raw Value:";
            // 
            // textBoxScaledLive
            // 
            this.textBoxScaledLive.Location = new System.Drawing.Point(125, 78);
            this.textBoxScaledLive.Name = "textBoxScaledLive";
            this.textBoxScaledLive.ReadOnly = true;
            this.textBoxScaledLive.Size = new System.Drawing.Size(100, 22);
            this.textBoxScaledLive.TabIndex = 1;
            // 
            // textBoxAverage
            // 
            this.textBoxAverage.Location = new System.Drawing.Point(125, 124);
            this.textBoxAverage.Name = "textBoxAverage";
            this.textBoxAverage.ReadOnly = true;
            this.textBoxAverage.Size = new System.Drawing.Size(100, 22);
            this.textBoxAverage.TabIndex = 19;
            // 
            // labelAverage
            // 
            this.labelAverage.AutoSize = true;
            this.labelAverage.Location = new System.Drawing.Point(12, 130);
            this.labelAverage.Name = "labelAverage";
            this.labelAverage.Size = new System.Drawing.Size(108, 16);
            this.labelAverage.TabIndex = 20;
            this.labelAverage.Text = "Scaled Average:";
            this.labelAverage.Click += new System.EventHandler(this.labelAverage_Click);
            // 
            // textBoxRawLive
            // 
            this.textBoxRawLive.Location = new System.Drawing.Point(125, 45);
            this.textBoxRawLive.Name = "textBoxRawLive";
            this.textBoxRawLive.ReadOnly = true;
            this.textBoxRawLive.Size = new System.Drawing.Size(100, 22);
            this.textBoxRawLive.TabIndex = 0;
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(599, 65);
            this.buttonAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(75, 23);
            this.buttonAuto.TabIndex = 5;
            this.buttonAuto.Text = "Start";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // buttonManual
            // 
            this.buttonManual.Location = new System.Drawing.Point(599, 105);
            this.buttonManual.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(75, 23);
            this.buttonManual.TabIndex = 6;
            this.buttonManual.Text = "Stop";
            this.buttonManual.UseVisualStyleBackColor = true;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // chartSeries
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSeries.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartSeries.Legends.Add(legend2);
            this.chartSeries.Location = new System.Drawing.Point(6, 20);
            this.chartSeries.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartSeries.Name = "chartSeries";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Vba";
            this.chartSeries.Series.Add(series2);
            this.chartSeries.Size = new System.Drawing.Size(712, 450);
            this.chartSeries.TabIndex = 13;
            this.chartSeries.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonScaled);
            this.panel1.Controls.Add(this.radioButtonRaw);
            this.panel1.Location = new System.Drawing.Point(705, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 74);
            this.panel1.TabIndex = 18;
            // 
            // radioButtonScaled
            // 
            this.radioButtonScaled.AutoSize = true;
            this.radioButtonScaled.Location = new System.Drawing.Point(19, 41);
            this.radioButtonScaled.Name = "radioButtonScaled";
            this.radioButtonScaled.Size = new System.Drawing.Size(120, 20);
            this.radioButtonScaled.TabIndex = 10;
            this.radioButtonScaled.TabStop = true;
            this.radioButtonScaled.Text = "Scaled reading";
            this.radioButtonScaled.UseVisualStyleBackColor = true;
            this.radioButtonScaled.Click += new System.EventHandler(this.radioButtonScaled_Click);
            // 
            // radioButtonRaw
            // 
            this.radioButtonRaw.AutoSize = true;
            this.radioButtonRaw.Location = new System.Drawing.Point(19, 15);
            this.radioButtonRaw.Name = "radioButtonRaw";
            this.radioButtonRaw.Size = new System.Drawing.Size(104, 20);
            this.radioButtonRaw.TabIndex = 9;
            this.radioButtonRaw.TabStop = true;
            this.radioButtonRaw.Text = "Raw reading";
            this.radioButtonRaw.UseVisualStyleBackColor = true;
            // 
            // StatusStrip2
            // 
            this.StatusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel2});
            this.StatusStrip2.Location = new System.Drawing.Point(0, 494);
            this.StatusStrip2.Name = "StatusStrip2";
            this.StatusStrip2.Size = new System.Drawing.Size(894, 29);
            this.StatusStrip2.TabIndex = 23;
            this.StatusStrip2.Text = "statusStrip2";
            // 
            // StatusLabel2
            // 
            this.StatusLabel2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel2.Name = "StatusLabel2";
            this.StatusLabel2.Size = new System.Drawing.Size(156, 23);
            this.StatusLabel2.Text = "Waiting for status...";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // textBoxFreq
            // 
            this.textBoxFreq.Location = new System.Drawing.Point(107, 127);
            this.textBoxFreq.Name = "textBoxFreq";
            this.textBoxFreq.Size = new System.Drawing.Size(82, 22);
            this.textBoxFreq.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 30;
            this.label4.Text = "frequency(ms):";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(902, 552);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SoftSensConf";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabSerial.ResumeLayout(false);
            this.tabSerial.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.StatusStrip2.ResumeLayout(false);
            this.StatusStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabSerial;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelBitRate;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxBitRate;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSeries;
        private System.Windows.Forms.Button buttonConfigWindow;
        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonScaled;
        private System.Windows.Forms.RadioButton radioButtonRaw;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonShowCommands;
        private System.Windows.Forms.Button buttonManual;
        public System.Windows.Forms.TextBox textBoxCommunication;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel1;
        private System.Windows.Forms.StatusStrip StatusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel2;
        private System.Windows.Forms.TextBox textBoxStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelAverage;
        private System.Windows.Forms.TextBox textBoxAverage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxScaledLive;
        private System.Windows.Forms.TextBox textBoxRawLive;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonManual2;
        private System.Windows.Forms.Button buttonAuto2;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonClearFeed;
        private System.Windows.Forms.Button buttonClearStatus;
        private System.Windows.Forms.TextBox textBoxOutputValue;
        private System.Windows.Forms.TextBox textBoxDataID;
        private System.Windows.Forms.Button buttonGetTask;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBoxFreq;
        private System.Windows.Forms.Label label4;
    }
}

