using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class DetalleIngreso
    {
        //atributos
        private int _idDetalleIngreso;
        private int _cantidadProducto;
        private double _precioUnitarioProducto;
        private double _precioTotalProducto;
        private Producto _productoItem;

        //constructor
        public DetalleIngreso(int idDetalleIngreso, Producto productoItem, int cantidadProducto, double precioUnitarioProducto)
        {
            _idDetalleIngreso = idDetalleIngreso;
            _productoItem = productoItem;
            _cantidadProducto = cantidadProducto;
            _precioUnitarioProducto = precioUnitarioProducto;
            _precioTotalProducto = precioUnitarioProducto * cantidadProducto;
        }

        //propiedades
        public int IdDetalleIngreso
        {
            get { return _idDetalleIngreso; }
        }

        public Producto ProductoItem
        {
            get { return _productoItem; }
        }

        public int CantidadProducto
        {
            get { return _cantidadProducto; }
        }

        public double PrecioUnitarioProducto
        {
            get { return _precioUnitarioProducto; }
        }

        public double PrecioTotalProducto
        {
            get { return _precioTotalProducto; }
        }

    }
}
