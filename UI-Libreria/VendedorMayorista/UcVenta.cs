using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE_Libreria;
using BLL_Libreria;

namespace UI_Libreria.VendedorMayorista
{
    public partial class UcVenta : UserControl
    {
        private VentaBLL _ventaBLL = new VentaBLL();
        private ProductoBLL _productoBLL = new ProductoBLL();
        private ClienteBLL _clienteBLL = new ClienteBLL();

        private Venta _ventaActual;
        private MedioDePago _medioPagoSeleccionado;

        public UcVenta()
        {
            InitializeComponent();
        }

        private void UcVenta_Load(object sender, EventArgs e)
        {
            IniciarNuevaVenta();
        }

        // ─── INICIAR VENTA ───

        private void IniciarNuevaVenta()
        {

            dgvDetalle.ReadOnly = true;
            dgvDetalle.AllowUserToAddRows = false;
            //creamos una venta nueva con el usuario de la sesion activa
            _ventaActual = new Venta(0, DateTime.Now, null, Sesion.Instancia.UsuarioActivo, null);

            _medioPagoSeleccionado = null;

            //limpiamos la interfaz
            dgvDetalle.Rows.Clear();
            txtBusqueda.Clear();
            txtDniCuitCliente.Clear();
            RazonSociallbl.Text = "";
            CondFiscallbl.Text = "";
            txtSubtotal.Text = "0.00";
            txtTotal.Text = "0.00";

            //desmarcar radios
            btnEfectivo.Checked = false;
            btnDebito.Checked = false;
            btnCredito.Checked = false;
            btnTransferencia.Checked = false;
            rbDesc5.Checked = false;
            rbDesc10.Checked = false;
            rbDesc15.Checked = false;

            txtBusqueda.Focus();
        }

        // ─── BUSCAR PRODUCTO ───

