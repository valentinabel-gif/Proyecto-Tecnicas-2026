using BE_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//esta va a ser la clase q va a aplicar el singleton

namespace BLL_Libreria
{
    public class Sesion
    {
        //atributos
        private static Sesion _instancia;// variable estatica del singleton
        private Usuario _usuarioActivo;

        //ccosntructor privado del sinfgleton
        private Sesion() 
        {

        }

        //propiedades
        public static Sesion Instancia
        {
            get
            {
                if (_instancia == null)//si no hay instancia creo una, si ya existe devuelvo la misma asi solo instancio una sola vez
                {
                    _instancia = new Sesion();
                }
                return _instancia;
            }
        }

        public Usuario UsuarioActivo
        {
            get { return _usuarioActivo; }
        }

        // metodos
        public void RegistrarSesion(Usuario usuario)
        {
            _usuarioActivo = usuario;
        }

        public void CerrarSesion()
        {
            _usuarioActivo = null;
        }

        public bool HaySesionActiva()
        {
            return _usuarioActivo != null;
        }
    }
}
