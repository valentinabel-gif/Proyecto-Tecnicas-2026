namespace UI_Libreria.Administrador
{
    partial class Inicioadministrador
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicioadministrador));
            this.panelMenuAd = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInicioAdmi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelaAdmiNombre = new System.Windows.Forms.Label();
            this.labelIniAd = new System.Windows.Forms.Label();
            this.btnUsuAdmi = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.btnPermisos = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelInicioAdmi = new System.Windows.Forms.Panel();
            this.panelMenuAd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuAd
            // 
            this.panelMenuAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.panelMenuAd.Controls.Add(this.btnCerrar);
            this.panelMenuAd.Controls.Add(this.button1);
            this.panelMenuAd.Controls.Add(this.btnInicioAdmi);
            this.panelMenuAd.Controls.Add(this.label1);
            this.panelMenuAd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuAd.Location = new System.Drawing.Point(0, 0);
            this.panelMenuAd.Name = "panelMenuAd";
            this.panelMenuAd.Size = new System.Drawing.Size(178, 450);
            this.panelMenuAd.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(23, 395);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(133, 28);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "Categorias";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInicioAdmi
            // 
            this.btnInicioAdmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioAdmi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnInicioAdmi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicioAdmi.Location = new System.Drawing.Point(0, 67);
            this.btnInicioAdmi.Name = "btnInicioAdmi";
            this.btnInicioAdmi.Size = new System.Drawing.Size(178, 60);
            this.btnInicioAdmi.TabIndex = 2;
            this.btnInicioAdmi.Text = "Inicio";
            this.btnInicioAdmi.UseVisualStyleBackColor = true;
            this.btnInicioAdmi.Click += new System.EventHandler(this.btnInicioAdmi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(8, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Libreria Mayorista";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelaAdmiNombre);
            this.panel1.Controls.Add(this.labelIniAd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(178, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 70);
            this.panel1.TabIndex = 1;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.Date.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Date.Location = new System.Drawing.Point(445, 28);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 20);
            this.Date.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelaAdmiNombre
            // 
            this.labelaAdmiNombre.AutoSize = true;
            this.labelaAdmiNombre.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.labelaAdmiNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelaAdmiNombre.Location = new System.Drawing.Point(243, 27);
            this.labelaAdmiNombre.Name = "labelaAdmiNombre";
            this.labelaAdmiNombre.Size = new System.Drawing.Size(114, 20);
            this.labelaAdmiNombre.TabIndex = 2;
            this.labelaAdmiNombre.Text = "Administrador";
            // 
            // labelIniAd
            // 
            this.labelIniAd.AutoSize = true;
            this.labelIniAd.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelIniAd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIniAd.Location = new System.Drawing.Point(15, 22);
            this.labelIniAd.Name = "labelIniAd";
            this.labelIniAd.Size = new System.Drawing.Size(61, 25);
            this.labelIniAd.TabIndex = 2;
            this.labelIniAd.Text = "Inicio";
            // 
            // btnUsuAdmi
            // 
            this.btnUsuAdmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.btnUsuAdmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuAdmi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnUsuAdmi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuAdmi.Location = new System.Drawing.Point(0, 124);
            this.btnUsuAdmi.Name = "btnUsuAdmi";
            this.btnUsuAdmi.Size = new System.Drawing.Size(178, 60);
            this.btnUsuAdmi.TabIndex = 2;
            this.btnUsuAdmi.Text = "Usuarios";
            this.btnUsuAdmi.UseVisualStyleBackColor = false;
            this.btnUsuAdmi.Click += new System.EventHandler(this.btnUsuAdmi_Click);
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRol.Location = new System.Drawing.Point(0, 179);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(178, 60);
            this.btnRol.TabIndex = 2;
            this.btnRol.Text = "Roles";
            this.btnRol.UseVisualStyleBackColor = false;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnPermisos
            // 
            this.btnPermisos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.btnPermisos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermisos.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnPermisos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPermisos.Location = new System.Drawing.Point(0, 236);
            this.btnPermisos.Name = "btnPermisos";
            this.btnPermisos.Size = new System.Drawing.Size(178, 60);
            this.btnPermisos.TabIndex = 2;
            this.btnPermisos.Text = "Permisos";
            this.btnPermisos.UseVisualStyleBackColor = false;
            this.btnPermisos.Click += new System.EventHandler(this.btnPermisos_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelInicioAdmi
            // 
            this.panelInicioAdmi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelInicioAdmi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicioAdmi.Location = new System.Drawing.Point(178, 70);
            this.panelInicioAdmi.Name = "panelInicioAdmi";
            this.panelInicioAdmi.Size = new System.Drawing.Size(622, 380);
            this.panelInicioAdmi.TabIndex = 3;
            // 
            // Inicioadministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelInicioAdmi);
            this.Controls.Add(this.btnPermisos);
            this.Controls.Add(this.btnRol);
            this.Controls.Add(this.btnUsuAdmi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuAd);
            this.Name = "Inicioadministrador";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicioadministrador_Load);
            this.panelMenuAd.ResumeLayout(false);
            this.panelMenuAd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicioAdmi;
        private System.Windows.Forms.Button btnUsuAdmi;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button btnPermisos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label labelIniAd;
        private System.Windows.Forms.Label labelaAdmiNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelInicioAdmi;
    }
}