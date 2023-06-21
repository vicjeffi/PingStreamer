using PingStreamer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingStreamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            results_dataGridView.DataSource = (new ScanResults()).GetTestInstance();
        }
        private void results_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = sender as DataGridView;

            if (dgv.Columns[e.ColumnIndex].Name.Equals("Success"))
            {
                if (e.Value != null && (bool)e.Value == true)
                {
                    var cell = dgv.Rows[e.RowIndex].Cells["Success"];
                    cell.Style.BackColor = Color.Green;
                    //cell.ValueType = typeof(string);
                    //cell.Value = "";
                }
                else
                {
                    //dgv.Rows[e.RowIndex].Cells["Success"].Style.BackColor = Color.Red;
                    var cell = dgv.Rows[e.RowIndex].Cells["Success"];
                    cell.Style.BackColor = Color.Red;
                    //cell.ValueType = typeof(string);
                    //cell.Value = "";
                }
            }

        }
    }
}
