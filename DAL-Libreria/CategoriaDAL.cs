using System;
using System.Collections.Generic;
using System.Data;
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





    }
}
