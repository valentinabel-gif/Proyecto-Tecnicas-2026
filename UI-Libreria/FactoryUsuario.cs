using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Libreria.Administrador;
using UI_Libreria.EncargadoDeStock;
using UI_Libreria.Gerente;

namespace UI_Libreria
{
    public class FactoryUsuario
    {

        public static Form CrearFormulario(string rol)
        {
            switch (rol)
            {
                case "Administrador":
                    return new Inicioadministrador();

                case "Gerente":
                    return new inicioGerente();
                case "Vendedor":
                    return new FormVendedor();

                case "Encargado de Stock":
                    return new InicioEncargadoStock();
                default:
                    throw new Exception("Rol no encontrado");

            }
        }
    }
}
