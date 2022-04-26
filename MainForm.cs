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
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.Media;
using System.Data.SqlClient;
using System.Configuration;


namespace Forms
{
    public partial class MainForm : Form
    {
        string conSoftSensConf = ConfigurationManager.ConnectionStrings["conSoftSensConf"].ConnectionString;

        bool autoMode = false;
        public bool configformactive = false;

        int statusInt;
        string notificationText = "ALARM: DEVICE FAILURE!";

        int new_failure = 0;

        DateTime statusTimeStamp = DateTime.Now;

        List<string> datacollection = new List<string>();
        List<string> sqlConfigResult = new List<string>();
        List<int> analogReadingRaw = new List<int>();
        List<double> analogReadingScaled = new List<double>();
        List<DateTime> timeStamp = new List<DateTime>();
        List<string> statusStrings = new List<string>();
        List<Color> statusColors = new List<Color>();
        public Instrument instr = new Instrument();
        



        public MainForm()
        {
            InitializeComponent();
            instr.tagname = "LI0";
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            timer1.Interval = 2500;
            timer1.Tick += new EventHandler(timer1_Tick);

            Thread.Sleep(2500);
            timer2.Interval = 2500;
            timer2.Tick += new EventHandler(timer2_tick);
            timer2.Start();
            chartSeries.Series[0].XValueType = ChartValueType.DateTime;
            chartSeries.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            { 
              if (autoMode)
              {
              serialPort1.WriteLine("read");}
              }
            
            catch(Exception)
            {
              autoMode = false;
              MessageBox.Show("disconnected, stopping reading");
              EnterManualMode();
              textBoxCommunication.AppendText("disconnected" + "\r\n");
              toolStrip1.BackColor = Color.Gainsboro;
            } 
        }

        private void timer2_tick(object sender, EventArgs e)
        {
            List<string> Task = new List<string>();
            SqlConnection con = new SqlConnection(conSoftSensConf);
            Task = SQLHelperClass.GetTaskFromDB(instr.tagname, con);
            if (Task.Count == 0)
            {
            }
            else
            {
                serialPort1.WriteLine("output;" + Task[1]);
                textBoxCommunication.AppendText("Task Output:" + Task[1] + "   at: " + DateTime.Now.ToString() + "\r\n");
                SQLHelperClass.CompleteTask(Task[0], DateTime.Now, con);
            }

        }

        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {

            int iVab;
            string RecievedData = ((SerialPort)sender).ReadLine();
            textBoxCommunication.Invoke((MethodInvoker)delegate{ textBoxCommunication.AppendText(RecievedData + "\r\n"); });
            string[] separateParts= RecievedData.Split(';');
            string datatype = separateParts[0];

            
            if (datatype == "readstatus")
            {
                Int32.TryParse(separateParts[1], out statusInt);
                this.StatusCallback(statusInt);

            }


            if (datatype == "writeconf")
            {
                if (separateParts[1] == "0\r")
                {
                    MessageBox.Show("Wrong Password, unsuccessful");
                }
                if (separateParts[1] == "1\r")
                {
                    MessageBox.Show("Upload successful");
                    serialPort1.WriteLine("readconf");
                    
                } 
            }

            if (datatype == "readconf")
            {
                instr.tagname = separateParts[1];

                instr.lrv = double.Parse(separateParts[2]);
                instr.urv = double.Parse(separateParts[3]);
                try
                {
                    ConfigForm.configformInstance.textBoxCurrentName.Text = separateParts[1]; 
                    ConfigForm.configformInstance.textBoxCurrentLRV.Text = separateParts[2];
                    ConfigForm.configformInstance.textBoxCurrentURV.Text = separateParts[3];
                    ConfigForm.configformInstance.textBoxCurrentAlarmL.Text = separateParts[4];
                    ConfigForm.configformInstance.textBoxCurrentAlarmH.Text = separateParts[5];
                }
                catch
                {

                }
            }



            if (autoMode)   //if we are in auto-mode, we want to plot the readings
            {
                DateTime dt = DateTime.Now;
                String timeStampstring = GetTimestamp(DateTime.Now);

                if (datatype == "read")
                {
                    Int32.TryParse(separateParts[1], out statusInt);
                    this.StatusCallback(statusInt);
                    StatusLabel1.Text = statusStrings[statusInt]; StatusLabel2.Text = statusStrings[statusInt];
                    statusStrip1.BackColor = statusColors[statusInt]; StatusStrip2.BackColor = statusColors[statusInt];

                    if (statusInt == 1 && new_failure == 0)
                    {
                        notifyIcon1.Text = notificationText;
                        notifyIcon1.BalloonTipText = "There is something wrong with your serial device (FAIL).";
                        notifyIcon1.BalloonTipTitle = "WARNING";
                        notifyIcon1.Icon = SystemIcons.Error;
                        notifyIcon1.ShowBalloonTip(10000);
                        new_failure = 1;
                        if (autoMode)
                        {
                            EnterManualMode();
                        }
                    }
                    else
                    {
                        new_failure = 0;
                    }


                    ////////////////////////////// plotting and recording raw and scaled

                    ClearLiveReadings();
                    textBoxRawLive.Text = separateParts[2];

                    int iVab_raw = int.Parse(separateParts[2]);
                    double iVab_scaled = double.Parse(separateParts[3]);

                    datacollection.Add(timeStampstring + ", " + iVab_raw + ", " + iVab_scaled); analogReadingRaw.Add(iVab_raw);
                    analogReadingScaled.Add(iVab_scaled); timeStamp.Add(dt);

                    textBoxAverage.Text = Math.Round(analogReadingScaled.Average(), 2).ToString();
                    textBoxScaledLive.Text = separateParts[3];


                    if (radioButtonScaled.Checked)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            chartSeries.Series["Vba"].Points.DataBindXY(timeStamp, analogReadingScaled);
                            chartSeries.Invalidate();
                        }));
                    }
                    else if (radioButtonRaw.Checked)
                    {
                        BeginInvoke(new Action(() =>
                        {
                            chartSeries.Series["Vba"].Points.DataBindXY(timeStamp, analogReadingRaw);
                            chartSeries.Invalidate();
                        }));
                    }
                    try
                    {
                        SqlConnection con = new SqlConnection(conSoftSensConf);
                        SQLHelperClass.UploadDataPoint(instr.tagname, iVab_raw, iVab_scaled, statusInt, con);
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }

            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonRaw.Checked = true;
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

