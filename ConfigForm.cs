
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
using Microsoft.VisualBasic;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Media;
using System.Data.SqlClient;
using System.Configuration;

namespace Forms
{

    public partial class ConfigForm : Form
    {
        public static ConfigForm configformInstance;
        List<string> sqlConfigResult = new List<string>();
        string conSoftSensConf = ConfigurationManager.ConnectionStrings["conSoftSensConf"].ConnectionString;

        MainForm mf;
        public ConfigForm(MainForm tempform)
        {
            InitializeComponent();
            mf = tempform;
            configformInstance = this;

        }


            private void btnOpen_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFile.Text = openFileDialog1.FileName;
                LoadData(txtFile.Text);
            }
            else
            {
                MessageBox.Show(this, "du valgte ingen fil");
            }
            
           
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
            if (mf.serialPort1.IsOpen)
            {
                while (true)
                {
                    string input = Interaction.InputBox("Please enter password:", "Upload Configuration", "", 600, 400);
                    string uploadstring = ("writeconf>" + input + ">" + textBoxSetName.Text + ";" + textBoxSetLRV.Text + ";" + textBoxSetURV.Text + ";" + textBoxSetAlarmL.Text + ";" + textBoxSetAlarmH.Text);
                    
                    SqlConnection con = new SqlConnection(conSoftSensConf);
                    SQLHelperClass.SetConfigInDB(comboBoxInstruments.SelectedItem.ToString(), textBoxSetName.Text, int.Parse(textBoxSetLRV.Text), int.Parse(textBoxSetURV.Text), int.Parse(textBoxSetAlarmL.Text), int.Parse(textBoxSetAlarmH.Text), con);
                    mf.serialPort1.WriteLine(uploadstring);
                    mf.textBoxCommunication.AppendText("Sent: " + uploadstring + "\r\n");
                    break;
                }
            }
            else
            {
                MessageBox.Show("You are not connected to a device.");
            }            
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
                throw new Exception("error saving file, please try again", ex);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conSoftSensConf);
            sqlConfigResult = SQLHelperClass.GetConfigFromDB(con, mf.instr.tagname);
            this.textBoxCurrentName.Text = sqlConfigResult[0];
            this.textBoxCurrentLRV.Text = sqlConfigResult[1];
            this.textBoxCurrentURV.Text = sqlConfigResult[2];
            this.textBoxCurrentAlarmL.Text = sqlConfigResult[3];
            this.textBoxCurrentAlarmH.Text = sqlConfigResult[4];
        }

        private void ConfigForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mf.configformactive = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> sqlResult = new List<string>();
            SqlConnection con = new SqlConnection(conSoftSensConf);

            sqlResult = SQLHelperClass.GetConfigFromDB(con, comboBoxInstruments.SelectedItem.ToString());
            textBoxSetName.Text = sqlResult[0];
            textBoxSetLRV.Text = sqlResult[1];
            textBoxSetURV.Text = sqlResult[2];
            textBoxSetAlarmL.Text = sqlResult[3];
            textBoxSetAlarmH.Text = sqlResult [4];
        }

        private void comboBoxInstruments_Click(object sender, EventArgs e)
        {
            comboBoxInstruments.Items.Clear();
            List<string> sqlResult = new List<string>();
            SqlConnection conn = new SqlConnection(conSoftSensConf);

            sqlResult = SQLHelperClass.GetInstrumentNamesFromDB(conn);
            foreach (string TagName in sqlResult)
            {
                comboBoxInstruments.Items.Add(TagName);
            }
        }
    }
}