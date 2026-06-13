namespace UI_Libreria.Administrador
{
    partial class FormCrearCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCrearCategoria = new System.Windows.Forms.TextBox();
            this.btcCrearCategoria = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la nueva categoria";
            // 
            // txtCrearCategoria
            // 
            this.txtCrearCategoria.Location = new System.Drawing.Point(131, 140);
            this.txtCrearCategoria.Name = "txtCrearCategoria";
            this.txtCrearCategoria.Size = new System.Drawing.Size(247, 22);
            this.txtCrearCategoria.TabIndex = 1;
            this.txtCrearCategoria.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btcCrearCategoria
            // 
            this.btcCrearCategoria.Location = new System.Drawing.Point(161, 189);
            this.btcCrearCategoria.Name = "btcCrearCategoria";
            this.btcCrearCategoria.Size = new System.Drawing.Size(186, 39);
            this.btcCrearCategoria.TabIndex = 2;
            this.btcCrearCategoria.Text = "Crear Nueva Categoria";
            this.btcCrearCategoria.UseVisualStyleBackColor = true;
            this.btcCrearCategoria.Click += new System.EventHandler(this.btcCrearCategoria_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(209, 234);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 27);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCrearCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 322);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btcCrearCategoria);
            this.Controls.Add(this.txtCrearCategoria);
            this.Controls.Add(this.label1);
            this.Name = "FormCrearCategoria";
            this.Text = "Crear Categoria";
            this.Load += new System.EventHandler(this.FormCrearCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCrearCategoria;
        private System.Windows.Forms.Button btcCrearCategoria;
        private System.Windows.Forms.Button btnCancelar;
    }
}