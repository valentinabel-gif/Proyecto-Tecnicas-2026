namespace UI_Libreria
{
    partial class FormVendedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendedor));
            this.InicioPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnGestionClientes = new System.Windows.Forms.Button();
            this.BtnConsultaPrecio = new System.Windows.Forms.Button();
            this.BtnVenta = new System.Windows.Forms.Button();
            this.BtnInicioVenta = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InicioPanel
            // 
            this.InicioPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.InicioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InicioPanel.Location = new System.Drawing.Point(134, 57);
            this.InicioPanel.Margin = new System.Windows.Forms.Padding(2);
            this.InicioPanel.Name = "InicioPanel";
            this.InicioPanel.Size = new System.Drawing.Size(892, 492);
            this.InicioPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.panel2.Controls.Add(this.Date);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(134, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 57);
            this.panel2.TabIndex = 4;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Date.Location = new System.Drawing.Point(334, 23);
            this.Date.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(12, 17);
            this.Date.TabIndex = 2;
            this.Date.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(292, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(160, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vendedor Mayorista";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Inicio";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnGestionClientes);
            this.panel1.Controls.Add(this.BtnConsultaPrecio);
            this.panel1.Controls.Add(this.BtnVenta);
            this.panel1.Controls.Add(this.BtnInicioVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(134, 549);
            this.panel1.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(20, 379);
            this.button6.Margin = new System.Windows.Forms.Padding(2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(100, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Cerrar sesion";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libreria Mayorista";
            // 
            // BtnGestionClientes
            // 
            this.BtnGestionClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.BtnGestionClientes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnGestionClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestionClientes.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestionClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnGestionClientes.Location = new System.Drawing.Point(0, 192);
            this.BtnGestionClientes.Margin = new System.Windows.Forms.Padding(2);
            this.BtnGestionClientes.Name = "BtnGestionClientes";
            this.BtnGestionClientes.Size = new System.Drawing.Size(134, 51);
            this.BtnGestionClientes.TabIndex = 2;
            this.BtnGestionClientes.Text = "Gestion de Clientes";
            this.BtnGestionClientes.UseVisualStyleBackColor = false;
            this.BtnGestionClientes.Click += new System.EventHandler(this.BtnGestionClientes_Click);
            // 
            // BtnConsultaPrecio
            // 
            this.BtnConsultaPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.BtnConsultaPrecio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnConsultaPrecio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultaPrecio.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsultaPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnConsultaPrecio.Location = new System.Drawing.Point(0, 145);
            this.BtnConsultaPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConsultaPrecio.Name = "BtnConsultaPrecio";
            this.BtnConsultaPrecio.Size = new System.Drawing.Size(134, 49);
            this.BtnConsultaPrecio.TabIndex = 2;
            this.BtnConsultaPrecio.Text = "Consultar Precio";
            this.BtnConsultaPrecio.UseVisualStyleBackColor = false;
            this.BtnConsultaPrecio.Click += new System.EventHandler(this.BtnConsultaPrecio_Click);
            // 
            // BtnVenta
            // 
            this.BtnVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.BtnVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVenta.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnVenta.Location = new System.Drawing.Point(0, 101);
            this.BtnVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BtnVenta.Name = "BtnVenta";
            this.BtnVenta.Size = new System.Drawing.Size(134, 49);
            this.BtnVenta.TabIndex = 2;
            this.BtnVenta.Text = "Venta";
            this.BtnVenta.UseVisualStyleBackColor = false;
            this.BtnVenta.Click += new System.EventHandler(this.BtnVenta_Click);
            // 
            // BtnInicioVenta
            // 
            this.BtnInicioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.BtnInicioVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnInicioVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnInicioVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicioVenta.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicioVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnInicioVenta.Location = new System.Drawing.Point(0, 54);
            this.BtnInicioVenta.Margin = new System.Windows.Forms.Padding(2);
            this.BtnInicioVenta.Name = "BtnInicioVenta";
            this.BtnInicioVenta.Size = new System.Drawing.Size(134, 49);
            this.BtnInicioVenta.TabIndex = 2;
            this.BtnInicioVenta.Text = "Inicio";
            this.BtnInicioVenta.UseVisualStyleBackColor = false;
            this.BtnInicioVenta.Click += new System.EventHandler(this.BtnInicioVenta_Click);
            // 
            // FormVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 549);
            this.Controls.Add(this.InicioPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormVendedor";
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InicioPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnGestionClientes;
        private System.Windows.Forms.Button BtnConsultaPrecio;
        private System.Windows.Forms.Button BtnVenta;
        private System.Windows.Forms.Button BtnInicioVenta;
    }
}