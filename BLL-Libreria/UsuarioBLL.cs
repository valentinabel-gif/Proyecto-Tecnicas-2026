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
    }
}
