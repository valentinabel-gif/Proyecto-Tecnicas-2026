using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Libreria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD
=======

        public void AbrirFicha(UserControl controlHijo)
        {
            // Usamos 'panel1' porque es el nombre del contenedor que pusimos recién
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);

            controlHijo.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(controlHijo);
            this.panel1.Tag = controlHijo;
            controlHijo.BringToFront();
            controlHijo.Show();
        }
>>>>>>> main
    }
}
