using BE_Libreria.Ventas;
using BLL_Libreria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Libreria.Gerente
{
    public partial class VentaGerente : UserControl
    {
        private EstadisticasGerenteBLL _estadisticasBLL = new EstadisticasGerenteBLL();
        public VentaGerente()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionada = FechaIngreso.Value;

                if (fechaSeleccionada.Year > DateTime.Now.Year || (fechaSeleccionada.Year == DateTime.Now.Year && fechaSeleccionada.Month > DateTime.Now.Month))
                {
                    MessageBox.Show("Consulte una fecha anterior a la fecha actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Ingresos.Text = "$0";
                    IngresosMesAnterior.Text = "$0";
                    gridVENTAS.DataSource = null;
                    return;
                }
                int mesActual = FechaIngreso.Value.Month;
                int anioActual = FechaIngreso.Value.Year;

                // Mes anterior (manejando el cambio de año si es enero)
                DateTime fechaMesAnterior = FechaIngreso.Value.AddMonths(-1);
                int mesAnterior = fechaMesAnterior.Month;
                int anioMesAnterior = fechaMesAnterior.Year;

                double totalEsteMes = _estadisticasBLL.IngresosPorMes(mesActual, anioActual);
                double totalMesAnterior = _estadisticasBLL.IngresosPorMes(mesAnterior, anioMesAnterior);

                Ingresos.Text = "$" + totalEsteMes.ToString("N0");
                IngresosMesAnterior.Text = "$" + totalMesAnterior.ToString("N0");

                CargarVentas(mesActual, anioActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarVentas(int mes, int anio)
        {
            List<ResumenVentas> ventas = _estadisticasBLL.ObtenerVentasPorMes(mes, anio);

            gridVENTAS.AutoGenerateColumns = false;
            gridVENTAS.Columns.Clear();

            gridVENTAS.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Fecha", DataPropertyName = "FechaVenta", Width = 100 });
            gridVENTAS.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Cliente", DataPropertyName = "Cliente", Width = 150 });
            gridVENTAS.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Total", DataPropertyName = "TotalVenta", Width = 100 });

            gridVENTAS.DataSource = ventas;
        }


        public void DatosMesActual()
        {
            try
            {
                FechaIngreso.Value = DateTime.Now;
                FechaEgreso.Value = DateTime.Now;

                int mesActual = DateTime.Now.Month;
                int anioActual = DateTime.Now.Year;

                DateTime fechsMesAnterior = DateTime.Now.AddMonths(-1);
                int mesAnterior = fechsMesAnterior.Month;
                int anioMesAnterios = fechsMesAnterior.Year;

                //ingresos
                double IngresosEsteMes = _estadisticasBLL.IngresosPorMes(mesActual, anioActual);
                double IngresosAnterior = _estadisticasBLL.IngresosPorMes(mesAnterior, anioMesAnterios);
                Ingresos.Text = "$" + IngresosEsteMes.ToString("N0");
                IngresosMesAnterior.Text = "$" + IngresosAnterior.ToString("N0");

                //EGRESOSO
                double EgresosEsteMes = _estadisticasBLL.EgresosPorMes(mesActual, anioActual);
                double EgresosAnterior = _estadisticasBLL.EgresosPorMes(mesAnterior, anioMesAnterios);
                Egresos.Text = "$" + IngresosEsteMes.ToString("N0");
                EgresosMesAnterior.Text = "$" + IngresosAnterior.ToString("N0");

                //Vnetas del mes
                CargarVentas(mesActual, anioActual);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VentaGerente_Load(object sender, EventArgs e)
        {
            DatosMesActual();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaSeleccionadaEgreso = FechaEgreso.Value;

                if (fechaSeleccionadaEgreso.Year > DateTime.Now.Year || (fechaSeleccionadaEgreso.Year == DateTime.Now.Year && fechaSeleccionadaEgreso.Month > DateTime.Now.Month))
                {
                    MessageBox.Show("Consulte una fecha anterior a la fecha actual.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    Egresos.Text = "$0";
                    EgresosMesAnterior.Text = "$0";
                    return;
                }

                int mesActual = FechaEgreso.Value.Month;
                int anioActual = FechaEgreso.Value.Year;

                DateTime fechaMesAnterior = FechaEgreso.Value.AddMonths(-1);
                int mesAnterior = fechaMesAnterior.Month;
                int anioMesAnterior = fechaMesAnterior.Year;

                double totalEsteMes = _estadisticasBLL.EgresosPorMes(mesActual, anioActual);
                double totalMesAnterior = _estadisticasBLL.EgresosPorMes(mesAnterior, anioMesAnterior);

                Egresos.Text = "$" + totalEsteMes.ToString("N0");
                EgresosMesAnterior.Text = "$" + totalMesAnterior.ToString("N0");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
