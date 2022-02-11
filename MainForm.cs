using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Windows.Forms.DataVisualization.Charting;

namespace Forms
{
    public partial class MainForm : Form
    {


        bool autoMode = false;
        public bool configformactive = false;

        List<int> analogReading = new List<int>();
        List<DateTime> timeStamp = new List<DateTime>();
        Instrument instr = new Instrument();


        public MainForm()
        {
            InitializeComponent();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
                timer1.Interval = 2000;
                timer1.Tick += new EventHandler(timer1_Tick);
            chartSeries.Series[0].XValueType = ChartValueType.DateTime;
            chartSeries.ChartAreas[0].AxisX.LabelStyle.Format = "HH-mm-ss";

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readraw");
        }

        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int iVab;
            string RecievedData = ((SerialPort)sender).ReadLine();
            textBoxCommunication.Invoke((MethodInvoker)delegate{ textBoxCommunication.AppendText("Recieved: " + RecievedData + "\r\n"); });
            string[] separateParts= RecievedData.Split(';');

            if (separateParts.Length == 5)
            {
                try
                {
                    ConfigForm.configformInstance.textBoxCurrentName.Text = separateParts[0]; 
                    ConfigForm.configformInstance.textBoxCurrentLRV.Text = separateParts[1];
                    ConfigForm.configformInstance.textBoxCurrentURV.Text = separateParts[2];
                    ConfigForm.configformInstance.textBoxCurrentAlarmL.Text = separateParts[3];
                    ConfigForm.configformInstance.textBoxCurrentAlarmH.Text = separateParts[4];

                    instr.tagname = separateParts[0];
                    instr.lrv = double.Parse(separateParts[1]);
                    instr.urv = double.Parse(separateParts[2]);


                }
                catch
                {

                }
            }


            if (autoMode)
            {
                if (int.TryParse(separateParts[0], out iVab))
                {
                    DateTime dt = DateTime.Now;
                    
                    analogReading.Add(iVab);
                    //OOP implementasjon

                    instr.measurement = iVab;
                    
                    
                    
                    //

                    timeStamp.Add(dt);
                    BeginInvoke(new Action(() =>
                    {
                        chartSeries.Series["Vba"].Points.DataBindXY(timeStamp, analogReading);
                        chartSeries.Invalidate();
                    }));
                    
                }
                else
                {
                    MessageBox.Show("Gikk Ikke.");
                }

            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            string string1 = textBox1.Text;
            string string2 = textBox2.Text;
            int stringCompareResult;

            if (checkBoxCase.Checked)
            {
                if (string1 == string2)
                {
                    textBoxResult.Text = "equal, case sensitive \r\n";
                }
                else
                {
                    textBoxResult.Text = "not equal, case sensitive \r\n";
                }
                stringCompareResult = string.Compare(string1, string2, false);
                if (stringCompareResult == -1)
                {
                    textBoxResult.AppendText("not ordered, case sensitive \r\n");
                }
                else if (stringCompareResult == 0)
                {
                    textBoxResult.AppendText("ordered, case sensitive \r\n");
                }
                else if (stringCompareResult == 1)
                {
                    textBoxResult.AppendText("ordered, case sensitive \r\n");
                }
            }



            else
            {
                if (string1.Equals(string2, StringComparison.CurrentCultureIgnoreCase))
                {
                    textBoxResult.Text = "equal, not case sensitive \r\n";
                }
                else
                {
                    textBoxResult.Text = "not equal, not case sensitive \r\n";
                }

                stringCompareResult = string.Compare(string1, string2, true);
                if (stringCompareResult == 1)
                {
                    textBoxResult.AppendText("not ordered, not case sensitive \r\n");
                }
                else
                {
                    textBoxResult.AppendText("ordered, not case sensitive \r\n");
                }
            }
        }

