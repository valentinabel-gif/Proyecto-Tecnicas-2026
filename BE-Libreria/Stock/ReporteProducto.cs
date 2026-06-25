using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria.Stock
{
    public class ReporteProducto
    {
        private int _idProducto;
        private string _nombreProducto;
        private string _nombreCategoria;
        private int _totalVendido;
        private double _ingresos;
        private double _rentabilidad;
        private int _stockActual;

        public ReporteProducto(int idProducto, string nombreProducto,string nombreCategoria, int totalVendido,double ingresos, double rentabilidad, int stockActual)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _nombreCategoria = nombreCategoria;
            _totalVendido = totalVendido;
            _ingresos = ingresos;
            _rentabilidad = rentabilidad;
            _stockActual = stockActual;
        }

        public int IdProducto
        {
            get { return _idProducto; }
        }
        public string NombreProducto
        {
            get { return _nombreProducto; }
        }
        public string NombreCategoria
        {
            get { return _nombreCategoria; }
        }
        public int TotalVendido
        {
            get { return _totalVendido; }
        }
        public double Ingresos
        {
            get { return _ingresos; }
        }
        public double Rentabilidad
        {
            get { return _rentabilidad; }
        }
        public int StockActual
        {
            get { return _stockActual; }
        }
    }
}

