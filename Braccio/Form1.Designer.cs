namespace Braccio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbM3 = new System.Windows.Forms.TextBox();
            this.tbM1 = new System.Windows.Forms.TextBox();
            this.tbM2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.M1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbCommunication = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbSerialPorts = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.probarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.gbCommunication.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbZ);
            this.groupBox1.Controls.Add(this.tbY);
            this.groupBox1.Controls.Add(this.tbX);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Posición deseada (cm)";
            // 
            // tbZ
            // 
            this.tbZ.Location = new System.Drawing.Point(43, 74);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(100, 20);
            this.tbZ.TabIndex = 5;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(43, 52);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 4;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(43, 30);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Z:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbM3);
            this.groupBox2.Controls.Add(this.tbM1);
            this.groupBox2.Controls.Add(this.tbM2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(187, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angulos deseados (grados)";
            // 
            // tbM3
            // 
            this.tbM3.Location = new System.Drawing.Point(36, 74);
            this.tbM3.Name = "tbM3";
            this.tbM3.Size = new System.Drawing.Size(100, 20);
            this.tbM3.TabIndex = 11;
            this.toolTip1.SetToolTip(this.tbM3, "ANGULO DEL MOTOR 3");
            // 
            // tbM1
            // 
            this.tbM1.Location = new System.Drawing.Point(36, 30);
            this.tbM1.Name = "tbM1";
            this.tbM1.Size = new System.Drawing.Size(100, 20);
            this.tbM1.TabIndex = 9;
            this.toolTip1.SetToolTip(this.tbM1, "ANGULO DEL MOTOR 1");
            // 
            // tbM2
            // 
            this.tbM2.Location = new System.Drawing.Point(36, 52);
            this.tbM2.Name = "tbM2";
            this.tbM2.Size = new System.Drawing.Size(100, 20);
            this.tbM2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.tbM2, "ANGULO DEL MOTOR 2");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "A:";
            this.toolTip1.SetToolTip(this.label6, "ANGULO DEL MOTOR 1");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "B:";
            this.toolTip1.SetToolTip(this.label5, "ANGULO DEL MOTOR 2");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "C:";
            this.toolTip1.SetToolTip(this.label4, "ANGULO DEL MOTOR 3");
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(371, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Comandos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(188, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Guardar posición";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Obtener posicion";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Obtener grados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvTask);
            this.groupBox4.Location = new System.Drawing.Point(12, 143);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(356, 222);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tarea";
            // 
            // dgvTask
            // 
            this.dgvTask.AllowUserToAddRows = false;
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M1,
            this.M2,
            this.M3,
            this.M4,
            this.M5,
            this.M6});
            this.dgvTask.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvTask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTask.Location = new System.Drawing.Point(3, 16);
            this.dgvTask.Name = "dgvTask";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTask.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvTask.Size = new System.Drawing.Size(350, 203);
            this.dgvTask.TabIndex = 0;
            this.dgvTask.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvTask_RowsRemoved);
            // 
            // M1
            // 
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "0";
            this.M1.DefaultCellStyle = dataGridViewCellStyle1;
            this.M1.HeaderText = "M1";
            this.M1.Name = "M1";
            this.M1.Width = 50;
            // 
            // M2
            // 
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = "0";
            this.M2.DefaultCellStyle = dataGridViewCellStyle2;
            this.M2.HeaderText = "M2";
            this.M2.Name = "M2";
            this.M2.Width = 50;
            // 
            // M3
            // 
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = "0";
            this.M3.DefaultCellStyle = dataGridViewCellStyle3;
            this.M3.HeaderText = "M3";
            this.M3.Name = "M3";
            this.M3.Width = 50;
            // 
            // M4
            // 
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = "0";
            this.M4.DefaultCellStyle = dataGridViewCellStyle4;
            this.M4.HeaderText = "M4";
            this.M4.Name = "M4";
            this.M4.Width = 50;
            // 
            // M5
            // 
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.M5.DefaultCellStyle = dataGridViewCellStyle5;
            this.M5.HeaderText = "M5";
            this.M5.Name = "M5";
            this.M5.Width = 50;
            // 
            // M6
            // 
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = "0";
            this.M6.DefaultCellStyle = dataGridViewCellStyle6;
            this.M6.HeaderText = "M6";
            this.M6.Name = "M6";
            this.M6.Width = 50;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.btnOpenFile);
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Location = new System.Drawing.Point(377, 143);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 108);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Comandos";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 75);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(188, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Reset";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(6, 48);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(188, 23);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Cargar Tarea";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Guardar Tarea";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos JSON|*.json";
            // 
            // gbCommunication
            // 
            this.gbCommunication.Controls.Add(this.btnUpdate);
            this.gbCommunication.Controls.Add(this.btnConnect);
            this.gbCommunication.Controls.Add(this.cbSerialPorts);
            this.gbCommunication.Controls.Add(this.label7);
            this.gbCommunication.Location = new System.Drawing.Point(377, 257);
            this.gbCommunication.Name = "gbCommunication";
            this.gbCommunication.Size = new System.Drawing.Size(288, 108);
            this.gbCommunication.TabIndex = 4;
            this.gbCommunication.TabStop = false;
            this.gbCommunication.Text = "Comunicación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Puerto:";
            // 
            // cbSerialPorts
            // 
            this.cbSerialPorts.FormattingEnabled = true;
            this.cbSerialPorts.Location = new System.Drawing.Point(53, 13);
            this.cbSerialPorts.Name = "cbSerialPorts";
            this.cbSerialPorts.Size = new System.Drawing.Size(229, 21);
            this.cbSerialPorts.TabIndex = 1;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(53, 40);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(188, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(53, 69);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(188, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Actualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.probarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // probarToolStripMenuItem
            // 
            this.probarToolStripMenuItem.Name = "probarToolStripMenuItem";
            this.probarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.probarToolStripMenuItem.Text = "Probar";
            this.probarToolStripMenuItem.Click += new System.EventHandler(this.probarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 372);
            this.Controls.Add(this.gbCommunication);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "HMI - Braccio";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.gbCommunication.ResumeLayout(false);
            this.gbCommunication.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbM3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox tbM1;
        private System.Windows.Forms.TextBox tbM2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn M1;
        private System.Windows.Forms.DataGridViewTextBoxColumn M2;
        private System.Windows.Forms.DataGridViewTextBoxColumn M3;
        private System.Windows.Forms.DataGridViewTextBoxColumn M4;
        private System.Windows.Forms.DataGridViewTextBoxColumn M5;
        private System.Windows.Forms.DataGridViewTextBoxColumn M6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbCommunication;
        private System.Windows.Forms.ComboBox cbSerialPorts;
        private System.Windows.Forms.Label label7;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem probarToolStripMenuItem;
    }
}

