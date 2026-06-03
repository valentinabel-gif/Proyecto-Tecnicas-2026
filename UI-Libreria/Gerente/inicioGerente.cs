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
        FinanzaGerente VistaFinanza;
        VendedoresGerente VistaVendedores;

        public inicioGerente()
        {
            InitializeComponent();
            Date.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            VistaInicioGerente = new InicioGeren();
            VistaProductos = new ProductosGerente();
            VistaProveedores = new ProveedorGerente();
            VistaFinanza = new FinanzaGerente();
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
            AbrirUserControl(VistaFinanza);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirUserControl(VistaVendedores);
        }
    }
}
