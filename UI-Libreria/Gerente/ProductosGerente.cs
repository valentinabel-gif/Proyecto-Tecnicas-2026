using BE_Libreria;
using BE_Libreria.Stock;
using BLL_Libreria;
using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Helpers;

namespace UI_Libreria.Gerente
{
    public partial class ProductosGerente : UserControl
    {
        private ReporteBLL _reporteBLL = new ReporteBLL();
        public ProductosGerente()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProductosGerente_Load(object sender, EventArgs e)
        {
            CargarGrilla("");
            List<Producto> alertas = _reporteBLL.ObtenerAlertaStockBajo(10);
            if (alertas.Count > 0)
            {
                btnAlerta.BackColor = System.Drawing.Color.Red;
                btnAlerta.ForeColor = System.Drawing.Color.White;
                btnAlerta.TextAlign= ContentAlignment.MiddleCenter;
                btnAlerta.Text = "⚠ Ver Alerta de Mercadería Faltante ("
                   + alertas.Count + ")";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla(txtBuscar.Text.Trim());
        }

        private void CargarGrilla(string criterio)
        {
            try
            {
                List<Producto> productos =
                    _reporteBLL.BuscarProductosParaReporte(criterio);
             
                dgvProductos.DataSource = null;
                dgvProductos.DataSource = productos;
                dgvProductos.Columns["Categoria"].Visible = false;
                dgvProductos.Columns["IdProducto"].HeaderText = "ID";
                dgvProductos.Columns["NombreProducto"].HeaderText = "Producto";
                dgvProductos.Columns["NombreCategoria"].HeaderText = "Categoría";
                dgvProductos.Columns["Stock"].HeaderText = "Cantidad";

                dgvProductos.Columns["ValorVenta"].Visible = false;
                dgvProductos.Columns["ValorLista"].Visible = false;
                dgvProductos.Columns["CodigoBarra"].Visible = false;
                dgvProductos.Columns["DescripcionProducto"].Visible = false;

                if (!dgvProductos.Columns.Contains("chkReporte"))
                {
                    DataGridViewCheckBoxColumn col =
                        new DataGridViewCheckBoxColumn();
                    col.Name = "chkReporte";
                    col.HeaderText = "Generar Reporte";
                    col.Width = 110;
                    col.DisplayIndex = 5;
                    dgvProductos.Columns.Add(col);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> ids = new List<int>();

                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    if (fila.IsNewRow) continue;
                    bool marcado = Convert.ToBoolean(
                        fila.Cells["chkReporte"].Value);
                    if (marcado)
                        ids.Add(Convert.ToInt32(
                            fila.Cells["IdProducto"].Value));
                }

                List<ReporteProducto> datos =
                    _reporteBLL.ObtenerReporte(ids);

                // Configuración obligatoria de QuestPDF
                QuestPDF.Settings.License = LicenseType.Community;

                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PDF|*.pdf";
                dlg.FileName = "Reporte_Ventas_" +
                    DateTime.Now.ToString("yyyyMMdd_HHmm") + ".pdf";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Document.Create(container =>
                    {
                        container.Page(page =>
                        {
                            page.Size(PageSizes.A4);
                            page.Margin(1, Unit.Centimetre);
                            page.DefaultTextStyle(x => x.FontSize(10));

                            // Encabezado
                            page.Header().Column(col =>
                            {
                                col.Item().Text("Librería Borcelle")
                                    .FontSize(18).Bold()
                                    .FontColor(Colors.Blue.Darken3);
                                col.Item().Text("Reporte de ventas por producto")
                                    .FontSize(12)
                                    .FontColor(Colors.Grey.Darken1);
                                col.Item().Text(
                                    "Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
                                    .FontSize(9)
                                    .FontColor(Colors.Grey.Medium);
                                col.Item().PaddingTop(5).LineHorizontal(1)
                                    .LineColor(Colors.Blue.Darken3);
                            });

                            // Contenido — tabla
                            page.Content().PaddingTop(10).Table(tabla =>
                            {
                                // Definir columnas
                                tabla.ColumnsDefinition(cols =>
                                {
                                    cols.ConstantColumn(30);  // ID
                                    cols.RelativeColumn(3);   // Producto
                                    cols.RelativeColumn(2);   // Categoría
                                    cols.RelativeColumn(1);   // Vendido
                                    cols.RelativeColumn(2);   // Ingresos
                                    cols.RelativeColumn(1);   // Rentab.
                                    cols.RelativeColumn(1);   // Stock
                                });

                                // Encabezados de la tabla
                                tabla.Header(header =>
                                {
                                    string[] titulos = new string[]
                                    {
                                "ID", "Producto", "Categoría",
                                "Vendido", "Ingresos", "Rentab. %", "Stock"
                                    };

                                    foreach (string titulo in titulos)
                                    {
                                        header.Cell().Background(Colors.Blue.Darken3)
                                            .Padding(5)
                                            .Text(titulo)
                                            .FontColor(Colors.White)
                                            .Bold();
                                    }
                                });

                                // Filas de datos
                                bool filaPar = false;
                                foreach (ReporteProducto item in datos)
                                {
                                    string fondo = filaPar ?
                                        Colors.Grey.Lighten4 : Colors.White;
                                    filaPar = !filaPar;

                                    tabla.Cell().Background(fondo).Padding(5)
                                        .Text(item.IdProducto.ToString());
                                    tabla.Cell().Background(fondo).Padding(5)
                                        .Text(item.NombreProducto);
                                    tabla.Cell().Background(fondo).Padding(5)
                                        .Text(item.NombreCategoria);
                                    tabla.Cell().Background(fondo).Padding(5)
                                        .Text(item.TotalVendido.ToString());
                                    tabla.Cell().Background(fondo).Padding(5)
                                        .Text("$" + item.Ingresos.ToString("N2"));
                                    tabla.Cell().Background(fondo).Padding(5)
                                        .Text(item.Rentabilidad.ToString("N2") + "%");
                                    tabla.Cell().Background(fondo).Padding(5)
                                        .Text(item.StockActual.ToString());
                                }
                            });

                            // Pie de página
                            page.Footer().AlignCenter()
                                .Text(txt =>
                                {
                                    txt.Span("Página ");
                                    txt.CurrentPageNumber();
                                    txt.Span(" de ");
                                    txt.TotalPages();
                                });
                        });
                    }).GeneratePdf(dlg.FileName);

                    MessageBox.Show("Reporte generado correctamente.",
                        "Listo", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                List<Producto> productos = _reporteBLL.ObtenerAlertaStockBajo(10);

                if (productos.Count == 0)
                {
                    MessageBox.Show("No hay productos con stock bajo.",
                        "Sin alertas", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                string mensaje = "Productos con stock menor a 10 unidades:\n\n";
                foreach (Producto p in productos)
                    mensaje += "• " + p.NombreProducto +
                               " — Stock actual: " + p.Stock + "\n";

                MessageBox.Show(mensaje,
                    "⚠ Alerta de mercadería faltante",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
