using BE_Libreria;
using BLL_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace UI_Libreria.VendedorMayorista
{
    public partial class UcConsultarPrecio : UserControl
    {
        private BindingSource bsProductos = new BindingSource();
        private ProductoBLL _productoBLL = new ProductoBLL();
        public UcConsultarPrecio()
        {
            InitializeComponent();
        }

        private void UcConsultarPrecio_Load(object sender, EventArgs e)
        {
            dgvProductos.ReadOnly = true;
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.MultiSelect = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string valor = txtBusqueda.Text.Trim();

            if (valor.Length < 2)
            {
                dgvProductos.DataSource = null;
                return;
            }

            BuscarProductos(valor);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool EsSoloNumeros(string valor)
        {
            foreach (char c in valor)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }

        private void BuscarProductos(string valor)
        {
            try
            {
                List<Producto> resultados = new List<Producto>();

                if (EsSoloNumeros(valor))
                {
                    try
                    {
                        Producto porCodigo = _productoBLL
                            .BuscarPorCodigoBarra(valor);
                        if (porCodigo != null)
                            resultados.Add(porCodigo);
                    }
                    catch { }

                    if (resultados.Count == 0)
                        resultados = _productoBLL.BuscarPorNombre(valor);
                }
                else
                {
                    resultados = _productoBLL.BuscarPorNombre(valor);
                }

                DataTable tabla = new DataTable();
                tabla.Columns.Add("Código");
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Categoría");
                tabla.Columns.Add("Precio Venta");
                tabla.Columns.Add("Precio Lista");
                tabla.Columns.Add("Stock");

                foreach (Producto p in resultados)
                {
                    tabla.Rows.Add(
                        p.CodigoBarra,
                        p.NombreProducto,
                        p.Categoria.NombreCategoria,
                        p.ValorVenta.ToString("N2"),
                        p.ValorLista.ToString("N2"),
                        p.Stock
                    );
                }

                dgvProductos.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
