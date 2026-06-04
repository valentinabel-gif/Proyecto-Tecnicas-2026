using BLL_Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Libreria.EncargadoDeStock;

namespace UI_Libreria.Administrador
{
    public partial class Inicioadministrador : Form
    {

        //declaro userControls

        admiInicio VistaInicioAdmi;
        admiUsuario VistaUsuarioAdmi;
        admiRol VistaRolAdmi;

        admiCategoria VistaCategoriaAdmi;
        public Inicioadministrador()
        {
            InitializeComponent();
            //Fecha del inicio
            Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            //creamos solo una vez los userControl

            VistaInicioAdmi = new admiInicio();
            VistaUsuarioAdmi = new admiUsuario();
            VistaRolAdmi = new admiRol();
            VistaCategoriaAdmi = new admiCategoria();

            //Cuando abre el formm, simpre muestra el de inicio
            AbrirUserControl(VistaInicioAdmi);
        }

        private void AbrirUserControl(UserControl uc)
        {
            panelInicioAdmi.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            panelInicioAdmi.Controls.Add(uc);

            uc.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void Inicioadministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnInicioAdmi_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaInicioAdmi);
        }

        private void btnUsuAdmi_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaUsuarioAdmi);
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaRolAdmi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaCategoriaAdmi);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelInicioAdmi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
           "¿Está seguro que desea cerrar sesión?", "Cerrar sesión",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Sesion.Instancia.CerrarSesion(); // Singleton limpia la sesión
                login loginForm = new login();  // abrís el form de login
                loginForm.Show();
                this.Close();
            }
        }
    }
}
