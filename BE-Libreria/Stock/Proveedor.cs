using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Proveedor
    {
        //atributos
        private int _idProveedor;
        private string _nombreProveedor;
        private string _cuitProveedor;
        private string _telefonoProveedor;

        //constructor
        public Proveedor(int idProveedor, string nombreProveedor, string cuitProveedor, string telefonoProveedor)
        {
            _idProveedor = idProveedor;
            _nombreProveedor = nombreProveedor;
            _cuitProveedor = cuitProveedor;
            _telefonoProveedor = telefonoProveedor;
        }

        //propiedades
        public int IdProveedor
        {
            get { return _idProveedor; }
        }

        public string NombreProveedor
        {
            get { return _nombreProveedor; }
        }

        public string CuitProveedor
        {
            get { return _cuitProveedor; }
        }
        // lo modifique a string pq en la bd hay guiones y no se pueden convertir a int
        public string TelefonoProveedor
        {
            get { return _telefonoProveedor;}
        }
    }
}
