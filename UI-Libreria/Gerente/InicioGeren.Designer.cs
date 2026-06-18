namespace UI_Libreria.Gerente
{
    partial class InicioGeren
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
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.MsgNoHayVentas = new System.Windows.Forms.Label();
            this.dvgVentasDelDia = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.SinStock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.StockMinimo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.VendedorMasVentas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.msgBienvenida = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVentasDelDia)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(23, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1140, 482);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RosyBrown;
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel8.Location = new System.Drawing.Point(658, 174);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(453, 27);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.RosyBrown;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Location = new System.Drawing.Point(14, 174);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(453, 27);
            this.panel7.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(484, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Ventas Del Dia";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.MsgNoHayVentas);
            this.panel4.Controls.Add(this.dvgVentasDelDia);
            this.panel4.Location = new System.Drawing.Point(14, 204);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1097, 257);
            this.panel4.TabIndex = 4;
            // 
            // MsgNoHayVentas
            // 
            this.MsgNoHayVentas.AutoSize = true;
            this.MsgNoHayVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MsgNoHayVentas.ForeColor = System.Drawing.Color.Red;
            this.MsgNoHayVentas.Location = new System.Drawing.Point(444, 103);
            this.MsgNoHayVentas.Name = "MsgNoHayVentas";
            this.MsgNoHayVentas.Size = new System.Drawing.Size(187, 29);
            this.MsgNoHayVentas.TabIndex = 1;
            this.MsgNoHayVentas.Text = "No hay Ventas ";
            this.MsgNoHayVentas.Visible = false;
            // 
            // dvgVentasDelDia
            // 
            this.dvgVentasDelDia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgVentasDelDia.Location = new System.Drawing.Point(184, 38);
            this.dvgVentasDelDia.Name = "dvgVentasDelDia";
            this.dvgVentasDelDia.RowHeadersWidth = 51;
            this.dvgVentasDelDia.RowTemplate.Height = 24;
            this.dvgVentasDelDia.Size = new System.Drawing.Size(736, 183);
            this.dvgVentasDelDia.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.SinStock);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(766, 14);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(345, 124);
            this.panel6.TabIndex = 3;
            // 
            // SinStock
            // 
            this.SinStock.AutoSize = true;
            this.SinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.SinStock.ForeColor = System.Drawing.Color.Crimson;
            this.SinStock.Location = new System.Drawing.Point(159, 50);
            this.SinStock.Name = "SinStock";
            this.SinStock.Size = new System.Drawing.Size(31, 32);
            this.SinStock.TabIndex = 4;
            this.SinStock.Text = "3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label6.Location = new System.Drawing.Point(121, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sin Stock";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.StockMinimo);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(391, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(369, 124);
            this.panel5.TabIndex = 2;
            // 
            // StockMinimo
            // 
            this.StockMinimo.AutoSize = true;
            this.StockMinimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold);
            this.StockMinimo.ForeColor = System.Drawing.Color.Crimson;
            this.StockMinimo.Location = new System.Drawing.Point(154, 50);
            this.StockMinimo.Name = "StockMinimo";
            this.StockMinimo.Size = new System.Drawing.Size(48, 32);
            this.StockMinimo.TabIndex = 3;
            this.StockMinimo.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 29);
            this.label4.TabIndex = 0;
            this.label4.Text = "Productos con Stock Minimo";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.VendedorMasVentas);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(14, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(371, 124);
            this.panel3.TabIndex = 0;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // VendedorMasVentas
            // 
            this.VendedorMasVentas.AutoSize = true;
            this.VendedorMasVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VendedorMasVentas.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.VendedorMasVentas.Location = new System.Drawing.Point(117, 50);
            this.VendedorMasVentas.Name = "VendedorMasVentas";
            this.VendedorMasVentas.Size = new System.Drawing.Size(119, 32);
            this.VendedorMasVentas.TabIndex = 2;
            this.VendedorMasVentas.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vendedor con mas ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 22);
            this.label1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.msgBienvenida);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1185, 82);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // msgBienvenida
            // 
            this.msgBienvenida.AutoSize = true;
            this.msgBienvenida.BackColor = System.Drawing.Color.AntiqueWhite;
            this.msgBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.msgBienvenida.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.msgBienvenida.Location = new System.Drawing.Point(15, 22);
            this.msgBienvenida.Name = "msgBienvenida";
            this.msgBienvenida.Size = new System.Drawing.Size(173, 31);
            this.msgBienvenida.TabIndex = 0;
            this.msgBienvenida.Text = "BIENVENIDO!";
            // 
            // InicioGeren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(179, 90);
            this.Name = "InicioGeren";
            this.Size = new System.Drawing.Size(1185, 586);
            this.Load += new System.EventHandler(this.InicioGeren_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgVentasDelDia)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label msgBienvenida;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label VendedorMasVentas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label StockMinimo;
        private System.Windows.Forms.Label SinStock;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dvgVentasDelDia;
        private System.Windows.Forms.Label MsgNoHayVentas;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
    }
}
