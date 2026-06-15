using BE_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_Libreria
{
    public class VentaBLL
    {
        // private VentaDAL _ventaDAL = new VentaDAL();

        //registrar venta

        public void RegistrarVenta(Venta venta)
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
            // _ventaDAL.RegistrarVenta(venta);
            throw new NotImplementedException("Pendiente conexión con DAL.");
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

        //un apartado de las consutlas

        public List<Venta> ObtenerTodas()
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            // return _ventaDAL.ObtenerTodas();
            throw new NotImplementedException("Pendiente conexión con DAL.");
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


            // return _ventaDAL.ObtenerPorId(idVenta);
            throw new NotImplementedException("Pendiente conexión con DAL.");
        }
    }
}
