using BE_Libreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Libreria;

namespace BLL_Libreria
{
    public class ClienteBLL
    {
        private ClienteDAL _clienteDAL = new ClienteDAL();

        public List<Cliente> ObtenerTodos()
        {
            //cuando tyengamos la BD agarra de ahi 
            return _clienteDAL.ObtenerTodos();
        }

        public void AgregarCliente(Cliente nuevoCliente)
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            if (nuevoCliente == null)
            {
                throw new ArgumentNullException("El cliente no puede ser nulo.");
            }

            //Regla de Negocio: Campos de identidad obligatorios
            if (string.IsNullOrWhiteSpace(nuevoCliente.NombreCliente) || string.IsNullOrWhiteSpace(nuevoCliente.ApellidoCliente))
            {
                throw new Exception("Operación rechazada: El Nombre y el Apellido son obligatorios para dar de alta un cliente.");
            }
            if (string.IsNullOrWhiteSpace(nuevoCliente.CondicionFiscal))
            {
                throw new Exception("Operación rechazada: Debe especificar la Condición Fiscal (Monotributo, Responsable Inscripto, etc.).");
            }
            if (!nuevoCliente.ValidarIdentificacion())
            {
                throw new Exception("Validación fallida: El cliente debe contar obligatoriamente con al menos un DNI o un CUIT válido.");
            }

            if (_clienteDAL.ExisteDniOCuit(nuevoCliente.CuitCliente)) throw new Exception("El CUIT ingresado ya pertenece a un cliente registrado.");

            _clienteDAL.AgregarCliente(nuevoCliente);
        }

        public void ModificarCliente(Cliente clienteModificado)
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            if (clienteModificado == null)
            {
                throw new ArgumentNullException("El cliente no puede ser nulo.");
            }

            if (clienteModificado.IdCliente <= 0)
            {
                throw new Exception("Error de consistencia: El ID del cliente a modificar no es válido.");
            }

            if (string.IsNullOrWhiteSpace(clienteModificado.NombreCliente) || string.IsNullOrWhiteSpace(clienteModificado.ApellidoCliente))
            {
                throw new Exception("Operación rechazada: No se pueden borrar el Nombre y Apellido en una modificación.");
            }

            if (!clienteModificado.ValidarIdentificacion())
            {
                throw new Exception("Validación fallida: No se puede guardar la modificación si el cliente queda sin DNI y sin CUIT.");
            }

            //Si valido todo guardo en la BD
            _clienteDAL.ModificarCliente(clienteModificado);
        }

        public void EliminarCliente(int idCliente)
        {
            if (!Sesion.Instancia.HaySesionActiva())
            {
                throw new Exception("No hay sesión activa.");
            }

            if (idCliente <= 0)
            {
                throw new Exception("Operación rechazada: El ID del cliente a eliminar es inválido.");
            }

            _clienteDAL.EliminarCliente(idCliente);
        }

        public Cliente BuscarPorDniOCuit(string valor)
        {
            if (string.IsNullOrWhiteSpace(valor))
                throw new Exception("Debe ingresar un DNI o CUIT para buscar.");

            return _clienteDAL.BuscarPorDniOCuit(valor);
        }

        public Cliente ObtenerPorId(int idCliente)
        {
            if (idCliente <= 0)
                throw new Exception("El ID del cliente es inválido.");

            return _clienteDAL.ObtenerPorId(idCliente);
        }

        public bool ExisteCuit(string cuit)
        {
            if (string.IsNullOrWhiteSpace(cuit))
                return false;

            return _clienteDAL.ExisteDniOCuit(cuit);
        }
    }
}
