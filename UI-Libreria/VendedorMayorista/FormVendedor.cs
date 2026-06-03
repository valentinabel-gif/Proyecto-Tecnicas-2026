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
        public FormVendedor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            AbrirFicha(new UcVenta());
        }

        public void AbrirFicha(UserControl controlHijo)
        {
            // Limpiamos lo que haya en el fondo blanco
            if (this.InicioPanel.Controls.Count > 0)
                this.InicioPanel.Controls.RemoveAt(0);

            // Ajustamos la pantalla de venta al tamaño del fondo
            controlHijo.Dock = DockStyle.Fill;
            this.InicioPanel.Controls.Add(controlHijo);
            this.InicioPanel.Tag = controlHijo;
            controlHijo.BringToFront();
            controlHijo.Show();
        }

        private void BtnInicioVenta_Click(object sender, EventArgs e)
        {

        }

        private void BtnConsultaPrecio_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            MessageBox.Show("El módulo de Consulta de Precios estará disponible pronto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnGestionClientes_Click(object sender, EventArgs e)
        {
            LimpiarPanel();
            MessageBox.Show("El módulo de Gestion de Clientes estará disponible pronto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button6_Click(object sender, EventArgs e)
        {

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

        }
    }
}
