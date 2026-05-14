using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Libreria.Administrador
{
    public partial class Inicioadministrador : Form
    {

        //declaro userControls

        admiInicio VistaInicioAdmi;
        admiUsuario VistaUsuarioAdmi;
        admiRol VistaRolAdmi;
        admiPermisos VistaPermisoAdmi;
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
            VistaPermisoAdmi = new admiPermisos();
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

        private void btnPermisos_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaPermisoAdmi);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaCategoriaAdmi);
        }
    }
}
