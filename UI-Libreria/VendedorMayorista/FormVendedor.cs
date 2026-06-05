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
using UI_Libreria.VendedorMayorista;

namespace UI_Libreria
{
    public partial class FormVendedor : Form
    {
        //instancio una unica vez cada user
        UcVenta VistaVenta;
        UcConsultarPrecio VistaConsultarPrecio;
        UcGestionClientes VistaGestionClientes;
        UcInicioVendedor VistaInicio;

        public FormVendedor()
        {
            InitializeComponent();

            VistaVenta = new UcVenta();
            VistaConsultarPrecio = new UcConsultarPrecio();
            VistaGestionClientes = new UcGestionClientes();
            VistaInicio = new UcInicioVendedor();
    
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            AbrirFicha(VistaVenta);
        }

        public void AbrirFicha(UserControl controlHijo)
        {
            InicioPanel.Controls.Clear();
            controlHijo.Dock = DockStyle.Fill;
            InicioPanel.Controls.Add(controlHijo);
            controlHijo.BringToFront();
        }

        private void BtnInicioVenta_Click(object sender, EventArgs e)
        {
            AbrirFicha(VistaInicio);
        }

        private void BtnConsultaPrecio_Click(object sender, EventArgs e)
        {
            AbrirFicha(VistaConsultarPrecio);
        }

        private void BtnGestionClientes_Click(object sender, EventArgs e)
        {
            AbrirFicha(VistaGestionClientes);

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

        private void LimpiarPanel()
        {
            if (this.InicioPanel.Controls.Count > 0)
            {
                this.InicioPanel.Controls.RemoveAt(0);
            }
        }

        private void InicioPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormVendedor_Load(object sender, EventArgs e)
        {
            AbrirFicha(VistaInicio);

        }
    }
}
