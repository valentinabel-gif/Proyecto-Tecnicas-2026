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
    public class ClienteDAL
    {
        private Conexion _conexion = new Conexion();

        //mEtodo privado para no repetir el mapeo
        private Cliente MapearCliente(DataRow fila)
        {
            return new Cliente(
                Convert.ToInt32(fila["id_cliente"]),
                fila["nombre_cliente"].ToString(),
                fila["apellido_cliente"].ToString(),
                fila["dni_cliente"].ToString(),
                fila["condicion_fiscal"] != DBNull.Value ?
                    fila["condicion_fiscal"].ToString() : "",
                fila["razon_social"] != DBNull.Value ?
                    fila["razon_social"].ToString() : "",
                fila["cuit"] != DBNull.Value ?
                    fila["cuit"].ToString() : ""
            );
        }

        public Cliente BuscarPorDniOCuit(string valor)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@valor", valor)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_BuscarClientePorDniOCuit", parametros);

            if (tabla == null || tabla.Rows.Count == 0)
                return null;

            return MapearCliente(tabla.Rows[0]);
        }

        public Cliente ObtenerPorId(int idCliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_cliente", idCliente)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_ObtenerClientePorId", parametros);

            if (tabla == null || tabla.Rows.Count == 0)
                return null;

            return MapearCliente(tabla.Rows[0]);
        }

        public List<Cliente> ObtenerTodos()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_ObtenerTodosClientes");

            List<Cliente> clientes = new List<Cliente>();

            if (tabla != null)
                foreach (DataRow fila in tabla.Rows)
                    clientes.Add(MapearCliente(fila));

            return clientes;
        }

        public void AgregarCliente(Cliente cliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@nombre_cliente",
                    cliente.NombreCliente),
                _conexion.crearParametro("@apellido_cliente",
                    cliente.ApellidoCliente),
                _conexion.crearParametro("@dni_cliente",
                    cliente.DniCliente),
                _conexion.crearParametro("@condicion_fiscal",
                    cliente.CondicionFiscal ?? ""),
                _conexion.crearParametro("@cuit",
                    cliente.CuitCliente ?? ""),
                _conexion.crearParametro("@razon_social",
                    cliente.RazonSocial ?? "")
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure(
                "sp_AgregarCliente", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo agregar el cliente.");
        }

        public void ModificarCliente(Cliente cliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_cliente",
                    cliente.IdCliente),
                _conexion.crearParametro("@nombre_cliente",
                    cliente.NombreCliente),
                _conexion.crearParametro("@apellido_cliente",
                    cliente.ApellidoCliente),
                _conexion.crearParametro("@dni_cliente",
                    cliente.DniCliente),
                _conexion.crearParametro("@condicion_fiscal",
                    cliente.CondicionFiscal ?? ""),
                _conexion.crearParametro("@cuit",
                    cliente.CuitCliente ?? ""),
                _conexion.crearParametro("@razon_social",
                    cliente.RazonSocial ?? "")
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure(
                "sp_ModificarCliente", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo modificar el cliente.");
        }

        public void EliminarCliente(int idCliente)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_cliente", idCliente)
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure(
                "sp_EliminarCliente", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo eliminar el cliente.");
        }

        public bool ExisteDniOCuit(string valor)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@valor", valor)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure(
                "sp_BuscarClientePorDniOCuit", parametros);

            return tabla != null && tabla.Rows.Count > 0;
        }
    }
}
