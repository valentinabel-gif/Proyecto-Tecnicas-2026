using BE_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Libreria;

namespace BLL_Libreria
{
    public class VentaBLL
    {
        private VentaDAL _ventaDAL = new VentaDAL();

        //registrar venta

        public int RegistrarVenta(Venta venta)
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            if (venta == null)
            {
                throw new ArgumentNullException("La venta no puede ser nula.");
            }

            if (venta.Detalles == null || venta.Detalles.Count == 0)
            {
                throw new Exception("La venta debe tener al menos un producto.");
            }

            if (venta.Cliente == null)
            {
                throw new Exception("La venta debe tener un cliente asociado.");
            }

            if (venta.MedioPago == null)
            {
                throw new Exception("Debe seleccionar un medio de pago.");
            }

            if (venta.Usuario == null)
            {
                throw new Exception("La venta debe tener un usuario/empleado asociado.");
            }

            //verifico stock de todos los productos antes de confirmar
            foreach (DetalleVenta detalle in venta.Detalles)
            {
                if (detalle.ProductoItem.Stock < detalle.CantidadProducto)
                {
                    throw new Exception($"Stock insuficiente para: {detalle.ProductoItem.NombreProducto}. " + $"Stock actual en sistema: {detalle.ProductoItem.Stock} unidades.");
                }
            }

            //valido que el descuento sea un valor permitido
            if (venta.PorcentajeDescuento != 0 && venta.PorcentajeDescuento != 5 && venta.PorcentajeDescuento != 10 && venta.PorcentajeDescuento != 15)
            {
                throw new Exception("El descuento debe ser 0%, 5%, 10% o 15%.");
            }

            //valido internamente que tenga todo lo necesario
            venta.Confirmar();

            //cuando este la DAL:
            int idVenta = _ventaDAL.RegistrarVentaCabecera(venta);

            foreach (DetalleVenta detalle in venta.Detalles)
            {
                _ventaDAL.RegistrarDetalleVenta(idVenta, detalle);
            }

            _ventaDAL.RegistrarPago(idVenta, venta.CalcularTotal(), venta.MedioPago);

            _ventaDAL.DescontarStockPorVenta(venta.Detalles);

            return idVenta;
        }

        //crear detalle

        public DetalleVenta CrearDetalle(Producto producto, int cantidad)
        {
            if (producto == null)
            {
                throw new ArgumentNullException("El producto no puede ser nulo.");
            }

            if (cantidad <= 0)
            {
                throw new Exception("La cantidad debe ser mayor a cero.");
            }

            if (producto.Stock < cantidad)
            {
                throw new Exception($"Stock insuficiente. " + $"Stock actual: {producto.Stock}.");
            }

            if (producto.ValorVenta <= 0)
            {
                throw new Exception($"Error de consistencia: El producto '{producto.NombreProducto}' no tiene un precio de venta válido asignado.");
            }

            //el precio unitario se toma del valor de venta del producto
            return new DetalleVenta(0, producto, cantidad, producto.ValorVenta);
        }

        //calculo de total y subtotal

        public double ObtenerSubtotal(Venta venta)
        {
            if (venta == null)
            {
                throw new ArgumentNullException("La venta no puede ser nula.");
            }

            return venta.CalcularSubtotal();
        }

        public double ObtenerTotal(Venta venta)
        {
            if (venta == null)
            {
                throw new ArgumentNullException("La venta no puede ser nula.");
            }

            if (venta.MedioPago == null)
            {
                throw new Exception("Seleccione un medio de pago para calcular el total.");
            }

            return venta.CalcularTotal();
        }

        //cancelar la venta

        public void CancelarVenta(Venta venta)
        {
            if (venta == null)
            {
                return;
            }
            venta.Cancelar();
        }

        //generar ticket
        public string GenerarTextoTicket(Venta venta, int idVentaConfirmado)
        {
            StringBuilder ticket = new StringBuilder();

            ticket.AppendLine("=========================================");
            ticket.AppendLine("           LIBRERÍA BORCELLE            ");
            ticket.AppendLine("=========================================");
            ticket.AppendLine($"Ticket Nro: {idVentaConfirmado.ToString("D8")}");
            ticket.AppendLine($"Fecha: {venta.FechaVenta.ToString("dd/MM/yyyy HH:mm")}");
            ticket.AppendLine($"Vendedor: {venta.Usuario.NombreUsuario}");
            ticket.AppendLine($"Cliente: {venta.Cliente.NombreCliente} {venta.Cliente.ApellidoCliente}");
            ticket.AppendLine("-----------------------------------------");
            ticket.AppendLine("Cant  Producto                Subtotal   ");
            ticket.AppendLine("-----------------------------------------");

            foreach (DetalleVenta item in venta.Detalles)
            {
                string nombreCorto = item.ProductoItem.NombreProducto.Length > 22 ? item.ProductoItem.NombreProducto.Substring(0, 22) : item.ProductoItem.NombreProducto.PadRight(22);

                ticket.AppendLine($"{item.CantidadProducto.ToString().PadRight(5)}{nombreCorto}${item.SubtotalDetalleVenta.ToString("N2").PadLeft(10)}");
            }

            ticket.AppendLine("-----------------------------------------");
            ticket.AppendLine($"SUBTOTAL:               ${venta.CalcularSubtotal().ToString("N2").PadLeft(10)}");

            if (venta.PorcentajeDescuento > 0)
            {
                ticket.AppendLine($"DESCUENTO ({venta.PorcentajeDescuento}%):     -${(venta.CalcularSubtotal() * (venta.PorcentajeDescuento / 100.0)).ToString("N2").PadLeft(10)}");
            }

            ticket.AppendLine($"Medio de Pago: {venta.MedioPago.NombreMedioPago}");
            ticket.AppendLine("=========================================");
            ticket.AppendLine($"TOTAL FINAL:            ${venta.CalcularTotal().ToString("N2").PadLeft(10)}");
            ticket.AppendLine("=========================================");
            ticket.AppendLine("       ¡Gracias por su compra!           ");
            ticket.AppendLine("=========================================");

            return ticket.ToString();
        }

        //un apartado de las consutlas

        /*public List<Venta> ObtenerTodas()
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            return _ventaDAL.ObtenerTodas();
        }

        public Venta ObtenerPorId(int idVenta)
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            if (idVenta <= 0)
            {
                throw new Exception("El ID de venta es inválido.");
            }


            return _ventaDAL.ObtenerPorId(idVenta);
        }*/
    }
}
