using BE_Libreria.Ventas;
using BLL_Libreria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Libreria.Gerente
{
    public partial class InicioGeren : UserControl
    {
        private DatosInicioGerenteBLL _datosInicioGerenteBLL = new DatosInicioGerenteBLL();
        public InicioGeren()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InicioGeren_Load(object sender, EventArgs e)
        {
            try
            {
                CargarEstadisticas();
                CargarVentasDelDia();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarEstadisticas()
        {
            VendedorMasVentas.Text = _datosInicioGerenteBLL.ObtenerVendedorConMasVentas();
            StockMinimo.Text = _datosInicioGerenteBLL.ProductosStockMinimo().ToString();
            SinStock.Text = _datosInicioGerenteBLL.ProductosSinStock().ToString();
        }

        private void CargarVentasDelDia()
        {
            List<VentaDelDia> ventas = _datosInicioGerenteBLL.ObtenerVentasDelDia();
            if (ventas.Count == 0)
            {
                MsgNoHayVentas.Visible = true;
                dvgVentasDelDia.Visible = false;
            }
            else
            {
                dvgVentasDelDia.AutoGenerateColumns = false;
                dvgVentasDelDia.Columns.Clear();

                dvgVentasDelDia.Columns.Add(new DataGridViewTextBoxColumn
                { HeaderText = "Vendedor", DataPropertyName = "Vendedor", Width = 150 });
                dvgVentasDelDia.Columns.Add(new DataGridViewTextBoxColumn
                { HeaderText = "Total", DataPropertyName = "TotalVenta", Width = 100 });
                dvgVentasDelDia.Columns.Add(new DataGridViewTextBoxColumn
                { HeaderText = "Fecha", DataPropertyName = "FechaVenta", Width = 120 });

                dvgVentasDelDia.DataSource = ventas;
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
