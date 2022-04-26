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
        public class SQLHelperClass
        {

        public static void UploadDataPoint(string tagName, int iVab_raw, double iVab_scaled, int statusInt, SqlConnection con)
        {

            string sqlQuery = String.Concat(@"INSERT INTO DataLog (TagName, RawSensorValue, ScaledSensorValue, StatusCode, TimeStamp, WrittenAt)
                        VALUES('" + tagName + "', '" + iVab_raw + "', '" + iVab_scaled + "','" + statusInt + "', '" + DateTime.Now + "', '" + DateTime.Now + "');");

            con.Open();
            SqlCommand command = new SqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
            con.Close();
        }


        public static void SetConfigInDB(string tagNameSelect, string tagName, int LRV, int URV, int AlarmL, int AlarmH, SqlConnection con)
        {
            string sqlQuery = "UPDATE [Instrument] SET [TagName] = '" + tagName + "',[LRV] = '" + LRV + "' ,[URV] = '" + URV + "' ,[AlarmL] = '" + AlarmL + "' ,[AlarmH] ='" + AlarmH + "' WHERE [TagName]='" + tagNameSelect + "'";

            con.Open();
            SqlCommand command = new SqlCommand(sqlQuery, con);
            command.ExecuteNonQuery();
            con.Close();
        }


        public static List<string> GetConfigFromDB(SqlConnection conn, string tagName)
        {
            int i = 0;
            List<string> sqlResult = new List<string>();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("SELECT [TagName], [LRV], [URV], [AlarmL], [AlarmH] FROM [dbo].[Instrument] WHERE [TagName] = '" + tagName + "'", conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    foreach (int n in Enumerable.Range(0, 5))
                    { sqlResult.Add(reader[n].ToString()); }
                }
            }
            conn.Close();
            return sqlResult;
        }

        public static List<string> GetInstrumentNamesFromDB(SqlConnection conn)
        {
            List<string> sqlResult = new List<string>();
            using (conn)
            {
                SqlCommand cmd = new SqlCommand("Select [Tagname] FROM [dbo].[Instrument]", conn);
                conn.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    sqlResult.Add(r["TagName"].ToString());
                }
                return sqlResult;
            }
        }
        public static List<string> GetTaskFromDB(string tagName, SqlConnection conn)
        {
            List<string> sqlResult = new List<string>();
            SqlCommand cmd = new SqlCommand("Select [DataLog_ID], [RawSensorValue] FROM [dbo].[DataLog] WHERE [TagName] = '" + tagName + "' AND [WrittenAt] IS NULL", conn);
            
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                foreach (int n in Enumerable.Range(0, 2))
                { sqlResult.Add(reader[n].ToString()); }
            }
            conn.Close();
            return sqlResult;
        }

        public static void CompleteTask(string DataLogID, DateTime WrittenAt, SqlConnection conn)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE [DataLog] SET [WrittenAt] = '" + WrittenAt + "' WHERE [DataLog_ID]='" + DataLogID + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            

        }
    }
}
