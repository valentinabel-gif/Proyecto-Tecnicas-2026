namespace UI_Libreria.Gerente
{
    partial class VentaGerente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.gridVENTAS = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.EgresosMesAnterior = new System.Windows.Forms.Label();
            this.Egresos = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.FechaEgreso = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.FechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IngresosMesAnterior = new System.Windows.Forms.Label();
            this.Ingresos = new System.Windows.Forms.Label();
            this.MesAnterior = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVENTAS)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.gridVENTAS);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 536);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Ventas";
            // 
            // gridVENTAS
            // 
            this.gridVENTAS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridVENTAS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVENTAS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridVENTAS.Location = new System.Drawing.Point(22, 289);
            this.gridVENTAS.Name = "gridVENTAS";
            this.gridVENTAS.RowHeadersWidth = 51;
            this.gridVENTAS.RowTemplate.Height = 24;
            this.gridVENTAS.Size = new System.Drawing.Size(1094, 240);
            this.gridVENTAS.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Productos";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Total";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(575, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Consultar Egresos";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.FechaEgreso);
            this.panel3.Location = new System.Drawing.Point(575, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(541, 211);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Menu;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.EgresosMesAnterior);
            this.panel5.Controls.Add(this.Egresos);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Location = new System.Drawing.Point(16, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(509, 146);
            this.panel5.TabIndex = 8;
            // 
            // EgresosMesAnterior
            // 
            this.EgresosMesAnterior.AutoSize = true;
            this.EgresosMesAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.EgresosMesAnterior.ForeColor = System.Drawing.Color.Brown;
            this.EgresosMesAnterior.Location = new System.Drawing.Point(347, 81);
            this.EgresosMesAnterior.Name = "EgresosMesAnterior";
            this.EgresosMesAnterior.Size = new System.Drawing.Size(104, 29);
            this.EgresosMesAnterior.TabIndex = 3;
            this.EgresosMesAnterior.Text = "$18.500";
            // 
            // Egresos
            // 
            this.Egresos.AutoSize = true;
            this.Egresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Egresos.ForeColor = System.Drawing.Color.Brown;
            this.Egresos.Location = new System.Drawing.Point(62, 81);
            this.Egresos.Name = "Egresos";
            this.Egresos.Size = new System.Drawing.Size(104, 29);
            this.Egresos.TabIndex = 2;
            this.Egresos.Text = "$12.800";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(346, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Mes Anterior";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label9.Location = new System.Drawing.Point(64, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Este Mes";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FechaEgreso
            // 
            this.FechaEgreso.CustomFormat = "MMMM yyyy";
            this.FechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaEgreso.Location = new System.Drawing.Point(16, 10);
            this.FechaEgreso.Name = "FechaEgreso";
            this.FechaEgreso.Size = new System.Drawing.Size(322, 22);
            this.FechaEgreso.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.FechaIngreso);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(22, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 211);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FechaIngreso
            // 
            this.FechaIngreso.CustomFormat = "MMMM yyyy";
            this.FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaIngreso.Location = new System.Drawing.Point(17, 13);
            this.FechaIngreso.Name = "FechaIngreso";
            this.FechaIngreso.Size = new System.Drawing.Size(322, 22);
            this.FechaIngreso.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Menu;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.IngresosMesAnterior);
            this.panel4.Controls.Add(this.Ingresos);
            this.panel4.Controls.Add(this.MesAnterior);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(17, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(509, 146);
            this.panel4.TabIndex = 0;
            // 
            // IngresosMesAnterior
            // 
            this.IngresosMesAnterior.AutoSize = true;
            this.IngresosMesAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.IngresosMesAnterior.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.IngresosMesAnterior.Location = new System.Drawing.Point(347, 81);
            this.IngresosMesAnterior.Name = "IngresosMesAnterior";
            this.IngresosMesAnterior.Size = new System.Drawing.Size(104, 29);
            this.IngresosMesAnterior.TabIndex = 3;
            this.IngresosMesAnterior.Text = "$38.500";
            // 
            // Ingresos
            // 
            this.Ingresos.AutoSize = true;
            this.Ingresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ingresos.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.Ingresos.Location = new System.Drawing.Point(62, 81);
            this.Ingresos.Name = "Ingresos";
            this.Ingresos.Size = new System.Drawing.Size(104, 29);
            this.Ingresos.TabIndex = 2;
            this.Ingresos.Text = "$40.500";
            // 
            // MesAnterior
            // 
            this.MesAnterior.AutoSize = true;
            this.MesAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MesAnterior.Location = new System.Drawing.Point(346, 36);
            this.MesAnterior.Name = "MesAnterior";
            this.MesAnterior.Size = new System.Drawing.Size(105, 20);
            this.MesAnterior.TabIndex = 1;
            this.MesAnterior.Text = "Mes Anterior";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.label2.Location = new System.Drawing.Point(64, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Este Mes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consultar Ingresos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // VentaGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(179, 90);
            this.Name = "VentaGerente";
            this.Size = new System.Drawing.Size(1185, 586);
            this.Load += new System.EventHandler(this.VentaGerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVENTAS)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DateTimePicker FechaIngreso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label IngresosMesAnterior;
        private System.Windows.Forms.Label Ingresos;
        private System.Windows.Forms.Label MesAnterior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridVENTAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label EgresosMesAnterior;
        private System.Windows.Forms.Label Egresos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker FechaEgreso;
        private System.Windows.Forms.Label label11;
    }
}
