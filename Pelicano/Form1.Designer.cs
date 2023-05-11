namespace Pelicano
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbGeometry = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbL1 = new System.Windows.Forms.TextBox();
            this.tbL2 = new System.Windows.Forms.TextBox();
            this.gbPosition = new System.Windows.Forms.GroupBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbPosture = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lTheta1 = new System.Windows.Forms.Label();
            this.lTheta2 = new System.Windows.Forms.Label();
            this.btnCompute = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbGeometry.SuspendLayout();
            this.gbPosition.SuspendLayout();
            this.gbPosture.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCompute);
            this.splitContainer1.Panel1.Controls.Add(this.gbPosture);
            this.splitContainer1.Panel1.Controls.Add(this.gbPosition);
            this.splitContainer1.Panel1.Controls.Add(this.gbGeometry);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.plotView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // gbGeometry
            // 
            this.gbGeometry.Controls.Add(this.tbL2);
            this.gbGeometry.Controls.Add(this.tbL1);
            this.gbGeometry.Controls.Add(this.label2);
            this.gbGeometry.Controls.Add(this.label1);
            this.gbGeometry.Location = new System.Drawing.Point(3, 12);
            this.gbGeometry.Name = "gbGeometry";
            this.gbGeometry.Size = new System.Drawing.Size(260, 101);
            this.gbGeometry.TabIndex = 0;
            this.gbGeometry.TabStop = false;
            this.gbGeometry.Text = "Geometría del robot";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Largo eslabon 1 (l1)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largo eslabon 2 (l2)";
            // 
            // tbL1
            // 
            this.tbL1.Location = new System.Drawing.Point(138, 28);
            this.tbL1.Name = "tbL1";
            this.tbL1.Size = new System.Drawing.Size(100, 20);
            this.tbL1.TabIndex = 2;
            // 
            // tbL2
            // 
            this.tbL2.Location = new System.Drawing.Point(138, 58);
            this.tbL2.Name = "tbL2";
            this.tbL2.Size = new System.Drawing.Size(100, 20);
            this.tbL2.TabIndex = 3;
            // 
            // gbPosition
            // 
            this.gbPosition.Controls.Add(this.tbY);
            this.gbPosition.Controls.Add(this.tbX);
            this.gbPosition.Controls.Add(this.label3);
            this.gbPosition.Controls.Add(this.label4);
            this.gbPosition.Location = new System.Drawing.Point(3, 119);
            this.gbPosition.Name = "gbPosition";
            this.gbPosition.Size = new System.Drawing.Size(260, 101);
            this.gbPosition.TabIndex = 4;
            this.gbPosition.TabStop = false;
            this.gbPosition.Text = "Posición deseada";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(138, 58);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 3;
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(138, 28);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(100, 20);
            this.tbX.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Posicion Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Posicion X:";
            // 
            // gbPosture
            // 
            this.gbPosture.Controls.Add(this.lTheta2);
            this.gbPosture.Controls.Add(this.lTheta1);
            this.gbPosture.Controls.Add(this.label5);
            this.gbPosture.Controls.Add(this.label6);
            this.gbPosture.Location = new System.Drawing.Point(3, 226);
            this.gbPosture.Name = "gbPosture";
            this.gbPosture.Size = new System.Drawing.Size(260, 101);
            this.gbPosture.TabIndex = 5;
            this.gbPosture.TabStop = false;
            this.gbPosture.Text = "Postura del robot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Angulo 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Angulo 1:";
            // 
            // lTheta1
            // 
            this.lTheta1.AutoSize = true;
            this.lTheta1.Location = new System.Drawing.Point(84, 31);
            this.lTheta1.Name = "lTheta1";
            this.lTheta1.Size = new System.Drawing.Size(13, 13);
            this.lTheta1.TabIndex = 2;
            this.lTheta1.Text = "0";
            // 
            // lTheta2
            // 
            this.lTheta2.AutoSize = true;
            this.lTheta2.Location = new System.Drawing.Point(84, 61);
            this.lTheta2.Name = "lTheta2";
            this.lTheta2.Size = new System.Drawing.Size(13, 13);
            this.lTheta2.TabIndex = 3;
            this.lTheta2.Text = "0";
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(188, 333);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(75, 23);
            this.btnCompute.TabIndex = 6;
            this.btnCompute.Text = "Calcular";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // plotView1
            // 
            this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotView1.Location = new System.Drawing.Point(0, 0);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(530, 450);
            this.plotView1.TabIndex = 0;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Cinemática inversa del robot RR (Pelicano)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbGeometry.ResumeLayout(false);
            this.gbGeometry.PerformLayout();
            this.gbPosition.ResumeLayout(false);
            this.gbPosition.PerformLayout();
            this.gbPosture.ResumeLayout(false);
            this.gbPosture.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbGeometry;
        private System.Windows.Forms.TextBox tbL2;
        private System.Windows.Forms.TextBox tbL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPosition;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbPosture;
        private System.Windows.Forms.Label lTheta2;
        private System.Windows.Forms.Label lTheta1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCompute;
        private OxyPlot.WindowsForms.PlotView plotView1;
    }
}

