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

namespace UI_Libreria.Gerente
{
    public partial class inicioGerente : Form
    {

        //declaro user control

        InicioGeren VistaInicioGerente;
        ProductosGerente VistaProductos;
        ProveedorGerente VistaProveedores;
        VentaGerente VistaVenta;
        VendedoresGerente VistaVendedores;

        public inicioGerente()
        {
            InitializeComponent();
            Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            VistaInicioGerente = new InicioGeren();
            VistaProductos = new ProductosGerente();
            VistaProveedores = new ProveedorGerente();
            VistaVenta = new VentaGerente();
            VistaVendedores = new VendedoresGerente();

        }
        private void AbrirUserControl(UserControl uc)
        {
            panelInicioGerente.Controls.Clear();

            uc.Dock = DockStyle.Fill;

            panelInicioGerente.Controls.Add(uc);

            uc.BringToFront();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void inicioGerente_Load(object sender, EventArgs e)
        {

        }

        private void panelInicioGerente_Paint(object sender, PaintEventArgs e)
        {
      
        }

        private void btnInicioGerente_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaInicioGerente);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaProductos);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaProveedores);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaVenta);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaVendedores);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cerrar sesión?", "Cerrar sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
