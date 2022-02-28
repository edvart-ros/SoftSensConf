namespace Forms
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.txtFile = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOpen = new System.Windows.Forms.Button();
            this.groupBoxCurrentConfig = new System.Windows.Forms.GroupBox();
            this.textBoxCurrentAlarmH = new System.Windows.Forms.TextBox();
            this.textBoxCurrentAlarmL = new System.Windows.Forms.TextBox();
            this.textBoxCurrentURV = new System.Windows.Forms.TextBox();
            this.textBoxCurrentLRV = new System.Windows.Forms.TextBox();
            this.textBoxCurrentName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSetAlarmH = new System.Windows.Forms.TextBox();
            this.textBoxSetAlarmL = new System.Windows.Forms.TextBox();
            this.textBoxSetURV = new System.Windows.Forms.TextBox();
            this.textBoxSetLRV = new System.Windows.Forms.TextBox();
            this.textBoxSetName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonSetConfig = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonSaveConfig = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.groupBoxCurrentConfig.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(69, 30);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(415, 22);
            this.txtFile.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(496, 30);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(83, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Load CSV";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // groupBoxCurrentConfig
            // 
            this.groupBoxCurrentConfig.Controls.Add(this.button1);
            this.groupBoxCurrentConfig.Controls.Add(this.textBoxCurrentAlarmH);
            this.groupBoxCurrentConfig.Controls.Add(this.textBoxCurrentAlarmL);
            this.groupBoxCurrentConfig.Controls.Add(this.textBoxCurrentURV);
            this.groupBoxCurrentConfig.Controls.Add(this.textBoxCurrentLRV);
            this.groupBoxCurrentConfig.Controls.Add(this.textBoxCurrentName);
            this.groupBoxCurrentConfig.Controls.Add(this.label5);
            this.groupBoxCurrentConfig.Controls.Add(this.label4);
            this.groupBoxCurrentConfig.Controls.Add(this.label3);
            this.groupBoxCurrentConfig.Controls.Add(this.label2);
            this.groupBoxCurrentConfig.Controls.Add(this.label1);
            this.groupBoxCurrentConfig.Controls.Add(this.buttonUpdate);
            this.groupBoxCurrentConfig.Location = new System.Drawing.Point(386, 84);
            this.groupBoxCurrentConfig.Name = "groupBoxCurrentConfig";
            this.groupBoxCurrentConfig.Size = new System.Drawing.Size(235, 334);
            this.groupBoxCurrentConfig.TabIndex = 8;
            this.groupBoxCurrentConfig.TabStop = false;
            this.groupBoxCurrentConfig.Text = "Current configuration";
            // 
            // textBoxCurrentAlarmH
            // 
            this.textBoxCurrentAlarmH.Location = new System.Drawing.Point(110, 258);
            this.textBoxCurrentAlarmH.Name = "textBoxCurrentAlarmH";
            this.textBoxCurrentAlarmH.ReadOnly = true;
            this.textBoxCurrentAlarmH.Size = new System.Drawing.Size(40, 22);
            this.textBoxCurrentAlarmH.TabIndex = 10;
            // 
            // textBoxCurrentAlarmL
            // 
            this.textBoxCurrentAlarmL.Location = new System.Drawing.Point(110, 214);
            this.textBoxCurrentAlarmL.Name = "textBoxCurrentAlarmL";
            this.textBoxCurrentAlarmL.ReadOnly = true;
            this.textBoxCurrentAlarmL.Size = new System.Drawing.Size(40, 22);
            this.textBoxCurrentAlarmL.TabIndex = 9;
            // 
            // textBoxCurrentURV
            // 
            this.textBoxCurrentURV.Location = new System.Drawing.Point(110, 169);
            this.textBoxCurrentURV.Name = "textBoxCurrentURV";
            this.textBoxCurrentURV.ReadOnly = true;
            this.textBoxCurrentURV.Size = new System.Drawing.Size(40, 22);
            this.textBoxCurrentURV.TabIndex = 8;
            // 
            // textBoxCurrentLRV
            // 
            this.textBoxCurrentLRV.Location = new System.Drawing.Point(110, 124);
            this.textBoxCurrentLRV.Name = "textBoxCurrentLRV";
            this.textBoxCurrentLRV.ReadOnly = true;
            this.textBoxCurrentLRV.Size = new System.Drawing.Size(40, 22);
            this.textBoxCurrentLRV.TabIndex = 7;
            // 
            // textBoxCurrentName
            // 
            this.textBoxCurrentName.Location = new System.Drawing.Point(110, 80);
            this.textBoxCurrentName.Name = "textBoxCurrentName";
            this.textBoxCurrentName.ReadOnly = true;
            this.textBoxCurrentName.Size = new System.Drawing.Size(100, 22);
            this.textBoxCurrentName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Alarm high: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Alarm low:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "URV: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "LRV: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveConfig);
            this.groupBox1.Controls.Add(this.textBoxSetAlarmH);
            this.groupBox1.Controls.Add(this.textBoxSetAlarmL);
            this.groupBox1.Controls.Add(this.textBoxSetURV);
            this.groupBox1.Controls.Add(this.textBoxSetLRV);
            this.groupBox1.Controls.Add(this.textBoxSetName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonSetConfig);
            this.groupBox1.Location = new System.Drawing.Point(69, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 334);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Set New Configuration";
            // 
            // textBoxSetAlarmH
            // 
            this.textBoxSetAlarmH.Location = new System.Drawing.Point(107, 230);
            this.textBoxSetAlarmH.Name = "textBoxSetAlarmH";
            this.textBoxSetAlarmH.Size = new System.Drawing.Size(34, 22);
            this.textBoxSetAlarmH.TabIndex = 10;
            // 
            // textBoxSetAlarmL
            // 
            this.textBoxSetAlarmL.Location = new System.Drawing.Point(107, 186);
            this.textBoxSetAlarmL.Name = "textBoxSetAlarmL";
            this.textBoxSetAlarmL.Size = new System.Drawing.Size(34, 22);
            this.textBoxSetAlarmL.TabIndex = 9;
            // 
            // textBoxSetURV
            // 
            this.textBoxSetURV.Location = new System.Drawing.Point(107, 141);
            this.textBoxSetURV.Name = "textBoxSetURV";
            this.textBoxSetURV.Size = new System.Drawing.Size(34, 22);
            this.textBoxSetURV.TabIndex = 8;
            // 
            // textBoxSetLRV
            // 
            this.textBoxSetLRV.Location = new System.Drawing.Point(107, 96);
            this.textBoxSetLRV.Name = "textBoxSetLRV";
            this.textBoxSetLRV.Size = new System.Drawing.Size(34, 22);
            this.textBoxSetLRV.TabIndex = 7;
            // 
            // textBoxSetName
            // 
            this.textBoxSetName.Location = new System.Drawing.Point(107, 55);
            this.textBoxSetName.Name = "textBoxSetName";
            this.textBoxSetName.Size = new System.Drawing.Size(92, 22);
            this.textBoxSetName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Alarm high: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Alarm low:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "URV: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "LRV: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Name: ";
            // 
            // buttonSetConfig
            // 
            this.buttonSetConfig.Location = new System.Drawing.Point(107, 278);
            this.buttonSetConfig.Name = "buttonSetConfig";
            this.buttonSetConfig.Size = new System.Drawing.Size(114, 50);
            this.buttonSetConfig.TabIndex = 0;
            this.buttonSetConfig.Text = "Upload to Device";
            this.buttonSetConfig.UseVisualStyleBackColor = true;
            this.buttonSetConfig.Click += new System.EventHandler(this.buttonSetConfig_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "csv";
            // 
            // buttonSaveConfig
            // 
            this.buttonSaveConfig.BackgroundImage = global::Forms.Properties.Resources.images;
            this.buttonSaveConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSaveConfig.Location = new System.Drawing.Point(202, 10);
            this.buttonSaveConfig.Name = "buttonSaveConfig";
            this.buttonSaveConfig.Size = new System.Drawing.Size(26, 28);
            this.buttonSaveConfig.TabIndex = 11;
            this.buttonSaveConfig.UseVisualStyleBackColor = true;
            this.buttonSaveConfig.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Forms.Properties.Resources.images;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(166, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 28);
            this.button1.TabIndex = 12;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSaveConfig_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUpdate.BackgroundImage")));
            this.buttonUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonUpdate.Location = new System.Drawing.Point(199, 10);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(30, 28);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // ConfigForm
            // 
            this.ClientSize = new System.Drawing.Size(656, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCurrentConfig);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.txtFile);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigForm_FormClosing);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBoxCurrentConfig.ResumeLayout(false);
            this.groupBoxCurrentConfig.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.GroupBox groupBoxCurrentConfig;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonSaveConfig;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.TextBox textBoxSetAlarmH;
        public System.Windows.Forms.TextBox textBoxSetAlarmL;
        public System.Windows.Forms.TextBox textBoxSetURV;
        public System.Windows.Forms.TextBox textBoxSetLRV;
        public System.Windows.Forms.TextBox textBoxSetName;
        public System.Windows.Forms.TextBox textBoxCurrentAlarmH;
        public System.Windows.Forms.TextBox textBoxCurrentAlarmL;
        public System.Windows.Forms.TextBox textBoxCurrentURV;
        public System.Windows.Forms.TextBox textBoxCurrentLRV;
        public System.Windows.Forms.TextBox textBoxCurrentName;
        public System.Windows.Forms.Button buttonUpdate;
        public System.Windows.Forms.Button buttonSetConfig;
        public System.Windows.Forms.Button button1;
    }
}