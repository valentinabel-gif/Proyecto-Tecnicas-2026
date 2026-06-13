namespace UI_Libreria.Administrador
{
    partial class admiCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.AgregarCategoria = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEditarCategoria = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CATEGORIAS DE PRODUCTOS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCategorias.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.colEliminarCategoria,
            this.colEditarCategoria});
            this.dgvCategorias.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgvCategorias.Location = new System.Drawing.Point(38, 142);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.RowHeadersWidth = 51;
            this.dgvCategorias.RowTemplate.Height = 24;
            this.dgvCategorias.Size = new System.Drawing.Size(1096, 288);
            this.dgvCategorias.TabIndex = 1;
            this.dgvCategorias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick_1);
            // 
            // AgregarCategoria
            // 
            this.AgregarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.AgregarCategoria.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AgregarCategoria.FlatAppearance.BorderSize = 0;
            this.AgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AgregarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AgregarCategoria.Location = new System.Drawing.Point(877, 415);
            this.AgregarCategoria.Name = "AgregarCategoria";
            this.AgregarCategoria.Size = new System.Drawing.Size(239, 47);
            this.AgregarCategoria.TabIndex = 5;
            this.AgregarCategoria.Text = "AGREGAR NUEVA CATEGORIA";
            this.AgregarCategoria.UseVisualStyleBackColor = false;
            this.AgregarCategoria.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(212)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.AgregarCategoria);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(16, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 521);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NOMBRE";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 170;
            // 
            // colEliminarCategoria
            // 
            this.colEliminarCategoria.HeaderText = "ELIMINAR";
            this.colEliminarCategoria.MinimumWidth = 6;
            this.colEliminarCategoria.Name = "colEliminarCategoria";
            this.colEliminarCategoria.ReadOnly = true;
            this.colEliminarCategoria.Text = "ELIMINAR";
            this.colEliminarCategoria.UseColumnTextForButtonValue = true;
            this.colEliminarCategoria.Width = 180;
            // 
            // colEditarCategoria
            // 
            this.colEditarCategoria.HeaderText = "EDITAR";
            this.colEditarCategoria.MinimumWidth = 6;
            this.colEditarCategoria.Name = "colEditarCategoria";
            this.colEditarCategoria.ReadOnly = true;
            this.colEditarCategoria.Text = "EDITAR";
            this.colEditarCategoria.UseColumnTextForButtonValue = true;
            this.colEditarCategoria.Width = 125;
            // 
            // admiCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.dgvCategorias);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(179, 90);
            this.Name = "admiCategoria";
            this.Size = new System.Drawing.Size(1185, 586);
            this.Load += new System.EventHandler(this.admiCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.Button AgregarCategoria;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminarCategoria;
        private System.Windows.Forms.DataGridViewButtonColumn colEditarCategoria;
    }
}
