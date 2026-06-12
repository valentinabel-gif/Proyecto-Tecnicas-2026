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

namespace UI_Libreria.VendedorMayorista
{
    public partial class UcConsultarPrecio : UserControl
    {
        private BindingSource bsProductos = new BindingSource();
        //private ProductoBLL _productoBLL = new ProductoBLL();
        public UcConsultarPrecio()
        {
            InitializeComponent();
        }

        private void UcConsultarPrecio_Load(object sender, EventArgs e)
        {
            try
            {
                //comento los bll porque todavia no tengo productoBLL
                //bsProductos.DataSource = _productoBLL.ObtenerTodos();
                dgvProductos.DataSource = bsProductos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}");
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBusqueda.Text))
            {
                bsProductos.RemoveFilter();
            }
            else
            {
                bsProductos.Filter = $"NombreProducto LIKE '%{txtBusqueda.Text}%' OR CodigoBarra LIKE '%{txtBusqueda.Text}%'";
            }
        }
    }
}
