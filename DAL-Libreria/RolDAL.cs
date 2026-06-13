using BE_Libreria;

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_Libreria
{
    public class RolDAL
    {
        private Conexion _conexion = new Conexion();


        public List<Rol> RecuperarRoles()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_RecuperarRoles");

            List<Rol> roles = new List<Rol>();
            if(tabla!= null)
            {
                foreach(DataRow fila in tabla.Rows)
                {
                    roles.Add(new Rol(Convert.ToInt32(fila["id_rol"]), fila["nombre_rol"].ToString()));
                }
            }
            return roles;
        }

        public int ContarRoles()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_ContarRoles");
            if (tabla != null && tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["total"]);
            }
            return 0;
        }
        public int ContarPermisos()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_ContarPermisos");
            if (tabla != null && tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["total"]);
            }
            return 0;
        }

        public List<Permiso> RecuperarListaPermisos()
        {

            DataTable tabla = _conexion.LeerPorComando("sp_RecuperarTodosLosPermisos"); 
            List<Permiso>permisos = new List<Permiso>();

            if (tabla != null && tabla.Rows.Count > 0)
            {
                foreach(DataRow fila in tabla.Rows)
                {
                    permisos.Add(new Permiso(Convert.ToInt32(fila["id_permiso"]), fila["nombre_permiso"].ToString()));
                }
            }

            return permisos;
        }

        public List<Permiso> RecuperarPermisosPorRol(int idRol)
        {
            SqlParameter[] parametros = new SqlParameter[]
           {
                _conexion.crearParametro("@id_rol",idRol)
           };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_RecuperarPermisosPorRol", parametros);
            List<Permiso> permisos = new List<Permiso>();

            if(tabla != null && tabla.Rows.Count >0)
            {
                foreach(DataRow fila in tabla.Rows)
                {
                    permisos.Add(new Permiso(Convert.ToInt32(fila["id_permiso"]), fila["nombre_permiso"].ToString()));
                }
            }

            return permisos;
        }

        public void ActualizarRol(int idRol, string nuevoNombre, List<Permiso>permisos)
        {
            SqlParameter[] parametrosNombre = new SqlParameter[]
            {
                _conexion.crearParametro("@id_rol",idRol),
                _conexion.crearParametro("@nombre_rol",nuevoNombre)
            };

            _conexion.EscribirPorStoreProcedure("sp_ModificarRol", parametrosNombre);

            SqlParameter[] parametrosEliminar = new SqlParameter[]
            {
                _conexion.crearParametro("@id_rol", idRol)
            };

            _conexion.EscribirPorStoreProcedure("sp_EliminarPermisosPorRol", parametrosEliminar);

            foreach(Permiso p in permisos)
            {
                SqlParameter[] parametrosPermiso = new SqlParameter[]
                {
                    _conexion.crearParametro("@id_rol",idRol),
                    _conexion.crearParametro("@id_permiso", p.IdMedidaDeSeguridad)
                };

                _conexion.EscribirPorStoreProcedure("sp_AsignarPermisoARol",parametrosPermiso);
            }
        }

        public void EliminarRol(int idRol)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_rol", idRol)
            };

                int filasAfectadas = _conexion.EscribirPorStoreProcedure("sp_EliminarRol", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo eliminar el rol.");
        }

        public void Insertar(string nombreRol)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        _conexion.crearParametro("@nombre_rol", nombreRol)
            };

            _conexion.EscribirPorStoreProcedure("sp_CrearRol", parametros);
        }
    }
}
