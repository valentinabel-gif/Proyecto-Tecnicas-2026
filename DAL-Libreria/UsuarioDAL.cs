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

        public void Insertar(Usuario nuevoUsuario, string passwordHasheada)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@nombre",     nuevoUsuario.NombreUsuario),
                _conexion.crearParametro("@apellido",   nuevoUsuario.ApellidoUsuario),
                _conexion.crearParametro("@correo",     nuevoUsuario.CorreoUsuario),
                _conexion.crearParametro("@dni",        nuevoUsuario.DniUsuario),
                _conexion.crearParametro("@contrasena", passwordHasheada),
                _conexion.crearParametro("@username",   nuevoUsuario.UsernameUsuario),
                _conexion.crearParametro("@id_rol",     nuevoUsuario.RolUsuario.IdMedidaDeSeguridad)
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure("sp_CrearUsuario", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo insertar el usuario.");
        }

        public int ContarUsuarios()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_ContarUsuarios");
            if (tabla != null && tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["total"]);
            }
            return 0;
        }

        public List<Usuario> RecuperarTodos()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_RecuperarUsuarios");
            List<Usuario> usuarios = new List<Usuario>();

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    Rol rol = new Rol(Convert.ToInt32(fila["id_rol"]), fila["nombre_rol"].ToString());
                    usuarios.Add(new Usuario(
                        Convert.ToInt32(fila["id_usuario"]),
                        fila["nombre"].ToString(),
                        fila["apellido"].ToString(),
                        fila["correo"].ToString(),
                        fila["dni"].ToString(),
                        "",
                        fila["nombre_usuario"].ToString(),
                        rol
                    ));
                }
            }
            return usuarios;
        }

        public Usuario RecuperarPorId(int idUsuario)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_usuario", idUsuario)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_RecuperarUsuarioPorId", parametros);

            if (tabla == null || tabla.Rows.Count == 0)
            {
                return null;
            }

            DataRow fila = tabla.Rows[0];

            Rol rol = new Rol(Convert.ToInt32(fila["id_rol"]), fila["nombre_rol"].ToString());

            return new Usuario(Convert.ToInt32(fila["id_usuario"]), fila["nombre"].ToString(), fila["apellido"].ToString(), fila["correo"].ToString(), fila["dni"].ToString(), "", fila["nombre_usuario"].ToString(), rol);
        }

        public void Modificar(Usuario usuarioModificado)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_usuario", usuarioModificado.IdUsuario),
                _conexion.crearParametro("@nombre",     usuarioModificado.NombreUsuario),
                _conexion.crearParametro("@apellido",   usuarioModificado.ApellidoUsuario),
                _conexion.crearParametro("@correo",     usuarioModificado.CorreoUsuario),
                _conexion.crearParametro("@dni",        usuarioModificado.DniUsuario),
                _conexion.crearParametro("@username",   usuarioModificado.UsernameUsuario),
                _conexion.crearParametro("@id_rol",
                usuarioModificado.RolUsuario.IdMedidaDeSeguridad)
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure("sp_ModificarUsuario", parametros);

            if (filasAfectadas <= 0)
            {
                throw new Exception("No se pudo modificar el usuario.");
            }
        }

        public void DesactivarUsuario(int idUsuario)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_usuario", idUsuario)
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure("sp_DesactivarUsuario", parametros);

            if (filasAfectadas <= 0)
            {
                throw new Exception("No se pudo desactivar el usuario.");
            }
        }

    }
}
