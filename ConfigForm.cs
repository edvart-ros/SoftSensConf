
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }
            private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFile.Text = openFileDialog1.FileName;
            BindData(txtFile.Text);
        }

        private void BindData(string filePath)
        {
            string[] lines = System.IO.File.ReadAllLines(filePath);
            DataTable dt = new DataTable();
            DataRow dataRow = dt.NewRow();

            string data = lines[0];
            if (lines.Length > 0)
            {
                string[] dataValues = data.Split(',');

                dt.Columns.Add(new DataColumn("command"));
                dt.Columns.Add(new DataColumn("password"));
                dt.Columns.Add(new DataColumn("name"));
                dt.Columns.Add(new DataColumn("lrv"));
                dt.Columns.Add(new DataColumn("urv"));
                dt.Columns.Add(new DataColumn("alarmh"));

                dt.Rows.Add(dataRow);
                dataRow[0] = dataValues[0];
                dataRow[1] = dataValues[1];
                dataRow[2] = dataValues[2];
                dataRow[3] = dataValues[3];
                


            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }

        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }
    }
}