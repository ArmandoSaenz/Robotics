using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Braccio
{
    public partial class Form1 : Form
    {
        public double L2 = 13;
        public double L3 = 18;
        public double Theta1
        {
            get
            {
                return double.Parse(tbM1.Text);
            }
            set
            {
                tbM1.Text = value.ToString("F6");
            }
        }
        public double Theta2
        {
            get
            {
                return double.Parse(tbM2.Text);
            }
            set
            {
                tbM2.Text = value.ToString("F6");
            }
        }
        public Models.Posture[] Postures { get; set; }
        public double Theta3
        {
            get
            {
                return double.Parse(tbM3.Text);
            }
            set
            {
                tbM3.Text = value.ToString("F6");
            }
        }
        public double X
        {
            get
            {
                return double.Parse(tbX.Text);
            }
            set
            {
                tbX.Text = value.ToString("F6");
            }
        }
        public double Y
        {
            get
            {
                return double.Parse(tbY.Text);
            }
            set
            {
                tbY.Text = value.ToString("F6");
            }
        }
        public double Z
        {
            get
            {
                return double.Parse(tbZ.Text);
            }
            set
            {
                tbZ.Text = value.ToString("F6");
            }
        }
        public Form1()
        {
            InitializeComponent();
            /*string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            foreach(string port in ports)
            {
                cbSerialPorts.Items.Add(port);
            }*/
            btnUpdate.PerformClick();
        }
        private void UpdatePorts()
        {
            Dictionary<string, String> ports = ClassPorts.GetSerialPorts();
            cbSerialPorts.DataSource = new BindingSource(ports, null);
            cbSerialPorts.ValueMember = "Key";
            cbSerialPorts.DisplayMember = "Value";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            object[] values = new object[6];
            values[0] = int.Parse(tbM1.Text.Split('.')[0]);
            values[1] = int.Parse(tbM2.Text.Split('.')[0]);
            values[2] = int.Parse(tbM3.Text.Split('.')[0]);
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

        private void button1_Click(object sender, EventArgs e)
        {
            double theta1=0, theta2=0, theta3=0;
            double D = Math.Sqrt(X * X + Y * Y);
            double C = Math.Sqrt(D * D + Z * Z);
            if (2 * L2 * L3 >= Math.Abs(D * D + Z * Z - L2 * L2 - L3 * L3))
            {
                theta1 = Math.Atan2(Y, X);
                theta3 = Math.Acos((D * D + Z * Z - L2 * L2 - L3 * L3) / (2 * L2 * L3));
                theta2 = Math.Atan2(Z, D) - Math.Atan2(L3 * Math.Sin(theta3), L2 + L3 * Math.Cos(theta3));
                if (theta1 >= 0 && theta1 <= 180 && theta2 >= 0 && theta2 <= 180 && theta3 >= 0 && theta3 <= 180)
                {
                    Theta1 = Mathematics.Convertions.R2D(theta1);
                    Theta2 = Mathematics.Convertions.R2D(theta2);
                    Theta3 = Mathematics.Convertions.R2D(theta3);
                    return;
                }
            }
            Theta1 = 0;
            Theta2 = 0;
            Theta3 = 0;
            MessageBox.Show($"El punto [{X},{Y},{Z}] no es accesible por el robot. {theta1},{theta2},{theta3}", "Coordenada fuera del espacio de tarea", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double theta1 = Mathematics.Convertions.D2R(Theta1);
            double theta2 = Mathematics.Convertions.D2R(Theta2);
            double theta3 = Mathematics.Convertions.D2R(Theta3);
            double m = L2 * Math.Cos(theta2) + L3 * Math.Cos(theta2 + theta3);
            Z = L2 * Math.Sin(theta2) + L3 * Math.Sin(theta2 + theta3);
            X = m*Math.Cos(theta1);
            Y = m*Math.Sin(theta1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Postures = new Models.Posture[dgvTask.Rows.Count];
                for(int i = 0; i < dgvTask.Rows.Count; ++i)
                {
                    DataGridViewRow row = dgvTask.Rows[i];
                    Postures[i] = new Models.Posture();
                    Postures[i].SetPosture(new int[] { 
                        row.Cells[0].Value == null ? 0 : (int)row.Cells[0].Value,
                        row.Cells[1].Value == null ? 0 : (int)row.Cells[1].Value,
                        row.Cells[2].Value == null ? 0 : (int)row.Cells[2].Value,
                        row.Cells[3].Value == null ? 0 : (int)row.Cells[3].Value,
                        row.Cells[4].Value == null ? 0 : (int)row.Cells[4].Value,
                        row.Cells[5].Value == null ? 0 : (int)row.Cells[5].Value });
                }
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(Postures, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(saveFileDialog1.FileName, json);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string json = File.ReadAllText(openFileDialog1.FileName);
                Postures = Newtonsoft.Json.JsonConvert.DeserializeObject<Models.Posture[]>(json);
                dgvTask.Rows.Clear();
                foreach(Models.Posture pos in Postures)
                {
                    int[] poses = pos.GetPosture();
                    dgvTask.Rows.Add(Array.ConvertAll<int,object>(poses, item => (object)item));
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvTask.Rows.Clear();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                btnConnect.Text = "Conectar";
            }
            else
            {
                try
                { 
                    serialPort1.PortName = cbSerialPorts.SelectedValue.ToString();
                    serialPort1.BaudRate = 115200;
                    serialPort1.Open();
                    btnConnect.Text = "Desconectar";
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Error de comunicación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    serialPort1.Close();
                    btnConnect.Text = "Conectar";
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdatePorts();
        }

        private void probarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                DataGridViewRow row = dgvTask.SelectedRows[0];
                /*Postures[row.Index].SetPosture(new int[] {
                        row.Cells[0].Value == null ? 0 : (int)row.Cells[0].Value,
                        row.Cells[1].Value == null ? 0 : (int)row.Cells[1].Value,
                        row.Cells[2].Value == null ? 0 : (int)row.Cells[2].Value,
                        row.Cells[3].Value == null ? 0 : (int)row.Cells[3].Value,
                        row.Cells[4].Value == null ? 0 : (int)row.Cells[4].Value,
                        row.Cells[5].Value == null ? 0 : (int)row.Cells[5].Value });*/
                string command = String.Join(",", Array.ConvertAll<int, string>(Postures[row.Index].GetPosture(), item => item.ToString()));
                command = $"LMC{command};";
                MessageBox.Show(command);
                serialPort1.WriteLine(command);
            }
        }
    }
}
