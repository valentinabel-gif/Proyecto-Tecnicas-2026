namespace UI_Libreria.Administrador
{
    partial class admiRol
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
            this.labelbuscarRol = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.dgvRoles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelbuscarRol
            // 
            this.labelbuscarRol.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Italic);
            this.labelbuscarRol.Location = new System.Drawing.Point(22, 46);
            this.labelbuscarRol.Name = "labelbuscarRol";
            this.labelbuscarRol.Size = new System.Drawing.Size(797, 25);
            this.labelbuscarRol.TabIndex = 0;
            this.labelbuscarRol.Text = "Buscar Rol";
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.Chocolate;
            this.btnBuscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 5;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(825, 47);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(216, 25);
            this.btnBuscarUsuario.TabIndex = 2;
            this.btnBuscarUsuario.Text = "BUSCAR";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            // 
            // dgvRoles
            // 
            this.dgvRoles.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvRoles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvRoles.Location = new System.Drawing.Point(22, 109);
            this.dgvRoles.Name = "dgvRoles";
            this.dgvRoles.RowHeadersWidth = 51;
            this.dgvRoles.RowTemplate.Height = 24;
            this.dgvRoles.Size = new System.Drawing.Size(1019, 298);
            this.dgvRoles.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE ROL";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 85;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "PERMISOS";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ELIMINAR ROL";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Text = "ELIMINAR ROL";
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "MODIFICAR ROL";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Text = "MODIFICAR ROL";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 110;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ASIGNAR PERMISO";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Text = "ASIGNAR PERMISO";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Width = 125;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Wheat;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(804, 432);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(237, 56);
            this.button2.TabIndex = 4;
            this.button2.Text = "CREAR NUEVO ROL";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.dgvRoles);
            this.panel1.Controls.Add(this.labelbuscarRol);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 521);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(22, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 298);
            this.panel2.TabIndex = 5;
            // 
            // admiRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(179, 90);
            this.Name = "admiRol";
            this.Size = new System.Drawing.Size(1185, 586);
            this.Load += new System.EventHandler(this.admiRol_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox labelbuscarRol;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
