namespace UI_Libreria.Gerente
{
    partial class ProveedorGerente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colConsultarPrecios = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colVerProductos = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtBuscar);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 528);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(25, 61);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(280, 22);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.nombre_proveedor,
            this.cuil,
            this.telefono,
            this.colModificar,
            this.colEliminar,
            this.colConsultarPrecios,
            this.colVerProductos});
            this.dataGridView1.Location = new System.Drawing.Point(25, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 391);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROVEEDORES";
            // 
            // id_proveedor
            // 
            this.id_proveedor.DataPropertyName = "IdProveedor";
            this.id_proveedor.HeaderText = "ID";
            this.id_proveedor.MinimumWidth = 6;
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.Width = 70;
            // 
            // nombre_proveedor
            // 
            this.nombre_proveedor.DataPropertyName = "NombreProveedor";
            this.nombre_proveedor.HeaderText = "PROVEEDOR";
            this.nombre_proveedor.MinimumWidth = 6;
            this.nombre_proveedor.Name = "nombre_proveedor";
            this.nombre_proveedor.Width = 125;
            // 
            // cuil
            // 
            this.cuil.DataPropertyName = "CuitProveedor";
            this.cuil.HeaderText = "CUIT";
            this.cuil.MinimumWidth = 6;
            this.cuil.Name = "cuil";
            this.cuil.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "TelefonoProveedor";
            this.telefono.HeaderText = "TELEFONO";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.Width = 125;
            // 
            // colModificar
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.colModificar.DefaultCellStyle = dataGridViewCellStyle1;
            this.colModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colModificar.HeaderText = "Modificar ";
            this.colModificar.MinimumWidth = 6;
            this.colModificar.Name = "colModificar";
            this.colModificar.Text = "Modificar ";
            this.colModificar.ToolTipText = "Modificar ";
            this.colModificar.UseColumnTextForButtonValue = true;
            this.colModificar.Width = 125;
            // 
            // colEliminar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.colEliminar.DefaultCellStyle = dataGridViewCellStyle2;
            this.colEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.MinimumWidth = 6;
            this.colEliminar.Name = "colEliminar";
            this.colEliminar.Text = "Eliminar ";
            this.colEliminar.UseColumnTextForButtonValue = true;
            this.colEliminar.Width = 125;
            // 
            // colConsultarPrecios
            // 
            this.colConsultarPrecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colConsultarPrecios.HeaderText = "Consultar Precios";
            this.colConsultarPrecios.MinimumWidth = 6;
            this.colConsultarPrecios.Name = "colConsultarPrecios";
            this.colConsultarPrecios.Text = "Consultar Precios";
            this.colConsultarPrecios.UseColumnTextForButtonValue = true;
            this.colConsultarPrecios.Width = 125;
            // 
            // colVerProductos
            // 
            this.colVerProductos.HeaderText = "Ver lista de productos";
            this.colVerProductos.MinimumWidth = 6;
            this.colVerProductos.Name = "colVerProductos";
            this.colVerProductos.Width = 125;
            // 
            // ProveedorGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(179, 90);
            this.Name = "ProveedorGerente";
            this.Size = new System.Drawing.Size(1185, 586);
            this.Load += new System.EventHandler(this.ProveedorGerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewButtonColumn colModificar;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.DataGridViewButtonColumn colConsultarPrecios;
        private System.Windows.Forms.DataGridViewButtonColumn colVerProductos;
    }
}
