using BE_Libreria;
using BLL_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI_Libreria.Gerente
{
    public partial class ProveedorGerente : UserControl
    {
        private ProveedorBLL _proveedorBLL = new ProveedorBLL();
        private ProductoBLL _productoBLL = new ProductoBLL();
        private List<Proveedor> _listaProveedores = new List<Proveedor>();

        public ProveedorGerente()
        {
            InitializeComponent();
        }

        private void ProveedorGerente_Load(object sender, EventArgs e)
        {
            CargarListaProveedores();

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Proveedor proveedor = (Proveedor)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            int idProveedor = proveedor.IdProveedor;

            // Modificar
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colModificar")
            {
                FormModificarProveedor frm = new FormModificarProveedor(idProveedor, _proveedorBLL);
                frm.FormClosed += (s, args) => CargarListaProveedores();
                frm.ShowDialog();
            }

            // Dar de baja
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEliminar")
            {
                string nombre = proveedor.NombreProveedor;

                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea eliminar a {nombre}?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        _proveedorBLL.EliminarProveedor(idProveedor);
                        MessageBox.Show("Proveedor dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarListaProveedores();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            // Ver lista de productos
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colVerProductos")
            {
                List<Producto> productos = _productoBLL.ObtenerProductosPorProveedor(idProveedor);
                FormProductosProveedor frm = new FormProductosProveedor(productos);
                frm.ShowDialog();
            }

            // Consultar precios
            if (dataGridView1.Columns[e.ColumnIndex].Name == "colConsultarPrecios")
            {
                List<Producto> precios = _productoBLL.ObtenerPreciosPorProveedor(idProveedor);
                FormPreciosProveedor frm = new FormPreciosProveedor(precios);
                frm.ShowDialog();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CargarListaProveedores()
        {
            dataGridView1.AutoGenerateColumns = false;
            _listaProveedores = _proveedorBLL.BuscarProveedores(""); // o un método que traiga todos
            dataGridView1.DataSource = new List<Proveedor>(_listaProveedores);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                dataGridView1.DataSource = new List<Proveedor>(_listaProveedores);
                return;
            }

            List<Proveedor> filtrados = _listaProveedores
                .Where(p => p.NombreProveedor.ToLower().Contains(textoBusqueda) ||
                            p.CuitProveedor.ToLower().Contains(textoBusqueda))
                .ToList();

            dataGridView1.DataSource = filtrados;
        }
    }
}
