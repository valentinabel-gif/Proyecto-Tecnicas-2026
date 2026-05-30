using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class DetalleVenta
    {
        //atributos
        private int _idDetalleVenta;
        private int _cantidadProducto;
        private double _precioUnitario;
        private double _subtotalDetalleVenta;
        private Producto _productoItem;

        //constructor
        public DetalleVenta(int idDetalleVenta, Producto productoItem, int cantidadProducto, double precioUnitario)
        {
            _idDetalleVenta = idDetalleVenta;
            _productoItem = productoItem;
            _cantidadProducto = cantidadProducto;
            _precioUnitario = precioUnitario;
            _subtotalDetalleVenta = precioUnitario * cantidadProducto;
        }

        //propiedades
        public int IdDetalleVenta
        {
            get {  return _idDetalleVenta; }
        }
        public int CantidadProducto
        {
            get { return _cantidadProducto;}
        }
        public double PrecioUnitario
        {
            get { return _precioUnitario; }
        }
        public double SubtotalDetalleVenta
        {
            get { return _subtotalDetalleVenta;}
        }
        public Producto ProductoItem
        {
            get { return _productoItem; }
        }

        //metodo para la interfaz grafica
        public override string ToString()
        {
            return $"{_productoItem.NombreProducto} (x{_cantidadProducto}) - Subtotal: ${_subtotalDetalleVenta}";
        }

    }
}
