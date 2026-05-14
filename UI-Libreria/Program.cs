using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Libreria.EncargadoDeStock;
<<<<<<< HEAD
using UI_Libreria.Administrador;
=======
using UI_Libreria.VendedorMayorista;
>>>>>>> main

namespace UI_Libreria
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new Inicioadministrador());
=======
            //Application.Run(new InicioEncargadoStock()); 
            Application.Run(new FormVendedor());
>>>>>>> main
        }
    }
}
