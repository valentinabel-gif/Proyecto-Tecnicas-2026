namespace UI_Libreria.Administrador
{
    partial class admiUsuario
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(21, 33);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(868, 25);
            this.txtBuscar.TabIndex = 0;
            this.txtBuscar.Text = "Buscar Usuario...";
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBuscar_TextChanged);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.BackColor = System.Drawing.Color.RosyBrown;
            this.btnBuscarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuscarUsuario.FlatAppearance.BorderColor = System.Drawing.Color.RosyBrown;
            this.btnBuscarUsuario.FlatAppearance.BorderSize = 0;
            this.btnBuscarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarUsuario.Location = new System.Drawing.Point(919, 33);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(201, 25);
            this.btnBuscarUsuario.TabIndex = 1;
            this.btnBuscarUsuario.Text = "BUSCAR";
            this.btnBuscarUsuario.UseVisualStyleBackColor = false;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(896, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 59);
            this.button2.TabIndex = 2;
            this.button2.Text = "CREAR NUEVO USUARIO";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvUsuarios.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvUsuarios.Location = new System.Drawing.Point(39, 126);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(1099, 315);
            this.dgvUsuarios.TabIndex = 3;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnBuscarUsuario);
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 521);
            this.panel1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "USUARIO";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ROL";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "EDITAR";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Text = "EDITAR";
            this.Column4.UseColumnTextForButtonValue = true;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ELIMINAR";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Text = "ELIMINAR";
            this.Column5.UseColumnTextForButtonValue = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "ASIGNAR ROL";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Text = "ASIGNAR ROL";
            this.Column6.UseColumnTextForButtonValue = true;
            this.Column6.Width = 125;
            // 
            // admiUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(179, 90);
            this.Name = "admiUsuario";
            this.Size = new System.Drawing.Size(1185, 586);
            this.Load += new System.EventHandler(this.admiUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewButtonColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}
