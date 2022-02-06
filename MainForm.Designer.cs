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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabstring = new System.Windows.Forms.TabPage();
            this.ResultButton = new System.Windows.Forms.Button();
            this.checkBoxCase = new System.Windows.Forms.CheckBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabLoops2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSplit = new System.Windows.Forms.Button();
            this.buttonContains = new System.Windows.Forms.Button();
            this.textLoopsResult = new System.Windows.Forms.TextBox();
            this.textLoopsString1 = new System.Windows.Forms.TextBox();
            this.textBoxString2 = new System.Windows.Forms.TextBox();
            this.tabLists = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.textBoxAdd = new System.Windows.Forms.TextBox();
            this.tabSerial = new System.Windows.Forms.TabPage();
            this.buttonConfigWindow = new System.Windows.Forms.Button();
            this.chartSeries = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonManual = new System.Windows.Forms.Button();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.textBoxCommunication = new System.Windows.Forms.TextBox();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelBitRate = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxBitRate = new System.Windows.Forms.ComboBox();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabs.SuspendLayout();
            this.tabstring.SuspendLayout();
            this.tabLoops2.SuspendLayout();
            this.tabLists.SuspendLayout();
            this.tabSerial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabstring);
            this.tabs.Controls.Add(this.tabLoops2);
            this.tabs.Controls.Add(this.tabLists);
            this.tabs.Controls.Add(this.tabSerial);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Margin = new System.Windows.Forms.Padding(2);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(686, 537);
            this.tabs.TabIndex = 0;
            this.tabs.Tag = "";
            // 
            // tabstring
            // 
            this.tabstring.Controls.Add(this.ResultButton);
            this.tabstring.Controls.Add(this.checkBoxCase);
            this.tabstring.Controls.Add(this.textBoxResult);
            this.tabstring.Controls.Add(this.textBox2);
            this.tabstring.Controls.Add(this.textBox1);
            this.tabstring.Location = new System.Drawing.Point(4, 22);
            this.tabstring.Margin = new System.Windows.Forms.Padding(2);
            this.tabstring.Name = "tabstring";
            this.tabstring.Padding = new System.Windows.Forms.Padding(2);
            this.tabstring.Size = new System.Drawing.Size(678, 511);
            this.tabstring.TabIndex = 0;
            this.tabstring.Text = "String";
            this.tabstring.UseVisualStyleBackColor = true;
            // 
            // ResultButton
            // 
            this.ResultButton.Location = new System.Drawing.Point(54, 253);
            this.ResultButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResultButton.Name = "ResultButton";
            this.ResultButton.Size = new System.Drawing.Size(56, 19);
            this.ResultButton.TabIndex = 4;
            this.ResultButton.Text = "Result";
            this.ResultButton.UseVisualStyleBackColor = true;
            this.ResultButton.Click += new System.EventHandler(this.ResultButton_Click);
            // 
            // checkBoxCase
            // 
            this.checkBoxCase.AutoSize = true;
            this.checkBoxCase.Location = new System.Drawing.Point(35, 187);
            this.checkBoxCase.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxCase.Name = "checkBoxCase";
            this.checkBoxCase.Size = new System.Drawing.Size(96, 17);
            this.checkBoxCase.TabIndex = 3;
            this.checkBoxCase.Text = "Case Sensitive";
            this.checkBoxCase.UseVisualStyleBackColor = true;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(190, 28);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(264, 154);
            this.textBoxResult.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(35, 69);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabLoops2
            // 
            this.tabLoops2.Controls.Add(this.label2);
            this.tabLoops2.Controls.Add(this.label1);
            this.tabLoops2.Controls.Add(this.buttonSplit);
            this.tabLoops2.Controls.Add(this.buttonContains);
            this.tabLoops2.Controls.Add(this.textLoopsResult);
            this.tabLoops2.Controls.Add(this.textLoopsString1);
            this.tabLoops2.Controls.Add(this.textBoxString2);
            this.tabLoops2.Location = new System.Drawing.Point(4, 22);
            this.tabLoops2.Margin = new System.Windows.Forms.Padding(2);
            this.tabLoops2.Name = "tabLoops2";
            this.tabLoops2.Padding = new System.Windows.Forms.Padding(2);
            this.tabLoops2.Size = new System.Drawing.Size(678, 511);
            this.tabLoops2.TabIndex = 1;
            this.tabLoops2.Text = "Loops";
            this.tabLoops2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "string 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "string 1";
            // 
            // buttonSplit
            // 
            this.buttonSplit.Location = new System.Drawing.Point(37, 197);
            this.buttonSplit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSplit.Name = "buttonSplit";
            this.buttonSplit.Size = new System.Drawing.Size(75, 19);
            this.buttonSplit.TabIndex = 4;
            this.buttonSplit.Text = "split";
            this.buttonSplit.UseVisualStyleBackColor = true;
            this.buttonSplit.Click += new System.EventHandler(this.buttonSplit_Click);
            // 
            // buttonContains
            // 
            this.buttonContains.Location = new System.Drawing.Point(37, 151);
            this.buttonContains.Margin = new System.Windows.Forms.Padding(2);
            this.buttonContains.Name = "buttonContains";
            this.buttonContains.Size = new System.Drawing.Size(75, 19);
            this.buttonContains.TabIndex = 3;
            this.buttonContains.Text = "1_contains_2";
            this.buttonContains.UseVisualStyleBackColor = true;
            this.buttonContains.Click += new System.EventHandler(this.buttonContains_Click);
            // 
            // textLoopsResult
            // 
            this.textLoopsResult.Location = new System.Drawing.Point(216, 37);
            this.textLoopsResult.Margin = new System.Windows.Forms.Padding(2);
            this.textLoopsResult.Multiline = true;
            this.textLoopsResult.Name = "textLoopsResult";
            this.textLoopsResult.Size = new System.Drawing.Size(209, 258);
            this.textLoopsResult.TabIndex = 2;
            // 
            // textLoopsString1
            // 
            this.textLoopsString1.Location = new System.Drawing.Point(37, 79);
            this.textLoopsString1.Margin = new System.Windows.Forms.Padding(2);
            this.textLoopsString1.Name = "textLoopsString1";
            this.textLoopsString1.Size = new System.Drawing.Size(76, 20);
            this.textLoopsString1.TabIndex = 1;
            // 
            // textBoxString2
            // 
            this.textBoxString2.Location = new System.Drawing.Point(37, 115);
            this.textBoxString2.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxString2.Name = "textBoxString2";
            this.textBoxString2.Size = new System.Drawing.Size(76, 20);
            this.textBoxString2.TabIndex = 0;
            // 
            // tabLists
            // 
            this.tabLists.Controls.Add(this.comboBox1);
            this.tabLists.Controls.Add(this.buttonRemove);
            this.tabLists.Controls.Add(this.buttonAdd);
            this.tabLists.Controls.Add(this.listBoxResult);
            this.tabLists.Controls.Add(this.textBoxAdd);
            this.tabLists.Location = new System.Drawing.Point(4, 22);
            this.tabLists.Margin = new System.Windows.Forms.Padding(2);
            this.tabLists.Name = "tabLists";
            this.tabLists.Padding = new System.Windows.Forms.Padding(2);
            this.tabLists.Size = new System.Drawing.Size(678, 511);
            this.tabLists.TabIndex = 2;
            this.tabLists.Text = "Lists";
            this.tabLists.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 51);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(34, 197);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(56, 19);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(34, 160);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 19);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Location = new System.Drawing.Point(240, 28);
            this.listBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(160, 147);
            this.listBoxResult.TabIndex = 1;
            // 
            // textBoxAdd
            // 
            this.textBoxAdd.Location = new System.Drawing.Point(34, 28);
            this.textBoxAdd.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxAdd.Name = "textBoxAdd";
            this.textBoxAdd.Size = new System.Drawing.Size(114, 20);
            this.textBoxAdd.TabIndex = 0;
            // 
            // tabSerial
            // 
            this.tabSerial.Controls.Add(this.buttonConfigWindow);
            this.tabSerial.Controls.Add(this.chartSeries);
            this.tabSerial.Controls.Add(this.buttonManual);
            this.tabSerial.Controls.Add(this.buttonAuto);
            this.tabSerial.Controls.Add(this.toolStrip1);
            this.tabSerial.Controls.Add(this.textBoxCommunication);
            this.tabSerial.Controls.Add(this.textBoxSend);
            this.tabSerial.Controls.Add(this.buttonSend);
            this.tabSerial.Controls.Add(this.buttonDisconnect);
            this.tabSerial.Controls.Add(this.buttonConnect);
            this.tabSerial.Controls.Add(this.labelBitRate);
            this.tabSerial.Controls.Add(this.labelPort);
            this.tabSerial.Controls.Add(this.comboBoxBitRate);
            this.tabSerial.Controls.Add(this.comboBoxCOM);
            this.tabSerial.Location = new System.Drawing.Point(4, 22);
            this.tabSerial.Margin = new System.Windows.Forms.Padding(2);
            this.tabSerial.Name = "tabSerial";
            this.tabSerial.Padding = new System.Windows.Forms.Padding(2);
            this.tabSerial.Size = new System.Drawing.Size(678, 511);
            this.tabSerial.TabIndex = 3;
            this.tabSerial.Text = "Serial";
            this.tabSerial.UseVisualStyleBackColor = true;
            // 
            // buttonConfigWindow
            // 
            this.buttonConfigWindow.Location = new System.Drawing.Point(190, 151);
            this.buttonConfigWindow.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConfigWindow.Name = "buttonConfigWindow";
            this.buttonConfigWindow.Size = new System.Drawing.Size(94, 19);
            this.buttonConfigWindow.TabIndex = 14;
            this.buttonConfigWindow.Text = "load config";
            this.buttonConfigWindow.UseVisualStyleBackColor = true;
            this.buttonConfigWindow.Click += new System.EventHandler(this.buttonConfigWindow_Click);
            // 
            // chartSeries
            // 
            chartArea4.Name = "ChartArea1";
            this.chartSeries.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSeries.Legends.Add(legend4);
            this.chartSeries.Location = new System.Drawing.Point(58, 305);
            this.chartSeries.Margin = new System.Windows.Forms.Padding(2);
            this.chartSeries.Name = "chartSeries";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Vba";
            this.chartSeries.Series.Add(series4);
            this.chartSeries.Size = new System.Drawing.Size(566, 206);
            this.chartSeries.TabIndex = 13;
            this.chartSeries.Text = "chart1";
            // 
            // buttonManual
            // 
            this.buttonManual.Location = new System.Drawing.Point(474, 256);
            this.buttonManual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(56, 19);
            this.buttonManual.TabIndex = 12;
            this.buttonManual.Text = "manual";
            this.buttonManual.UseVisualStyleBackColor = true;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // buttonAuto
            // 
            this.buttonAuto.Location = new System.Drawing.Point(341, 256);
            this.buttonAuto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(56, 19);
            this.buttonAuto.TabIndex = 11;
            this.buttonAuto.Text = "auto";
            this.buttonAuto.UseVisualStyleBackColor = true;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(2, 2);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(674, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // textBoxCommunication
            // 
            this.textBoxCommunication.Location = new System.Drawing.Point(341, 43);
            this.textBoxCommunication.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxCommunication.Multiline = true;
            this.textBoxCommunication.Name = "textBoxCommunication";
            this.textBoxCommunication.Size = new System.Drawing.Size(252, 193);
            this.textBoxCommunication.TabIndex = 9;
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(190, 45);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(76, 20);
            this.textBoxSend.TabIndex = 8;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(280, 45);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(56, 19);
            this.buttonSend.TabIndex = 6;
            this.buttonSend.Text = "send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(37, 199);
            this.buttonDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(68, 19);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(37, 151);
            this.buttonConnect.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(68, 19);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelBitRate
            // 
            this.labelBitRate.AutoSize = true;
            this.labelBitRate.Location = new System.Drawing.Point(2, 106);
            this.labelBitRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBitRate.Name = "labelBitRate";
            this.labelBitRate.Size = new System.Drawing.Size(45, 13);
            this.labelBitRate.TabIndex = 3;
            this.labelBitRate.Tag = "";
            this.labelBitRate.Text = "Bit Rate";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(2, 47);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(53, 13);
            this.labelPort.TabIndex = 2;
            this.labelPort.Text = "COM Port";
            // 
            // comboBoxBitRate
            // 
            this.comboBoxBitRate.FormattingEnabled = true;
            this.comboBoxBitRate.Location = new System.Drawing.Point(58, 103);
            this.comboBoxBitRate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBitRate.Name = "comboBoxBitRate";
            this.comboBoxBitRate.Size = new System.Drawing.Size(92, 21);
            this.comboBoxBitRate.TabIndex = 1;
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(58, 43);
            this.comboBoxCOM.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(92, 21);
            this.comboBoxCOM.TabIndex = 0;
            this.comboBoxCOM.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBox2_MouseClick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM4";
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 537);
            this.Controls.Add(this.tabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.tabstring.ResumeLayout(false);
            this.tabstring.PerformLayout();
            this.tabLoops2.ResumeLayout(false);
            this.tabLoops2.PerformLayout();
            this.tabLists.ResumeLayout(false);
            this.tabLists.PerformLayout();
            this.tabSerial.ResumeLayout(false);
            this.tabSerial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSeries)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabstring;
        private System.Windows.Forms.TabPage tabLoops2;
        private System.Windows.Forms.TabPage tabLists;
        private System.Windows.Forms.TabPage tabSerial;
        private System.Windows.Forms.CheckBox checkBoxCase;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button ResultButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSplit;
        private System.Windows.Forms.Button buttonContains;
        private System.Windows.Forms.TextBox textLoopsResult;
        private System.Windows.Forms.TextBox textLoopsString1;
        private System.Windows.Forms.TextBox textBoxString2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.TextBox textBoxAdd;
        private System.Windows.Forms.TextBox textBoxCommunication;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelBitRate;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxBitRate;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSeries;
        private System.Windows.Forms.Button buttonConfigWindow;
        public System.IO.Ports.SerialPort serialPort1;
    }
}

