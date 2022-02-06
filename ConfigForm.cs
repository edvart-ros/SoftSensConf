
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;

namespace Forms
{

    public partial class ConfigForm : Form
    {
        public static ConfigForm configformInstance;

        MainForm mf;
        public ConfigForm(MainForm tempform)
        {
            InitializeComponent();
            mf = tempform;
            configformInstance = this;

        }


            private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFile.Text = openFileDialog1.FileName;
            LoadData(txtFile.Text);
        }

        private void LoadData(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            string data = lines[0];

            if (lines.Length > 0)
            {
                string[] dataValues = data.Split(',');
                textBoxSetName.Text = dataValues[0];
                textBoxSetLRV.Text = dataValues[1];
                textBoxSetURV.Text = dataValues[2];
                textBoxSetAlarmH.Text = dataValues[3];
                textBoxSetAlarmL.Text = dataValues[4];
            }

        }


        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonSetConfig_Click(object sender, EventArgs e)
        {
            string uploadstring = ("writeconf>password>" + textBoxSetName.Text + ";" + textBoxSetLRV.Text +";" + textBoxSetURV.Text +";" + textBoxSetAlarmL.Text +";" + textBoxSetAlarmH.Text);
            mf.serialPort1.WriteLine(uploadstring);
            mf.textBoxCommunication.AppendText("Sent: " + uploadstring + "\r\n");
        }

        private void buttonSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using (Stream s = File.Open(saveFileDialog1.FileName, FileMode.Create))
                    using (StreamWriter sw = new StreamWriter(s))
                    {
                        string data = textBoxSetName.Text + "," + textBoxSetLRV.Text + "," + textBoxSetURV.Text + "," + textBoxSetAlarmL.Text + "," + textBoxSetAlarmH.Text;
                        sw.Write(data);
                    }
                }

            }


            catch (Exception ex)
            {
                throw new Exception("u fucked something up", ex);
            }
            {

            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            mf.serialPort1.WriteLine("readconf");
        }


    }
}