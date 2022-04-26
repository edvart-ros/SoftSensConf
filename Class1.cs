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
    public class Instrument
    {
        public string tagname { get; set; }
        public double lrv { get; set; }
        public double urv { get; set; }
        public double alarmL { get; set; }
        public double alarmH { get; set; }

        public Instrument()
        {
        }

        public void UploadDataPoint(int iVab_raw, double iVab_scaled, int statusInt, SqlConnection con)
        {

            string sqlQuery = String.Concat(@"INSERT INTO DataLog (TagName, RawSensorValue, ScaledSensorValue, StatusCode, TimeStamp, WrittenAt)
                        VALUES('" + this.tagname + "', '" + iVab_raw + "', '" + iVab_scaled + "','" + statusInt + "', '" + DateTime.Now + "', '" + DateTime.Now + "');");

            con.Open();
            SqlCommand command = new SqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
            con.Close();
        }

    }

    
}
