using BE_Libreria.Ventas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Libreria
{
    public class VendedorDAL
    {
        private Conexion _conexion = new Conexion();

        public List<Vendedor> BuscarVendedor(string busqueda) {

        SqlParameter[] parametros = new SqlParameter[]

            {
                _conexion.crearParametro("@busqueda", busqueda)
            };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_BuscarVendedores", parametros);
            List<Vendedor> vendedores = new List<Vendedor>();
            if (tabla != null)
            {
                foreach(DataRow fila in tabla.Rows)
                {
                    vendedores.Add(new Vendedor(Convert.ToInt32(fila["id_usuario"]),
                    fila["nombre"].ToString() + " " + fila["apellido"].ToString(),0, 0));
                }
            }
            return vendedores;

        }

    public Vendedor TraerEstadisticas (int IdUsuario)
        {
            SqlParameter[] parametros = new SqlParameter[]
                    {
            _conexion.crearParametro("@id_usuario", IdUsuario)
                    };

            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_EstadisticasVendedor", parametros);

            if (tabla != null && tabla.Rows.Count > 0)
            {
                DataRow fila = tabla.Rows[0];
                return new Vendedor(IdUsuario, fila["vendedor"].ToString(),Convert.ToInt32(fila["ventas"]),Convert.ToDecimal(fila["total"]));
            }
            return null;
        }
    }
}
