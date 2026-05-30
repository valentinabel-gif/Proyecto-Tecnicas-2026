using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Cliente
    {
        //atributos
        private int _idCliente;
        private string _nombreCliente;
        private string _apellidoCliente;
        private string _dniCliente;
        private string _condicionFiscal;
        private string _razonSocial;
        private string _cuitCliente;

        //constructor
        public Cliente(int IdCliente, string nombreCliente, string apellidoCliente, string dniCliente, string condicionFiscal, string razonSocial, string cuitCliente)
        {
            _idCliente = IdCliente;
            _nombreCliente = nombreCliente;
            _apellidoCliente = apellidoCliente;
            _dniCliente = dniCliente;
            _condicionFiscal = condicionFiscal;
            _razonSocial = razonSocial;
            _cuitCliente = cuitCliente;
        }

        //propiedades
        public int IdCliente
        {
            get { return _idCliente; }
        }
        public string NombreCliente
        {
            get { return _nombreCliente; }
        }
        public string ApellidoCliente
        {
            get { return _apellidoCliente; }
        }
        public string DniCliente
        {
            get { return _dniCliente; }
        }
        public string CuitCliente
        {
            get { return _cuitCliente; }
        }
        public string CondicionFiscal
        {
            get { return _condicionFiscal;}
        }
        public string RazonSocial
        {
            get { return _razonSocial; }
        }

        //metodos
        public bool ValidarIdentificacion()
        {
            //DNI o CUIT valido
            return !string.IsNullOrEmpty(_dniCliente) || !string.IsNullOrEmpty(_cuitCliente);
        }
    }
}
