using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Pago
    {
        //atributos
        private int _idPago;
        private double _montoTotal;
        private DateTime _fechaPago;
        private string _estadoPago;
        private Venta _ventaItem;
        private MedioDePago _medioPagoItem;

        //constructor
        public Pago(int idPago, double montoTotal, DateTime fechaPago, string estadoPago, Venta ventaItem, MedioDePago medioPagoItem)
        {
            _idPago = idPago;
            _montoTotal = montoTotal;
            _fechaPago = fechaPago;
            _estadoPago = estadoPago;
            _ventaItem = ventaItem;
            _medioPagoItem = medioPagoItem;
        }

        //propiedades
        public int IdPago
        {
            get { return _idPago; }
        }
        public double MontoTotal
        {
            get { return _montoTotal; }
        }
        public DateTime FechaPago
        {
            get { return _fechaPago; }
        }
        public string EstadoPago
        {
            get { return _estadoPago; }
        }
        public Venta VentaItem
        {
            get { return _ventaItem; }
        }
        public MedioDePago MedioPagoItem
        {
            get { return _medioPagoItem; }
        }
    }
}
