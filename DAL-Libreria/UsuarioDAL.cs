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
    public class UsuarioDAL
    {
        private Conexion _conexion = new Conexion();

        public Usuario Autenticar(string username, string passwordHasheada)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@username", username),
                _conexion.crearParametro("@contrasena", passwordHasheada)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_AutenticarUsuario", parametros);

            if (tabla == null || tabla.Rows.Count == 0)
            {
                return null;
            }

            DataRow fila = tabla.Rows[0];

            int idRol = Convert.ToInt32(fila["id_rol"]);
            string nombreRol = fila["nombre_rol"].ToString();

            Rol rol = new Rol(idRol, nombreRol);
            List<Permiso> permisos = RecuperarPermisosPorRol(idRol);
            foreach (Permiso p in permisos)
            {
                rol.Agregar(p);
            }

            Usuario usuario = new Usuario(Convert.ToInt32(fila["id_usuario"]), fila["nombre"].ToString(), fila["apellido"].ToString(), fila["correo"].ToString(), fila["dni"].ToString(), fila["contrasena"] != DBNull.Value ? fila["contrasena"].ToString() : "", fila["nombre_usuario"].ToString(), rol);

            return usuario;
        }

        private List<Permiso> RecuperarPermisosPorRol(int idRol)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_rol", idRol)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_RecuperarPermisosPorRol", parametros);

            List<Permiso> permisos = new List<Permiso>();

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    permisos.Add(new Permiso(Convert.ToInt32(fila["id_permiso"]), fila["nombre_permiso"].ToString()));
                }
            }

            return permisos;
        }
    }
}