        private void txtBusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarYAgregarProducto();
            }
        }

        private void BuscarYAgregarProducto()
        {
            string valor = txtBusqueda.Text.Trim();
            if (string.IsNullOrWhiteSpace(valor))
            {
                return;
            }

            try
            {
                Producto producto = null;

                //primero por cod de barras
                try
                {
                    producto = _productoBLL.BuscarPorCodigoBarra(valor);
                }
                catch { }

                //si no encuentro por codigo busco por nombre
                if (producto == null)
                {
                    List<Producto> coincidencias =
                        _productoBLL.BuscarPorNombre(valor);

                    if (coincidencias.Count == 0)
                    {
                        MessageBox.Show("No se encontró ningún producto.", "Producto no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtBusqueda.Clear();
                        return;
                    }
                    else if (coincidencias.Count == 1)
                    {
                        producto = coincidencias[0];
                    }
                    else
                    {
                        //multiples coincidencias, el vendedor elige
                        //por ahora tomamos el primero
                        //TODO: mostrar lista para seleccionar
                        producto = coincidencias[0];
                    }
                }

                // Pedir cantidad
                string inputCantidad = Microsoft.VisualBasic.Interaction.InputBox($"Ingrese la cantidad para:\n{producto.NombreProducto}" + $"\nStock disponible: {producto.Stock}","Cantidad", "1");

                if (string.IsNullOrWhiteSpace(inputCantidad))
                {
                    return;
                }

                if (!int.TryParse(inputCantidad, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.");
                    return;
                }

                // FA1 — verificar stock
                if (producto.Stock < cantidad)
                {
                    MessageBox.Show(
                        $"Stock insuficiente.\n" +
                        $"Stock actual: {producto.Stock} unidades.",
                        "Stock insuficiente",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                //crear detalle y agregar a la venta
                DetalleVenta detalle = _ventaBLL.CrearDetalle(producto, cantidad);
                _ventaActual.AgregarDetalle(detalle);

                // Agregar a la grilla
                dgvDetalle.Rows.Add(cantidad, producto.NombreProducto,detalle.SubtotalDetalleVenta.ToString("N2"));

                ActualizarTotales();
                txtBusqueda.Clear();
                txtBusqueda.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── BUSCAR CLIENTE ───

        private void txtDniCuitCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BuscarCliente();
            }
        }

        private void BuscarCliente()
        {
            string valor = txtDniCuitCliente.Text.Trim();
            if (string.IsNullOrWhiteSpace(valor))
            {
                return;
            }

            try
            {
                Cliente cliente = _clienteBLL.BuscarPorDniOCuit(valor);

                if (cliente != null)
                {
                    _ventaActual.Cliente = cliente;

                    RazonSociallbl.Text = cliente.RazonSocial ?? cliente.NombreCliente + " " + cliente.ApellidoCliente;
                    CondFiscallbl.Text = cliente.CondicionFiscal;
                }
                else
                {
                    //cliente no registrado
                    DialogResult resultado = MessageBox.Show("Cliente no encontrado. ¿Desea registrarlo?", "Cliente no registrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        // Abrir gestión de clientes para alta
                        UcGestionClientes ucAlta = new UcGestionClientes();
                        //integrar con el FormVendedor
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── MEDIO DE PAGO ───

        private void btnEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (btnEfectivo.Checked)
            {
                _medioPagoSeleccionado = new Efectivo(1, "Efectivo", 0);
                _ventaActual.MedioPago = _medioPagoSeleccionado;
                ActualizarTotales();
            }
        }

        private void btnDebito_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCredito_CheckedChanged(object sender, EventArgs e)
        {
            if (btnCredito.Checked)
            {
                _medioPagoSeleccionado = new TarjetaCredito(3, "Crédito", TarjetaCredito.PORCENTAJE_RECARGO_DEFAULT);
                _ventaActual.MedioPago = _medioPagoSeleccionado;
                ActualizarTotales();
            }
        }

        private void btnTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (btnTransferencia.Checked)
            {
                _medioPagoSeleccionado = new Transferencia(4, "Transferencia", 0);
                _ventaActual.MedioPago = _medioPagoSeleccionado;
                ActualizarTotales();
            }
        }

        // ─── DESCUENTO ───

        private void rbDesc5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesc5.Checked)
            {
                _ventaActual.PorcentajeDescuento = 5;
                ActualizarTotales();
            }
        }

        private void rbDesc10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesc10.Checked)
            {
                _ventaActual.PorcentajeDescuento = 10;
                ActualizarTotales();
            }
        }

        private void rbDesc15_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDesc15.Checked)
            {
                _ventaActual.PorcentajeDescuento = 15;
                ActualizarTotales();
            }
        }

        // ─── CALCULAR TOTALES ───

        private void ActualizarTotales()
        {
            double subtotal = _ventaBLL.ObtenerSubtotal(_ventaActual);
            txtSubtotal.Text = subtotal.ToString("N2");

            // Solo calcula total si hay medio de pago seleccionado
            if (_ventaActual.MedioPago != null)
            {
                double total = _ventaBLL.ObtenerTotal(_ventaActual);
                txtTotal.Text = total.ToString("N2");
            }
            else
            {
                txtTotal.Text = subtotal.ToString("N2");
            }
        }

        // ─── CONFIRMAR VENTA ───

        private void btnConfirmarVenta_Click_1(object sender, EventArgs e)
        {
            if (dgvDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Operación rechazada: No hay ningún producto cargado en la grilla.", "Faltan Productos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ventaActual.Cliente == null || string.IsNullOrWhiteSpace(RazonSociallbl.Text))
            {
                MessageBox.Show("Operación rechazada: Debe ingresar el DNI/CUIT de un cliente válido y presionar ENTER.", "Falta Asociar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDniCuitCliente.Focus();
                return;
            }

            if (_ventaActual.MedioPago == null || _medioPagoSeleccionado == null)
            {
                MessageBox.Show("Operación rechazada: Debe seleccionar obligatoriamente un Medio de Pago (Efectivo, Débito, Crédito o Transferencia).", "Falta Medio de Pago", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
               int idVentaGenerado = _ventaBLL.RegistrarVenta(_ventaActual);

                //cuadrito de dialogo interactivo con botones Si/No
                DialogResult respuestaImpresion = MessageBox.Show("¡Venta registrada con éxito en el sistema!\n\n¿Desea generar e imprimir el ticket de comprobante para el cliente?", "Emisión de Comprobante - Librería Canning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //si el vendedor presiona "Si", generamos la cadena de texto plano armada en tu BLL
                if (respuestaImpresion == DialogResult.Yes)
                {
                    string ticketFormateado = _ventaBLL.GenerarTextoTicket(_ventaActual, idVentaGenerado);

                    //despliego el ticket en un MessageBox limpio simulando la salida fisica de la ticketera
                    MessageBox.Show(ticketFormateado, $"Comprobante Emitido - Ticket Nro: {idVentaGenerado.ToString("D8")}", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                //limpio la grilla y los controles para la proxia venta
                IniciarNuevaVenta();
            }
            catch (Exception ex)
            {
                //si salta stock insuficiente o falta un medio de pago frena aca
                MessageBox.Show($"No se pudo concretar la operación comercial:\n\n{ex.Message}", "Validación de Negocio Rechazada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // ─── CANCELAR VENTA ───

        private void btnCancelarVenta_Click_1(object sender, EventArgs e)
        {
            //cancelacion con confirmacion
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea cancelar la venta?\n" + "Se perderán todos los datos ingresados.", "Cancelar venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                _ventaBLL.CancelarVenta(_ventaActual);
                IniciarNuevaVenta();
            }
        }

        private void label2_Click(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(
            object sender, EventArgs e)
        { }
        private void txtBusqueda_TextChanged(
            object sender, EventArgs e)
        { }
    }
}
