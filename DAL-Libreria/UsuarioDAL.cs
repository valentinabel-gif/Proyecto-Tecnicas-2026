using BE_Libreria;
using BE_Libreria.Seguridad_y_Usuario;
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
        //private List<IObservadorUsuario> _observadores = new List<IObservadorUsuario>();

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

            //Notificar();
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
        //Modificar usuario
        public Usuario RecuperarPorId(int idUsuario)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
        _conexion.crearParametro("@id_usuario", idUsuario)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_RecuperarUsuarioPorId", parametros);

            if (tabla == null || tabla.Rows.Count == 0)
                return null;

            DataRow fila = tabla.Rows[0];
            Rol rol = new Rol(Convert.ToInt32(fila["id_rol"]), fila["nombre_rol"].ToString());

            return new Usuario(
                Convert.ToInt32(fila["id_usuario"]),
                fila["nombre"].ToString(),
                fila["apellido"].ToString(),
                fila["correo"].ToString(),
                fila["dni"].ToString(),
                "",
                fila["nombre_usuario"].ToString(),
                rol
            );
        }

        public void Modificar(Usuario usuario, string passwordHasheada = null)
        {
            SqlParameter paramContrasena = new SqlParameter("@contrasena", SqlDbType.NVarChar);
            paramContrasena.Value = passwordHasheada != null ? (object)passwordHasheada : DBNull.Value;

            SqlParameter[] parametros = new SqlParameter[]
            {
        _conexion.crearParametro("@id_usuario", usuario.IdUsuario),
        _conexion.crearParametro("@nombre",     usuario.NombreUsuario),
        _conexion.crearParametro("@apellido",   usuario.ApellidoUsuario),
        _conexion.crearParametro("@correo",     usuario.CorreoUsuario),
        _conexion.crearParametro("@dni",        usuario.DniUsuario),
        _conexion.crearParametro("@username",   usuario.UsernameUsuario),
        _conexion.crearParametro("@id_rol",     usuario.RolUsuario.IdMedidaDeSeguridad),
        paramContrasena
            };

            _conexion.EscribirPorStoreProcedure("sp_ModificarUsuario", parametros);
        }
        
    }
}
