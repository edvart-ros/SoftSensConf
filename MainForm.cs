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
        List<int> analogReading = new List<int>();
        List<DateTime> timeStamp = new List<DateTime>();



        public MainForm()
        {
            InitializeComponent();
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);

                this.chartSeries.ChartAreas[0].AxisX.LabelStyle.Format = "hh:mm.ss";
                chartSeries.Series[0].XValueType = ChartValueType.DateTime;

                timer1.Interval = 2000;
                timer1.Tick += new EventHandler(timer1_Tick);
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readraw");

        }



        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            int iVab;
            string RecievedData = ((SerialPort)sender).ReadLine();

            textBoxCommunication.Invoke((MethodInvoker) delegate { textBoxCommunication.AppendText("Recieved: " + RecievedData + "\r\n");});
            string[] separateParts= RecievedData.Split(';');

            if (autoMode)
            {
                if (int.TryParse(separateParts[0], out iVab))
                {
                    analogReading.Add(iVab);
                    DateTime now = DateTime.Now;

                    timeStamp.Add(now);

                    chartSeries.Series["Vba"].Points.DataBindXY(timeStamp, analogReading);

                    //chartSeries.Series[0].Points.AddXY(now, analogReading);
                    
                    chartSeries.Invalidate();
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

                // Alphabetic order

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


                //Alphabetic order

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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void tabLists_Click(object sender, EventArgs e)
        {
            /*foreach (string str in listBoxResult.Items)
            {
                comboBox1.Items.Add(str);
            }
        */
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
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                textBoxSend.Text = "";
                textBoxSend.ReadOnly = true;
                timer1.Start();
                autoMode=true;
            }
            else
            {
                MessageBox.Show("Porten er ikke åpen!");
            }
        }

        private void buttonConfigWindow_Click(object sender, EventArgs e)
        {
            ConfigForm ConfigForm = new ConfigForm();
            ConfigForm.Show();
        }
    }
}
