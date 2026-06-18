using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria.Ventas
{
    public class VentaDelDia
    {
        private int _idVenta;
        private string _vendedor;
        private double _totalVenta;
        private DateTime _fechaVenta;

        public VentaDelDia(int idVenta, string vendedor, double totalVenta, DateTime fechaVenta)
        {
            _idVenta = idVenta;
            _vendedor = vendedor;
            _totalVenta = totalVenta;
            _fechaVenta = fechaVenta;
        }

        public int IdVenta { get { return _idVenta; } }
        public string Vendedor { get { return _vendedor; } }
        public double TotalVenta { get { return _totalVenta; } }
        public DateTime FechaVenta { get { return _fechaVenta; } }
    }
}
