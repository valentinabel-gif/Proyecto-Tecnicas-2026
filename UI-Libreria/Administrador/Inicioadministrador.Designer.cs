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
            this.button1 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnRol = new System.Windows.Forms.Button();
            this.btnUsuAdmi = new System.Windows.Forms.Button();
            this.btnInicioAdmi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelaAdmiNombre = new System.Windows.Forms.Label();
            this.labelIniAd = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelInicioAdmi = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMenuAd.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuAd
            // 
            this.panelMenuAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.panelMenuAd.Controls.Add(this.pictureBox2);
            this.panelMenuAd.Controls.Add(this.button1);
            this.panelMenuAd.Controls.Add(this.btnCerrar);
            this.panelMenuAd.Controls.Add(this.btnRol);
            this.panelMenuAd.Controls.Add(this.btnUsuAdmi);
            this.panelMenuAd.Controls.Add(this.btnInicioAdmi);
            this.panelMenuAd.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuAd.Location = new System.Drawing.Point(0, 0);
            this.panelMenuAd.Name = "panelMenuAd";
            this.panelMenuAd.Size = new System.Drawing.Size(179, 676);
            this.panelMenuAd.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 78);
            this.button1.TabIndex = 2;
            this.button1.Text = "Categorias";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrar.Location = new System.Drawing.Point(26, 573);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(133, 28);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "Cerrar sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnRol
            // 
            this.btnRol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.btnRol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRol.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnRol.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRol.Location = new System.Drawing.Point(0, 245);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(179, 78);
            this.btnRol.TabIndex = 2;
            this.btnRol.Text = "Roles";
            this.btnRol.UseVisualStyleBackColor = false;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnUsuAdmi
            // 
            this.btnUsuAdmi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(47)))), ((int)(((byte)(90)))));
            this.btnUsuAdmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuAdmi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnUsuAdmi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUsuAdmi.Location = new System.Drawing.Point(0, 167);
            this.btnUsuAdmi.Name = "btnUsuAdmi";
            this.btnUsuAdmi.Size = new System.Drawing.Size(179, 78);
            this.btnUsuAdmi.TabIndex = 2;
            this.btnUsuAdmi.Text = "Usuarios";
            this.btnUsuAdmi.UseVisualStyleBackColor = false;
            this.btnUsuAdmi.Click += new System.EventHandler(this.btnUsuAdmi_Click);
            // 
            // btnInicioAdmi
            // 
            this.btnInicioAdmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicioAdmi.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold);
            this.btnInicioAdmi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInicioAdmi.Location = new System.Drawing.Point(0, 90);
            this.btnInicioAdmi.Name = "btnInicioAdmi";
            this.btnInicioAdmi.Size = new System.Drawing.Size(179, 78);
            this.btnInicioAdmi.TabIndex = 2;
            this.btnInicioAdmi.Text = "Inicio";
            this.btnInicioAdmi.UseVisualStyleBackColor = true;
            this.btnInicioAdmi.Click += new System.EventHandler(this.btnInicioAdmi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(171)))), ((int)(((byte)(225)))));
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelaAdmiNombre);
            this.panel1.Controls.Add(this.labelIniAd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(179, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1185, 90);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(965, 32);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(0, 20);
            this.Date.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(836, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelaAdmiNombre
            // 
            this.labelaAdmiNombre.AutoSize = true;
            this.labelaAdmiNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold);
            this.labelaAdmiNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelaAdmiNombre.Location = new System.Drawing.Point(677, 35);
            this.labelaAdmiNombre.Name = "labelaAdmiNombre";
            this.labelaAdmiNombre.Size = new System.Drawing.Size(144, 25);
            this.labelaAdmiNombre.TabIndex = 2;
            this.labelaAdmiNombre.Text = "Administrador";
            // 
            // labelIniAd
            // 
            this.labelIniAd.AutoSize = true;
            this.labelIniAd.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold);
            this.labelIniAd.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelIniAd.Location = new System.Drawing.Point(15, 25);
            this.labelIniAd.Name = "labelIniAd";
            this.labelIniAd.Size = new System.Drawing.Size(92, 37);
            this.labelIniAd.TabIndex = 2;
            this.labelIniAd.Text = "Inicio";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelInicioAdmi
            // 
            this.panelInicioAdmi.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelInicioAdmi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInicioAdmi.Location = new System.Drawing.Point(179, 90);
            this.panelInicioAdmi.Name = "panelInicioAdmi";
            this.panelInicioAdmi.Size = new System.Drawing.Size(1185, 586);
            this.panelInicioAdmi.TabIndex = 3;
            this.panelInicioAdmi.Paint += new System.Windows.Forms.PaintEventHandler(this.panelInicioAdmi_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI_Libreria.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(-22, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Inicioadministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(234)))));
            this.ClientSize = new System.Drawing.Size(1364, 676);
            this.Controls.Add(this.panelInicioAdmi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenuAd);
            this.Name = "Inicioadministrador";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicioadministrador_Load);
            this.panelMenuAd.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInicioAdmi;
        private System.Windows.Forms.Button btnUsuAdmi;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label labelIniAd;
        private System.Windows.Forms.Label labelaAdmiNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelInicioAdmi;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}