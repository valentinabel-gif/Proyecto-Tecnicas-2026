using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Libreria
{
    public class Usuario
    {
        //atributos
        private int _idUsuario;
        private string _nombreUsuario;
        private string _apellidoUsuario;
        private string _correoUsuario;
        private string _dniUsuario;
        private string _contraseniaUsuario;
        private string _usernameUsuario;
        //private Rol _rolUsuario;

        //constructor
        public Usuario(int idUsuario, string nombreUsuario, string apellidoUsuario, string correoUsuario, string dniUsuario, string contraseniaUsuario, string usernameUsuario)
        {
            _idUsuario = idUsuario;
            _nombreUsuario = nombreUsuario;
            _apellidoUsuario = apellidoUsuario;
            _correoUsuario = correoUsuario;
            _dniUsuario = dniUsuario;
            _contraseniaUsuario = contraseniaUsuario;
            _usernameUsuario = usernameUsuario;
            //_rolUsuario = new Rol();
        }

        //propiedades
        public int IdUsuario
        {
            get { return _idUsuario;}
        }
        public string NombreUsuario
        {
            get { return _nombreUsuario; }
        }
        public string ApellidoUsuario
        {
            get { return _apellidoUsuario; }
        }
        public string CorreoUsuario
        {
            get { return _correoUsuario; }
        }
        public string DniUsuario
        {
            get { return _dniUsuario; }
        }
        public string ContraseniaUsuario
        {
            get { return _contraseniaUsuario; }
        }
        public string UsernameUsuario
        {
            get { return _usernameUsuario; }
        }
        /*public Rol RolUsuario
        {
            get { return _rolUsuario; }
        }*/

        //metodos
        /*public bool ValidarDatosEstructurales()
        {
            return !string.IsNullOrEmpty(_nombreUsuario) && !string.IsNullOrEmpty(_contraseniaUsuario) && _rol != null;
        }*/
    }
}
