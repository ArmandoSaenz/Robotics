namespace DH_Parameters
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDH = new System.Windows.Forms.DataGridView();
            this.tbNumJoins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alpha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dDistance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSNAP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSNAP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDH
            // 
            this.dgvDH.AllowUserToAddRows = false;
            this.dgvDH.AllowUserToDeleteRows = false;
            this.dgvDH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.aDistance,
            this.alpha,
            this.dDistance,
            this.theta});
            this.dgvDH.Location = new System.Drawing.Point(12, 12);
            this.dgvDH.Name = "dgvDH";
            this.dgvDH.RowHeadersVisible = false;
            this.dgvDH.Size = new System.Drawing.Size(438, 228);
            this.dgvDH.TabIndex = 0;
            // 
            // tbNumJoins
            // 
            this.tbNumJoins.Location = new System.Drawing.Point(459, 28);
            this.tbNumJoins.Name = "tbNumJoins";
            this.tbNumJoins.Size = new System.Drawing.Size(100, 20);
            this.tbNumJoins.TabIndex = 1;
            this.tbNumJoins.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumJoins_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(456, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Indicar el numero de eslabones";
            // 
            // Number
            // 
            this.Number.HeaderText = "i";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 25;
            // 
            // aDistance
            // 
            dataGridViewCellStyle1.Format = "N6";
            dataGridViewCellStyle1.NullValue = null;
            this.aDistance.DefaultCellStyle = dataGridViewCellStyle1;
            this.aDistance.HeaderText = "a";
            this.aDistance.Name = "aDistance";
            // 
            // alpha
            // 
            dataGridViewCellStyle2.Format = "N6";
            dataGridViewCellStyle2.NullValue = null;
            this.alpha.DefaultCellStyle = dataGridViewCellStyle2;
            this.alpha.HeaderText = "alpha";
            this.alpha.Name = "alpha";
            // 
            // dDistance
            // 
            dataGridViewCellStyle3.Format = "N6";
            this.dDistance.DefaultCellStyle = dataGridViewCellStyle3;
            this.dDistance.HeaderText = "d";
            this.dDistance.Name = "dDistance";
            // 
            // theta
            // 
            dataGridViewCellStyle4.Format = "N6";
            this.theta.DefaultCellStyle = dataGridViewCellStyle4;
            this.theta.HeaderText = "theta";
            this.theta.Name = "theta";
            // 
            // dgvSNAP
            // 
            this.dgvSNAP.AllowUserToAddRows = false;
            this.dgvSNAP.AllowUserToDeleteRows = false;
            this.dgvSNAP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSNAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSNAP.Location = new System.Drawing.Point(12, 246);
            this.dgvSNAP.Name = "dgvSNAP";
            this.dgvSNAP.ReadOnly = true;
            this.dgvSNAP.RowHeadersVisible = false;
            this.dgvSNAP.Size = new System.Drawing.Size(319, 192);
            this.dgvSNAP.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.Format = "N6";
            this.Column1.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column1.HeaderText = "S";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 39;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.Format = "N6";
            this.Column2.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column2.HeaderText = "N";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 40;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.Format = "N6";
            this.Column3.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column3.HeaderText = "A";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 39;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.Format = "N6";
            this.Column4.DefaultCellStyle = dataGridViewCellStyle8;
            this.Column4.HeaderText = "P";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 39;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generar Matrices";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(337, 246);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 186);
            this.listBox1.TabIndex = 5;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvSNAP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNumJoins);
            this.Controls.Add(this.dgvDH);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSNAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDH;
        private System.Windows.Forms.TextBox tbNumJoins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dDistance;
        private System.Windows.Forms.DataGridViewTextBoxColumn theta;
        private System.Windows.Forms.DataGridView dgvSNAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