        private void buttonContains_Click(object sender, EventArgs e)
        {
            string string1 = textLoopsString1.Text;
            string string2 = textBoxString2.Text;
            int index_substring;

            index_substring = string1.IndexOf(string2);

            if (index_substring == -1)
            {
                textLoopsResult.Text = "string 1 does not contain string 2";
            }
            else
            {
                textLoopsResult.Text = "string 1 contains string 2";
            }

        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            string string1 = textLoopsString1.Text;
            string string2 = textBoxString2.Text;

            string[] separate = string1.Split(';');
            textLoopsResult.Text = "";

            foreach (string s in separate)
            {
                textLoopsResult.AppendText(s + "\r\n"); 
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> BitRateList = new List<int>();
            BitRateList.Add(110);
            BitRateList.Add(300);
            BitRateList.Add(1200);
            BitRateList.Add(2400);
            BitRateList.Add(4800);
            BitRateList.Add(9600);
            BitRateList.Add(19200);
            BitRateList.Add(38400);
            BitRateList.Add(57600);
            BitRateList.Add(115200);
            
            foreach (int i in BitRateList)
            {
                comboBoxBitRate.Items.Add(i);
            }

            listBoxResult.Items.Clear();
            toolStripLabel1.Text = "not connected";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Add(textBoxAdd.Text);
            comboBox1.Items.Add(textBoxAdd.Text);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.RemoveAt(comboBox1.SelectedIndex);
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
        }

        private void comboBox2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxCOM.Items.Clear();
            comboBoxCOM.Items.AddRange(SerialPort.GetPortNames());
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine(textBoxSend.Text);
                textBoxCommunication.AppendText("Sent: " + textBoxSend.Text + "\r\n");
            }
            else
            {
                textBoxCommunication.AppendText("no command sent, Port not connected" + "\r\n");
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                textBoxCommunication.AppendText("Already connected" + "\r\n" );
            }
            else
            {
                serialPort1.PortName = comboBoxCOM.Text;
                serialPort1.Open();
                toolStripLabel1.Text = "connected";
                textBoxCommunication.AppendText("connected" + "\r\n");
                
            }
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripLabel1.Text = "not connected";
            textBoxCommunication.AppendText("disconnected" + "\r\n");
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            autoMode = false;
            textBoxSend.ReadOnly = false;
            buttonConfigWindow.Enabled = true;
            buttonSend.Enabled = true;
            buttonConnect.Enabled = true;
            buttonDisconnect.Enabled = true;

            if (configformactive)
            {
                ConfigForm.configformInstance.buttonSetConfig.Enabled = true;
                ConfigForm.configformInstance.buttonUpdate.Enabled = true;
            }

            
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                textBoxSend.Text = "";
                textBoxSend.ReadOnly = true;
                timer1.Start();
                autoMode=true;
                buttonConfigWindow.Enabled = false;
                buttonSend.Enabled = false;
                buttonConnect.Enabled = false;
                buttonDisconnect.Enabled = false;

                if (configformactive)
                {
                    ConfigForm.configformInstance.buttonSetConfig.Enabled = false;
                    ConfigForm.configformInstance.buttonUpdate.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Porten er ikke åpen!");
            }
        }
        private void buttonConfigWindow_Click(object sender, EventArgs e)
        {
            ConfigForm ConfigForm = new ConfigForm(this);
            configformactive = true;
            ConfigForm.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutCommandForm aboutform = new AboutCommandForm();

            aboutform.Show();
        }

        private void tabPageClass_Click(object sender, EventArgs e)
        {

        }

        private void buttonGetScaled_Click(object sender, EventArgs e)
        {
            double scaled_reading = instr.Scaled();
            textBoxDoubleScaled.Text = scaled_reading.ToString();

        }

        private void buttonUpdateObjectProperties_Click(object sender, EventArgs e)
        {
            textBoxClassConfig.Text = instr.tagname + "\r\n";
            textBoxClassConfig.AppendText(instr.lrv.ToString() + "\r\n");
            textBoxClassConfig.AppendText(instr.urv.ToString() + "\r\n");

        }
    }
}
