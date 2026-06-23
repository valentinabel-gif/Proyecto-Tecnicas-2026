using BE_Libreria;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class VentaDAL
    {
        private Conexion _conexion = new Conexion();

        public int RegistrarVentaCabecera(Venta venta)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@fecha_venta",
                    venta.FechaVenta),
                _conexion.crearParametro("@subtotal_venta",
                    venta.CalcularSubtotal()),
                _conexion.crearParametro("@total_venta",
                    venta.CalcularTotal()),
                _conexion.crearParametro("@porcentaje_descuento",
                    venta.PorcentajeDescuento),
                _conexion.crearParametro("@id_cliente",
                    venta.Cliente.IdCliente),
                _conexion.crearParametro("@id_usuario",
                    venta.Usuario.IdUsuario)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_InsertarVentaCabecera", parametros);

            if (tabla == null || tabla.Rows.Count == 0)
                throw new Exception(
                    "No se pudo registrar la venta.");

            // El SP devuelve el ID generado con SCOPE_IDENTITY()
            return Convert.ToInt32(tabla.Rows[0]["id_venta_generado"]);
        }

        public void RegistrarDetalleVenta(
            int idVenta, DetalleVenta detalle)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@cantidad_producto",
                    detalle.CantidadProducto),
                _conexion.crearParametro("@precio_unitario",
                    detalle.PrecioUnitario),
                _conexion.crearParametro("@subtotal_detalle",
                    detalle.SubtotalDetalleVenta),
                _conexion.crearParametro("@id_venta",
                    idVenta),
                _conexion.crearParametro("@id_producto",
                    detalle.ProductoItem.IdProducto)
            };

            _conexion.EscribirPorStoreProcedure(
                "sp_InsertarVentaDetalle", parametros);
        }

        public void RegistrarPago(
            int idVenta, double montoTotal, MedioDePago medioPago)
        {
            // Transferencia queda en espera, el resto aprobado
            string estadoPago = medioPago is Transferencia ?
                "En espera" : "Aprobado";

            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@monto_total",
                    montoTotal),
                _conexion.crearParametro("@fecha_pago",
                    DateTime.Now),
                _conexion.crearParametro("@estado_pago",
                    estadoPago),
                _conexion.crearParametro("@id_medio_de_pago",
                    medioPago.IdMedioPago),
                _conexion.crearParametro("@id_venta",
                    idVenta)
            };

            _conexion.EscribirPorStoreProcedure(
                "sp_RegistrarPagoVenta", parametros);
        }

        public void DescontarStockPorVenta(
            List<DetalleVenta> detalles)
        {
            foreach (DetalleVenta detalle in detalles)
            {
                SqlParameter[] parametros = new SqlParameter[]
                {
                    _conexion.crearParametro("@id_producto",
                        detalle.ProductoItem.IdProducto),
                    _conexion.crearParametro("@cantidad",
                        detalle.CantidadProducto)
                };

                _conexion.EscribirPorStoreProcedure(
                    "sp_DescontarStock", parametros);
            }
        }
    }
}
