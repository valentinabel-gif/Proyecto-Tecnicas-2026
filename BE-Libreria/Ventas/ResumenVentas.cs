using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria.Ventas
{
    public class ResumenVentas
    {
        private int _idVenta;
        private DateTime _fechaVenta;
        private string _cliente;
        private double _totalVenta;

        public int IdVenta 
        { 
            get { return _idVenta; } 
        }
        public DateTime FechaVenta
        {
            get { return _fechaVenta; }
        }
        public string Cliente 
        { 
            get { return _cliente; } 
        }
        public double TotalVenta {
            get { return _totalVenta; }
        }


        public ResumenVentas(int idVenta, DateTime fechaVenta, string cliente, double totalVenta)
        {
            _idVenta = idVenta;
            _fechaVenta = fechaVenta;
            _cliente = cliente;
            _totalVenta = totalVenta;
        }
    }
}
