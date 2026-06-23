using BE_Libreria;
using BE_Libreria.Seguridad_y_Usuario;
using DAL_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace BLL_Libreria.Seguridad_y_Usuario___Login
{
    public class RolBLL : ISujetoRol
    {
        private RolDAL _rolDAL = new RolDAL();
        private List<IObservadorRol> _observadores = new List<IObservadorRol>();
        public List<Rol> ObtenerRoles()
        {
            return _rolDAL.RecuperarRoles();
        }

        public int ContarRoles()
        {
            return _rolDAL.ContarRoles();
        }

        public int ContarPermisos()
        {
            return _rolDAL.ContarPermisos();
        }

        public List<Permiso> RecuperarTodosLosPermisos()
        {
            return _rolDAL.RecuperarListaPermisos();
        }

        public List<Permiso> RecuperarPermisosPorRol(int idRol)
        {
            return _rolDAL.RecuperarPermisosPorRol(idRol);
        }

        public void ActualizarRol(int idRol, string nuevoNombre, List<Permiso> permisos)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("modificar_rol"))
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para modificar roles.");

            if (string.IsNullOrWhiteSpace(nuevoNombre))
                throw new Exception("El nombre del rol es obligatorio.");

            _rolDAL.ActualizarRol(idRol, nuevoNombre, permisos);
            Notificar();
        }

        public void EliminarRol(int idRol)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("eliminar_rol"))
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para eliminar roles.");

            if (idRol <= 0)
                throw new Exception("El ID de rol es inválido.");

            _rolDAL.EliminarRol(idRol);
            Notificar();
        }


        public void CrearRol(string nombreRol)
        {
            if (!Sesion.Instancia.HaySesionActiva() ||
                !Sesion.Instancia.UsuarioActivo.TienePermiso("crear_rol"))
            {
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para crear roles.");
            }

            if (string.IsNullOrWhiteSpace(nombreRol))
                throw new Exception("El nombre del rol es obligatorio.");

            _rolDAL.Insertar(nombreRol);
            Notificar(); // Observer - avisa a admiRol para que actualice la grilla
        }

        public void RegistrarObservador(IObservadorRol observer)
        {
            if (!_observadores.Contains(observer))
                _observadores.Add(observer);
            
        }

        public void EliminarObservador(IObservadorRol observer)
        {
            _observadores.Remove(observer);
        }

        public void Notificar()
        {
            foreach (var obs in _observadores)
                obs.Actualizar();
        }
    }
}
