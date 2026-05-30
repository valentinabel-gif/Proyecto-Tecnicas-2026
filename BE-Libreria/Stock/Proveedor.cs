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
        private string _cuilProveedor;
        private int _telefonoProveedor;

        //constructor
        public Proveedor(int idProveedor, string nombreProveedor, string cuilProveedor, int telefonoProveedor)
        {
            _idProveedor = idProveedor;
            _nombreProveedor = nombreProveedor;
            _cuilProveedor = cuilProveedor;
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

        public string CuilProveedor
        {
            get { return _cuilProveedor; }
        }

        public int TelefonoProveedor
        {
            get { return _telefonoProveedor;}
        }
    }
}
