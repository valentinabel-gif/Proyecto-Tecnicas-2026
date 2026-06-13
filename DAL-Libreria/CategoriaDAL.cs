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
    public class CategoriaDAL
    {
        private Conexion _conexion = new Conexion();


        public int ContarCategoria()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_ContarCategorias");

            if (tabla != null && tabla.Rows.Count > 0)
            {
                return Convert.ToInt32(tabla.Rows[0]["CantidadCategorias"]);
            }
            return 0;
        }

        //recupero las categorias de la base de datos
        public List<Categoria> RecuperarCategorias()
        {
            DataTable tabla = _conexion.LeerPorStoreProcedure("sp_RecuperarCategorias");
            List<Categoria> categorias = new List<Categoria>();

            if (tabla != null)
            {
                foreach (DataRow fila in tabla.Rows)
                {
                    categorias.Add(new Categoria(Convert.ToInt32(fila["id_categoria"]),fila["nombre_categoria"].ToString()));
                }
            }
            return categorias;
        }

        //elimino categoria de la base de datos

        public void EliminarCategoria(int idCategoria)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_categoria", idCategoria)
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure("sp_EliminarCategoria", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo eliminar la categoría.");
        }


        //modifico categoria de la base de datos

        public void ModificarCategoria(int idCategoria, string nuevoNombre)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@id_categoria", idCategoria),
                _conexion.crearParametro("@nombre_categoria", nuevoNombre)
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure("sp_ModificarCategoria", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo modificar la categoría.");
        }

        //creo categoria en la base de datos

        public void CrearCategoria(string nombreCategoria)
        {
            SqlParameter[] parametros = new SqlParameter[]
            {
                _conexion.crearParametro("@nombre_categoria", nombreCategoria)
            };

            int filasAfectadas = _conexion.EscribirPorStoreProcedure("sp_CrearCategoria", parametros);

            if (filasAfectadas <= 0)
                throw new Exception("No se pudo crear la categoría.");
        }








    }
}
