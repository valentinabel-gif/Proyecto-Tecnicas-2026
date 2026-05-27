using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Venta
    {
        private int _idVenta;
        private DateTime _fechaVenta;
        private List<DetalleVenta> _detalles;
        private int _porcentajeDescuento;// descuento arbitrario que puede elegir el vendedor  5% / 10% / 15%
        //private Cliente _cliente;//cliente asociado a la venta            
        private Usuario _usuario;//empleado q hizo la venta
        private MedioDePago _medioPago;

        public Venta(int idVenta, DateTime fechaVenta, /*Cliente cliente*/ Usuario usuario, MedioDePago medioPago)
        {
            _idVenta = idVenta;
            _fechaVenta = fechaVenta;
            _porcentajeDescuento = 0;
            //_cliente = cliente;
            _usuario = usuario;
            _medioPago = medioPago;
            _detalles = new List<DetalleVenta>();
        }

        public int IdVenta
        {
            get { return _idVenta; }
        }

        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
        }

        public List<DetalleVenta> Detalles
        {
            get { return _detalles; }
        }

        // Lleva 'set' para que el vendedor pueda modificar el descuento desde la pantalla
        public int PorcentajeDescuento
        {
            get { return _porcentajeDescuento; }
            set { _porcentajeDescuento = value; }
        }

        public Usuario Usuario
        {
            get { return _usuario; }
        }

        public MedioDePago MedioPago
        {
            get { return _medioPago; }
        }

        //metodos
        public void AgregarDetalle(DetalleVenta nuevoDetalle)
        {
            if (nuevoDetalle != null)
            {
                _detalles.Add(nuevoDetalle);
            }
        }

        public void QuitarDetalle(DetalleVenta detalleAEliminar)
        {
            _detalles.Remove(detalleAEliminar);
        }
    }
}
