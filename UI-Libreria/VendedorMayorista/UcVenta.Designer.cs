namespace UI_Libreria.VendedorMayorista
{
    partial class UcVenta
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDniCuitCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gpMedioPago = new System.Windows.Forms.GroupBox();
            this.btnTransferencia = new System.Windows.Forms.RadioButton();
            this.btnCredito = new System.Windows.Forms.RadioButton();
            this.btnDebito = new System.Windows.Forms.RadioButton();
            this.btnEfectivo = new System.Windows.Forms.RadioButton();
            this.lSubtotal = new System.Windows.Forms.Label();
            this.lTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnConfirmarVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.gbDescuento = new System.Windows.Forms.GroupBox();
            this.rbDesc15 = new System.Windows.Forms.RadioButton();
            this.rbDesc10 = new System.Windows.Forms.RadioButton();
            this.rbDesc5 = new System.Windows.Forms.RadioButton();
            this.RazonSociallbl = new System.Windows.Forms.Label();
            this.CondFiscallbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gpMedioPago.SuspendLayout();
            this.gbDescuento.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese codigo de barras o nombre del producto";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(16, 40);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(155, 22);
            this.txtBusqueda.TabIndex = 1;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            this.txtBusqueda.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBusqueda_KeyDown);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetalle.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cantidad,
            this.Detalle,
            this.Subtotal});
            this.dgvDetalle.Location = new System.Drawing.Point(0, 68);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowHeadersWidth = 51;
            this.dgvDetalle.Size = new System.Drawing.Size(607, 405);
            this.dgvDetalle.TabIndex = 2;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.MinimumWidth = 6;
            this.Detalle.Name = "Detalle";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.CondFiscallbl);
            this.groupBox1.Controls.Add(this.RazonSociallbl);
            this.groupBox1.Controls.Add(this.txtDniCuitCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(613, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 91);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identificacion Del Cliente";
            // 
            // txtDniCuitCliente
            // 
            this.txtDniCuitCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDniCuitCliente.Location = new System.Drawing.Point(7, 39);
            this.txtDniCuitCliente.Name = "txtDniCuitCliente";
            this.txtDniCuitCliente.Size = new System.Drawing.Size(98, 20);
            this.txtDniCuitCliente.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "CUIT/DNI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gpMedioPago
            // 
            this.gpMedioPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpMedioPago.Controls.Add(this.btnTransferencia);
            this.gpMedioPago.Controls.Add(this.btnCredito);
            this.gpMedioPago.Controls.Add(this.btnDebito);
            this.gpMedioPago.Controls.Add(this.btnEfectivo);
            this.gpMedioPago.Location = new System.Drawing.Point(613, 100);
            this.gpMedioPago.Name = "gpMedioPago";
            this.gpMedioPago.Size = new System.Drawing.Size(270, 58);
            this.gpMedioPago.TabIndex = 4;
            this.gpMedioPago.TabStop = false;
            this.gpMedioPago.Text = "Medio De Pago";
            // 
            // btnTransferencia
            // 
            this.btnTransferencia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTransferencia.AutoSize = true;
            this.btnTransferencia.Location = new System.Drawing.Point(184, 24);
            this.btnTransferencia.Name = "btnTransferencia";
            this.btnTransferencia.Size = new System.Drawing.Size(90, 17);
            this.btnTransferencia.TabIndex = 3;
            this.btnTransferencia.TabStop = true;
            this.btnTransferencia.Text = "Transferencia";
            this.btnTransferencia.UseVisualStyleBackColor = true;
            // 
            // btnCredito
            // 
            this.btnCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCredito.AutoSize = true;
            this.btnCredito.Location = new System.Drawing.Point(120, 24);
            this.btnCredito.Name = "btnCredito";
            this.btnCredito.Size = new System.Drawing.Size(58, 17);
            this.btnCredito.TabIndex = 2;
            this.btnCredito.TabStop = true;
            this.btnCredito.Text = "Credito";
            this.btnCredito.UseVisualStyleBackColor = true;
            // 
            // btnDebito
            // 
            this.btnDebito.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDebito.AutoSize = true;
            this.btnDebito.Location = new System.Drawing.Point(67, 24);
            this.btnDebito.Name = "btnDebito";
            this.btnDebito.Size = new System.Drawing.Size(56, 17);
            this.btnDebito.TabIndex = 1;
            this.btnDebito.TabStop = true;
            this.btnDebito.Text = "Debito";
            this.btnDebito.UseVisualStyleBackColor = true;
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEfectivo.AutoSize = true;
            this.btnEfectivo.Location = new System.Drawing.Point(6, 24);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(64, 17);
            this.btnEfectivo.TabIndex = 0;
            this.btnEfectivo.TabStop = true;
            this.btnEfectivo.Text = "Efectivo";
            this.btnEfectivo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEfectivo.UseVisualStyleBackColor = true;
            // 
            // lSubtotal
            // 
            this.lSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lSubtotal.AutoSize = true;
            this.lSubtotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSubtotal.Location = new System.Drawing.Point(610, 219);
            this.lSubtotal.Name = "lSubtotal";
            this.lSubtotal.Size = new System.Drawing.Size(117, 31);
            this.lSubtotal.TabIndex = 5;
            this.lSubtotal.Text = "Subtotal";
            // 
            // lTotal
            // 
            this.lTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lTotal.AutoSize = true;
            this.lTotal.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotal.Location = new System.Drawing.Point(610, 308);
            this.lTotal.Name = "lTotal";
            this.lTotal.Size = new System.Drawing.Size(76, 31);
            this.lTotal.TabIndex = 6;
            this.lTotal.Text = "Total";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(624, 253);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(232, 49);
            this.txtSubtotal.TabIndex = 7;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(624, 342);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(232, 49);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnConfirmarVenta
            // 
            this.btnConfirmarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirmarVenta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarVenta.Location = new System.Drawing.Point(619, 400);
            this.btnConfirmarVenta.Name = "btnConfirmarVenta";
            this.btnConfirmarVenta.Size = new System.Drawing.Size(134, 73);
            this.btnConfirmarVenta.TabIndex = 9;
            this.btnConfirmarVenta.Text = "Confirmar Venta";
            this.btnConfirmarVenta.UseVisualStyleBackColor = false;
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarVenta.BackColor = System.Drawing.Color.Brown;
            this.btnCancelarVenta.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarVenta.Location = new System.Drawing.Point(759, 400);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(127, 73);
            this.btnCancelarVenta.TabIndex = 10;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = false;
            // 
            // gbDescuento
            // 
            this.gbDescuento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDescuento.Controls.Add(this.rbDesc15);
            this.gbDescuento.Controls.Add(this.rbDesc10);
            this.gbDescuento.Controls.Add(this.rbDesc5);
            this.gbDescuento.Location = new System.Drawing.Point(613, 164);
            this.gbDescuento.Name = "gbDescuento";
            this.gbDescuento.Size = new System.Drawing.Size(269, 52);
            this.gbDescuento.TabIndex = 11;
            this.gbDescuento.TabStop = false;
            this.gbDescuento.Text = "Descuento";
            // 
            // rbDesc15
            // 
            this.rbDesc15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDesc15.AutoSize = true;
            this.rbDesc15.Location = new System.Drawing.Point(179, 20);
            this.rbDesc15.Name = "rbDesc15";
            this.rbDesc15.Size = new System.Drawing.Size(45, 17);
            this.rbDesc15.TabIndex = 2;
            this.rbDesc15.TabStop = true;
            this.rbDesc15.Text = "15%";
            this.rbDesc15.UseVisualStyleBackColor = true;
            // 
            // rbDesc10
            // 
            this.rbDesc10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDesc10.AutoSize = true;
            this.rbDesc10.Location = new System.Drawing.Point(99, 20);
            this.rbDesc10.Name = "rbDesc10";
            this.rbDesc10.Size = new System.Drawing.Size(45, 17);
            this.rbDesc10.TabIndex = 1;
            this.rbDesc10.TabStop = true;
            this.rbDesc10.Text = "10%";
            this.rbDesc10.UseVisualStyleBackColor = true;
            // 
            // rbDesc5
            // 
            this.rbDesc5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rbDesc5.AutoSize = true;
            this.rbDesc5.Location = new System.Drawing.Point(7, 20);
            this.rbDesc5.Name = "rbDesc5";
            this.rbDesc5.Size = new System.Drawing.Size(39, 17);
            this.rbDesc5.TabIndex = 0;
            this.rbDesc5.TabStop = true;
            this.rbDesc5.Text = "5%";
            this.rbDesc5.UseVisualStyleBackColor = true;
            this.rbDesc5.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // RazonSociallbl
            // 
            this.RazonSociallbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RazonSociallbl.AutoSize = true;
            this.RazonSociallbl.Location = new System.Drawing.Point(108, 16);
            this.RazonSociallbl.Name = "RazonSociallbl";
            this.RazonSociallbl.Size = new System.Drawing.Size(73, 13);
            this.RazonSociallbl.TabIndex = 2;
            this.RazonSociallbl.Text = "Razon Social:";
            // 
            // CondFiscallbl
            // 
            this.CondFiscallbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CondFiscallbl.AutoSize = true;
            this.CondFiscallbl.Location = new System.Drawing.Point(113, 42);
            this.CondFiscallbl.Name = "CondFiscallbl";
            this.CondFiscallbl.Size = new System.Drawing.Size(65, 13);
            this.CondFiscallbl.TabIndex = 3;
            this.CondFiscallbl.Text = "Cond Fiscal:";
            // 
            // UcVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDescuento);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnConfirmarVenta);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lTotal);
            this.Controls.Add(this.lSubtotal);
            this.Controls.Add(this.gpMedioPago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(179, 90);
            this.Name = "UcVenta";
            this.Size = new System.Drawing.Size(889, 476);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpMedioPago.ResumeLayout(false);
            this.gpMedioPago.PerformLayout();
            this.gbDescuento.ResumeLayout(false);
            this.gbDescuento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDniCuitCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpMedioPago;
        private System.Windows.Forms.RadioButton btnDebito;
        private System.Windows.Forms.RadioButton btnEfectivo;
        private System.Windows.Forms.RadioButton btnTransferencia;
        private System.Windows.Forms.RadioButton btnCredito;
        private System.Windows.Forms.Label lSubtotal;
        private System.Windows.Forms.Label lTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnConfirmarVenta;
        private System.Windows.Forms.Button btnCancelarVenta;
        private System.Windows.Forms.GroupBox gbDescuento;
        private System.Windows.Forms.RadioButton rbDesc10;
        private System.Windows.Forms.RadioButton rbDesc5;
        private System.Windows.Forms.RadioButton rbDesc15;
        private System.Windows.Forms.Label CondFiscallbl;
        private System.Windows.Forms.Label RazonSociallbl;
    }
}
