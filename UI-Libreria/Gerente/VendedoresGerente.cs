using BE_Libreria.Ventas;
using BLL_Libreria.Seguridad_y_Usuario___Login;
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
    public partial class VendedoresGerente : UserControl
    {
        private VendedorBLL _bll = new VendedorBLL();
        public VendedoresGerente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            if (string.IsNullOrEmpty(busqueda))
            {
                MessageBox.Show("Ingrese nombre del vendedor a buscar.");
                return;
            }

            List<Vendedor> vendedores = _bll.BuscarVendedor(busqueda);

            if (vendedores.Count == 0)
            {
                MessageBox.Show("No se encontraron vendedores con ese nombre.");
                return;
            }

            // Si hay uno solo, cargás las métricas directo
            // Si hay varios, mostrás la lista y el usuario elige
            Vendedor metrica = _bll.TraerEstadisticas(vendedores[0].IdUsuario);

            dataGridView1.DataSource = new List<Vendedor> { metrica };
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VendedoresGerente_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}
