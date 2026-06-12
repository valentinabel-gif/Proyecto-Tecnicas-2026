namespace UI_Libreria.Administrador
{
    partial class admiInicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msgBienvenida = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cantUsuarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cantRoles = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cantPermisos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCrearUsuInicio = new System.Windows.Forms.Button();
            this.btnCrearRolInicio = new System.Windows.Forms.Button();
            this.btnAgregarCateInicio = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ListaUsuarios = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.msgBienvenida);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 67);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // msgBienvenida
            // 
            this.msgBienvenida.AutoSize = true;
            this.msgBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.msgBienvenida.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.msgBienvenida.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.msgBienvenida.Location = new System.Drawing.Point(11, 18);
            this.msgBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.msgBienvenida.Name = "msgBienvenida";
            this.msgBienvenida.Size = new System.Drawing.Size(143, 26);
            this.msgBienvenida.TabIndex = 0;
            this.msgBienvenida.Text = "BIENVENIDO!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cantUsuarios);
            this.panel2.Controls.Add(this.label1);
            this.panel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Location = new System.Drawing.Point(16, 83);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 65);
            this.panel2.TabIndex = 1;
            // 
            // cantUsuarios
            // 
            this.cantUsuarios.AutoSize = true;
            this.cantUsuarios.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantUsuarios.ForeColor = System.Drawing.Color.RosyBrown;
            this.cantUsuarios.Location = new System.Drawing.Point(88, 26);
            this.cantUsuarios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cantUsuarios.Name = "cantUsuarios";
            this.cantUsuarios.Size = new System.Drawing.Size(29, 31);
            this.cantUsuarios.TabIndex = 1;
            this.cantUsuarios.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.label1.Location = new System.Drawing.Point(62, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "USUARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.AccessibleName = "";
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.cantRoles);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(230, 83);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(210, 65);
            this.panel3.TabIndex = 2;
            // 
            // cantRoles
            // 
            this.cantRoles.AutoSize = true;
            this.cantRoles.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantRoles.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cantRoles.Location = new System.Drawing.Point(88, 26);
            this.cantRoles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cantRoles.Name = "cantRoles";
            this.cantRoles.Size = new System.Drawing.Size(29, 31);
            this.cantRoles.TabIndex = 1;
            this.cantRoles.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(73, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "ROLES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(446, 83);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(210, 65);
            this.panel4.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Green;
            this.label7.Location = new System.Drawing.Point(97, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 31);
            this.label7.TabIndex = 1;
            this.label7.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.label3.Location = new System.Drawing.Point(62, 8);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "CATEGORIAS";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.cantPermisos);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(659, 83);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(210, 65);
            this.panel5.TabIndex = 4;
            // 
            // cantPermisos
            // 
            this.cantPermisos.AutoSize = true;
            this.cantPermisos.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantPermisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cantPermisos.Location = new System.Drawing.Point(89, 26);
            this.cantPermisos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cantPermisos.Name = "cantPermisos";
            this.cantPermisos.Size = new System.Drawing.Size(29, 31);
            this.cantPermisos.TabIndex = 1;
            this.cantPermisos.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(67, 8);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "PERMISOS";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.btnCrearUsuInicio);
            this.panel6.Controls.Add(this.btnCrearRolInicio);
            this.panel6.Controls.Add(this.btnAgregarCateInicio);
            this.panel6.Location = new System.Drawing.Point(446, 165);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(425, 293);
            this.panel6.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.label9.Location = new System.Drawing.Point(155, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Accesos Rapido";
            // 
            // btnCrearUsuInicio
            // 
            this.btnCrearUsuInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.btnCrearUsuInicio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCrearUsuInicio.FlatAppearance.BorderSize = 3;
            this.btnCrearUsuInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCrearUsuInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCrearUsuInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCrearUsuInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCrearUsuInicio.Location = new System.Drawing.Point(58, 67);
            this.btnCrearUsuInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearUsuInicio.Name = "btnCrearUsuInicio";
            this.btnCrearUsuInicio.Size = new System.Drawing.Size(311, 40);
            this.btnCrearUsuInicio.TabIndex = 2;
            this.btnCrearUsuInicio.Text = "Crear Nuevo Usuario";
            this.btnCrearUsuInicio.UseVisualStyleBackColor = false;
            this.btnCrearUsuInicio.Click += new System.EventHandler(this.btnCrearUsuInicio_Click);
            // 
            // btnCrearRolInicio
            // 
            this.btnCrearRolInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.btnCrearRolInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCrearRolInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnCrearRolInicio.Location = new System.Drawing.Point(58, 124);
            this.btnCrearRolInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearRolInicio.Name = "btnCrearRolInicio";
            this.btnCrearRolInicio.Size = new System.Drawing.Size(311, 40);
            this.btnCrearRolInicio.TabIndex = 1;
            this.btnCrearRolInicio.Text = "Crear Nuevo Rol";
            this.btnCrearRolInicio.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCateInicio
            // 
            this.btnAgregarCateInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(90)))), ((int)(((byte)(102)))));
            this.btnAgregarCateInicio.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarCateInicio.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCateInicio.Location = new System.Drawing.Point(58, 182);
            this.btnAgregarCateInicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCateInicio.Name = "btnAgregarCateInicio";
            this.btnAgregarCateInicio.Size = new System.Drawing.Size(311, 40);
            this.btnAgregarCateInicio.TabIndex = 0;
            this.btnAgregarCateInicio.Text = "Agregar Categoria";
            this.btnAgregarCateInicio.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel7.Controls.Add(this.ListaUsuarios);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(14, 165);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(425, 293);
            this.panel7.TabIndex = 6;
            // 
            // ListaUsuarios
            // 
            this.ListaUsuarios.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.ListaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaUsuarios.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.ListaUsuarios.Location = new System.Drawing.Point(28, 72);
            this.ListaUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ListaUsuarios.Name = "ListaUsuarios";
            this.ListaUsuarios.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ListaUsuarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListaUsuarios.RowTemplate.Height = 24;
            this.ListaUsuarios.Size = new System.Drawing.Size(362, 192);
            this.ListaUsuarios.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.label10.Location = new System.Drawing.Point(130, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Lista de Usuarios";
            // 
            // admiInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Location = new System.Drawing.Point(179, 90);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "admiInicio";
            this.Size = new System.Drawing.Size(889, 476);
            this.Load += new System.EventHandler(this.admiInicio_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListaUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label msgBienvenida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cantUsuarios;
        private System.Windows.Forms.Label cantRoles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cantPermisos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnCrearRolInicio;
        private System.Windows.Forms.Button btnAgregarCateInicio;
        private System.Windows.Forms.Button btnCrearUsuInicio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView ListaUsuarios;
    }
}
