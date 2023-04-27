using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DH_Parameters
{
    public partial class Form1 : Form
    {
        //Objects
        List<Mathematics.Matrix.HMT> HMTs = new List<Mathematics.Matrix.HMT>();
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNumJoins_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int numJoins = 0;
                if (int.TryParse(tbNumJoins.Text, out numJoins))
                {
                    dgvDH.Rows.Clear();
                    dgvDH.Rows.Add(numJoins + 2);
                    for (int i = 0; i <= numJoins; ++i)
                    {
                        dgvDH[0, i].Value = i.ToString();
                        dgvDH[1, i].Value = 0;
                        dgvDH[2, i].Value = 0;
                        dgvDH[3, i].Value = 0;
                        dgvDH[4, i].Value = 0;
                    }
                    dgvDH[0, numJoins + 1].Value = "G";
                    dgvDH[1, numJoins + 1].Value = 0;
                    dgvDH[2, numJoins + 1].Value = 0;
                    dgvDH[3, numJoins + 1].Value = 0;
                    dgvDH[4, numJoins + 1].Value = 0;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HMTs.Clear();
            listBox1.Items.Clear();
            foreach(DataGridViewRow row in dgvDH.Rows)
            {
                if (row.Index == 0)
                    continue;
                Mathematics.Matrix.HMT hmt = new Mathematics.Matrix.HMT();
                int i = row.Index;
                double a = double.Parse(dgvDH[1, i - 1].Value.ToString());
                double alpha = Math.PI * double.Parse(dgvDH[2, i - 1].Value.ToString()) / 180.0;
                double d = double.Parse(dgvDH[3, i].Value.ToString());
                double theta = Math.PI * double.Parse(dgvDH[4, i].Value.ToString()) / 180.0;
                hmt.DH(a, alpha, d, theta);
                HMTs.Add(hmt);
                listBox1.Items.Add($"{dgvDH[0, i - 1].Value} a {dgvDH[0, i].Value}");
            }
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            dgvSNAP.Rows.Clear();
            Mathematics.Matrix.HMT tmp = HMTs[listBox1.SelectedIndex];
            for (int i = 0; i < 4; ++i)
            {
                dgvSNAP.Rows.Add();
                for (int j = 0; j < 4; ++j)
                    dgvSNAP[j, i].Value = tmp.Matrix[i, j];
            }
        }
    }
}
