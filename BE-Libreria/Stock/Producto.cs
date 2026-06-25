using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Producto
    {
        //atributos
        private int _idProducto;
        private string _nombreProducto;
        private double _valorVenta;
        private double _valorLista;
        private int _stock;
        private string _codigoBarra;
        private string _descripcionProducto;
        private Categoria _categoria;

        //constructor
        public Producto(int idProducto, string nombreProducto, double valorVenta, double valorLista, int stock, string codigoBarra, string descripcionProducto, Categoria categoria)
        {
            _idProducto = idProducto;
            _nombreProducto = nombreProducto;
            _valorVenta = valorVenta;
            _valorLista = valorLista;
            _stock = stock;
            _codigoBarra = codigoBarra;
            _descripcionProducto = descripcionProducto;
            _categoria = categoria;
        }

        //propiedades
        public int IdProducto
        {
            get { return _idProducto; }
        }

        public string NombreProducto
        {
            get { return _nombreProducto; }
        }

        public double ValorVenta
        {
            get { return _valorVenta; }
        }

        public double ValorLista
        {
            get { return _valorLista; }
        }

        public int Stock
        {
            get { return _stock; }
            set { _stock = value; } //set permite modificar el stock al vender o comprar
        }

        public string CodigoBarra
        {
            get { return _codigoBarra; }
        }

        public string DescripcionProducto
        {
            get { return _descripcionProducto; }
        }

        public Categoria Categoria
        {
            get { return _categoria; }
        }
        public string NombreCategoria
        {
            get { return _categoria.NombreCategoria; }
        }
    }
}
