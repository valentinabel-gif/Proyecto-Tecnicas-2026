using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Libreria;
using BE_Libreria;
using UI_Libreria.Administrador;

namespace UI_Libreria
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


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

        private void labelNombreLo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = txtUsuario.Text;
            string contraseñaIngresada = txtContraseña.Text;
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            Usuario usuarioLogeado = usuarioBLL.RecuperarUsuarioPorCredenciales(usuarioIngresado, contraseñaIngresada);
            Sesion.Instancia.RegistrarSesion(usuarioLogeado);
            if (Sesion.Instancia.HaySesionActiva())
            {

            }
        }
    }
}