            statusStrings.Add("OK"); statusStrings.Add("FAIL"); statusStrings.Add("Alarm: LOW"); statusStrings.Add("Alarm: HIGH");
            statusColors.Add(Color.LightGreen); statusColors.Add(Color.Red); statusColors.Add(Color.Yellow); statusColors.Add(Color.Yellow);
            
            foreach (int i in BitRateList)
            {
                comboBoxBitRate.Items.Add(i);
            }
            toolStripLabel1.Text = "not connected";
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
                toolStrip1.BackColor = Color.Gainsboro;
                toolStripLabel1.Text = "not connected";
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    textBoxCommunication.AppendText("Already connected" + "\r\n");
                }
                else
                {
                    serialPort1.PortName = comboBoxCOM.Text;
                    serialPort1.BaudRate = Int32.Parse(comboBoxBitRate.Text);
                    serialPort1.Open();
                    toolStripLabel1.Text = "connected";
                    toolStrip1.BackColor = Color.ForestGreen;
                    textBoxCommunication.AppendText("connected" + "\r\n");
                    MessageBox.Show("Connected to device");
                    serialPort1.WriteLine("readconf");
                }
            }

            catch (ArgumentException)
            { MessageBox.Show("Please enter a valid port name."); } 
            
            catch (System.IO.IOException)
            {MessageBox.Show("Unable to establish a connection.");}
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            toolStripLabel1.Text = "not connected";
            textBoxCommunication.AppendText("disconnected" + "\r\n");
            toolStrip1.BackColor = Color.Gainsboro;
            StatusLabel1.Text = "Waiting for status..."; StatusLabel2.Text = "Waiting for status...";
            statusStrip1.BackColor = Color.Gainsboro; StatusStrip2.BackColor = Color.Gainsboro;
        }

        private void buttonManual_Click(object sender, EventArgs e)
        {
            if (autoMode)
            {
                EnterManualMode();
            }

        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            EnterAutoMode();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {

            EnterAutoMode();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EnterManualMode();
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




        //////////////////////
        // helper functions //
        //////////////////////

        public void StatusCallback(int statusInt)
        {
            
            StatusLabel1.Text = statusStrings[statusInt]; StatusLabel2.Text = statusStrings[statusInt];
            statusStrip1.BackColor = statusColors[statusInt]; StatusStrip2.BackColor = statusColors[statusInt];

            if (statusInt == 1 && new_failure == 0)
            {

                notifyIcon1.Text = notificationText;
                notifyIcon1.BalloonTipText = "There is something wrong with your serial device (FAIL).";
                notifyIcon1.BalloonTipTitle = "WARNING";
                notifyIcon1.Icon = SystemIcons.Error;
                notifyIcon1.ShowBalloonTip(10000);
                new_failure = 1;
                if (autoMode)
                {
                    EnterManualMode();
                }
            }
            else
            {
                new_failure = 0;
            }

            statusTimeStamp = DateTime.Now;
            textBoxStatus.AppendText(statusTimeStamp.ToString("dd/MM/yyyy HH:mm:ss") + "  " + statusStrings[statusInt] + "\r\n");
        }
        /*
        public void GetConfigFromDB()
        {
            int i = 0;
            
            using (SqlConnection conn = new SqlConnection(conSoftSensConf))
            {
                SqlCommand cmd = new SqlCommand("SELECT [TagName], [LRV], [URV], [AlarmL], [AlarmH] FROM [dbo].[Instrument] WHERE [TagName] = '" + instr.tagname + "'", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                sqlConfigResult.Clear();
                while (reader.Read())
                {
                    foreach (int n in Enumerable.Range(0, 5))
                    { sqlConfigResult.Add(reader[n].ToString()); }
                }
                foreach (string s in sqlConfigResult)
                {
                    textBoxCommunication.AppendText(s + ", ");
                }
                try
                {
                    MessageBox.Show("successfully read device configuration");
                    ConfigForm.configformInstance.textBoxCurrentName.Text = sqlConfigResult[0];
                    ConfigForm.configformInstance.textBoxCurrentLRV.Text = sqlConfigResult[1];
                    ConfigForm.configformInstance.textBoxCurrentURV.Text = sqlConfigResult[2];
                    ConfigForm.configformInstance.textBoxCurrentAlarmL.Text = sqlConfigResult[3];
                    ConfigForm.configformInstance.textBoxCurrentAlarmH.Text = sqlConfigResult[4];
                }
                catch
                {

                }
            }
        }*/


        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void clearData()
        {
            analogReadingRaw.Clear();
            analogReadingScaled.Clear();
            timeStamp.Clear();
            datacollection.Clear();
            textBoxAverage.Clear();
            textBoxRawLive.Clear();
            textBoxScaledLive.Clear();
        }


        public void saveStringList(List<string> data)
        {
            SaveFileDialog saveFileDialogData = new SaveFileDialog();
            if (saveFileDialogData.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialogData.FileName, FileMode.Create))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(string.Join("", datacollection));
                }
            }
        }
        private void ClearLiveReadings()
        {
            textBoxRawLive.Text = "";
            textBoxScaledLive.Text = "";
        }


        public void EnterManualMode()
        {
            timer1.Stop();
            autoMode = false;
            textBoxSend.ReadOnly = false;
            buttonConfigWindow.Enabled = true;
            buttonSend.Enabled = true;
            buttonSend.Enabled = true;
            buttonConnect.Enabled = true;
            radioButtonRaw.Enabled = true;
            radioButtonScaled.Enabled = true;
            buttonDisconnect.Enabled = true;
            buttonManual.Enabled = false;
            buttonManual2.Enabled = false;
            buttonAuto.Enabled = true;
            buttonAuto2.Enabled = true;
            buttonStatus.Enabled = true;
            textBoxAverage.Clear();
            textBoxRawLive.Clear();
            textBoxScaledLive.Clear();

            if (configformactive)
            {
                ConfigForm.configformInstance.buttonSetConfig.Enabled = true;
                ConfigForm.configformInstance.buttonUpdate.Enabled = true;
            }
            DialogResult dialogResult = MessageBox.Show("Do you wish to save this sensor data collection?", "", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                saveStringList(datacollection);
            }
            else if (dialogResult == DialogResult.No)
            {}
        }

        public void EnterAutoMode()
        {
        if (serialPort1.IsOpen) 
            {
                textBoxSend.Text = "";
                textBoxSend.ReadOnly = true;
                if (textBoxFreq.Text == "")
                {
                    timer1.Interval = 2500;
                    timer1.Start();

                }
                else
                {
                    int interval = int.Parse(textBoxFreq.Text);
                    if (interval >= 2000)
                    { 
                        timer1.Interval = interval;
                        timer1.Start();
                    }
                    else
                    {
                        MessageBox.Show("Please select a frequency greater than 2000ms");
                    }
                }

                autoMode=true;
                buttonConfigWindow.Enabled = false;
                buttonSend.Enabled = false;
                buttonConnect.Enabled = false;
                radioButtonRaw.Enabled = false;
                radioButtonScaled.Enabled = false;
                buttonDisconnect.Enabled = false;
                buttonAuto.Enabled = false;
                buttonAuto2.Enabled = false;
                buttonManual.Enabled = true;
                buttonManual2.Enabled = true;
                buttonStatus.Enabled = false;

                clearData();
                

                //buttonDisconnect.Enabled = false;

                if (configformactive)
                {
                    ConfigForm.configformInstance.buttonSetConfig.Enabled = false;
                    ConfigForm.configformInstance.buttonUpdate.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show("Please connect to a valid COM port");
                toolStripLabel1.Text = "not connected";
                toolStrip1.BackColor = Color.Gainsboro;
                
            }
        }


        //////////////////////
        //////////////////////
        private void radioButtonRaw_Click(object sender, EventArgs e)
        {
            //this.rawMode = true;
        }
        private void radioButtonScaled_Click(object sender, EventArgs e)
        {
           //this.rawMode = false;
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.WriteLine("readstatus");
            }
        }

        private void buttonClearStatus_Click(object sender, EventArgs e)
        {
            textBoxStatus.Clear();
        }

        private void buttonClearFeed_Click(object sender, EventArgs e)
        {
            textBoxCommunication.Clear();
        }

        private void labelAverage_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCOM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGetTask_Click(object sender, EventArgs e)
        {
            List<string> Task = new List<string>();
            SqlConnection con = new SqlConnection(conSoftSensConf);
            Task = SQLHelperClass.GetTaskFromDB(instr.tagname, con);
            if (Task.Count == 0)
            {
                MessageBox.Show("could not find any tasks to complete");
            }
            else
            {
                textBoxDataID.Text = Task[0];
                textBoxOutputValue.Text = Task[1];
            }
            }
    }
}
