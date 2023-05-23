using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braccio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] values = new object[6];
            values[0] = int.Parse(tbM1.Text);
            values[1] = int.Parse(tbM2.Text);
            values[2] = int.Parse(tbM3.Text);
            int row = dgvTask.Rows.Add(values);
            dgvTask.Rows[row].HeaderCell.ToolTipText = $"Posición numero {row + 1}";
            dgvTask.Rows[row].HeaderCell.Value = (row+1).ToString();

            dgvTask.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

        }

        private void dgvTask_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            foreach(DataGridViewRow row in dgvTask.Rows)
            {
                row.HeaderCell.Value = (row.Index + 1).ToString();
            }
        }
    }
}
