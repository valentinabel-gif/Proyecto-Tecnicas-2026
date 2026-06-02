using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using BE_Libreria;
//using DAL_Libreria; para cuando empecemos a usarla
//dato importante cuando guardemos la contraseña en la DAL el SELECT seria algo asi:
// SELECT * FROM Usuario WHERE username = @username AND contrasenia = @passwordEncriptada
//otro dato importante, cuando llamo a tienepermiso que viene de usuario le paso gestionarusarios, no se si en la BD se va a llamar asi o se va a llamar de otra forma, pero lo importante es que el string que le paso a permiso tiene q ser exactamente igual al string que esta guardado en la BD para ese permiso, porque si no no va a encontrarlo y va a devolver false aunque el usuario tenga ese permiso. 

namespace BLL_Libreria
{
    public class UsuarioBLL
    {
        // private UsuarioDAL _usuarioDAL = new UsuarioDAL(); el gestor va a usdar esta instancia para hablar con la BD


        //valido las credenciales del usuario y retorno el objeto Usuario si son correctas. la contraseña se hashea con SHA256 antes de compararse con la BD
        public Usuario RecuperarUsuarioPorCredenciales(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
                throw new Exception("El nombre de usuario es obligatorio.");

            if (string.IsNullOrWhiteSpace(password))
                throw new Exception("La contraseña es obligatoria.");

            string passwordHasheada = EncriptarContrasenia(password);

            //cuando este hecha la dal pongo esto
            // Usuario usuario = _usuarioDAL.Autenticar(username, passwordHasheada);
            // if (usuario == null)
            //{
            //     throw new Exception("Usuario o contraseña incorrectos.");
            //}
            // return usuario;

            throw new NotImplementedException("pendiente conexion con DAL.");// y cuando ya este hecha la dal borro toda esta linea
        }

        private string EncriptarContrasenia(string passwordPlana)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(passwordPlana));
                StringBuilder resultado = new StringBuilder();
                foreach (byte b in bytes)
                {
                    resultado.Append(b.ToString("x2"));
                }
                return resultado.ToString();
            }
        }

        public void AltaUsuario(Usuario nuevoUsuario)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("GestionarUsuarios"))
            {
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para registrar usuarios.");
            }

            if (!nuevoUsuario.ValidarDatosEstructurales())
            {
                throw new Exception("Los datos del usuario son inválidos.");
            }

            //cuando la DAL este lista intercepto la contraseña del nuevo usuario y la hasheamos antes del INSERT
            //string passHasheada = EncriptarContrasenia(nuevoUsuario.ContraseniaUsuario);
            //_usuarioDAL.Insertar(nuevoUsuario, passHasheada);

            throw new NotImplementedException("pendiente conexion con DAL.");// y cuando ya este hecha la dal borro toda esta linea
        }

        public void ModificarUsuario(Usuario usuarioModificado)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("GestionarUsuarios"))
            {
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para modificar usuarios.");
            }

            if (!usuarioModificado.ValidarDatosEstructurales())
                throw new Exception("Los datos del usuario son inválidos.");

            // _usuarioDAL.Modificar(usuarioModificado);

            throw new NotImplementedException("pendiente conexion con DAL.");// y cuando ya este hecha la dal borro toda esta linea
        }

        public void BajaUsuario(int idUsuario)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("GestionarUsuarios"))
            {
                throw new Exception("Seguridad: No cuenta con los permisos necesarios para dar de baja usuarios.");
            }

            if (idUsuario <= 0)
                throw new Exception("El ID de usuario es inválido.");

            //en el procedimiento almacenado en la DAL ejecuto una baja logica (UPDATE estado = 0)
            // _usuarioDAL.DesactivarUsuario(idUsuario);

            throw new NotImplementedException("pendiente conexion con DAL.");// y cuando ya este hecha la dal borro toda esta linea
        }

        
        public List<Usuario> RecuperarTodosLosUsuarios()
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("GestionarUsuarios"))
            {
                throw new Exception("Seguridad: No tiene autorización para visualizar el listado de usuarios.");
            }

            // return _usuarioDAL.RecuperarTodos();
            throw new NotImplementedException("pendiente conexion con DAL.");
        }

        public Usuario RecuperarUsuarioPorId(int idUsuario)
        {
            if (!Sesion.Instancia.HaySesionActiva() || !Sesion.Instancia.UsuarioActivo.TienePermiso("GestionarUsuarios"))
            {
                throw new Exception("Seguridad: No tiene autorización para consultar usuarios.");
            }
                
            if (idUsuario <= 0)
            {
                throw new Exception("El ID de usuario es inválido.");
            }
            // return _usuarioDAL.RecuperarPorId(idUsuario);

            throw new NotImplementedException("Pendiente conexión con DAL.");
        }
    }
}
