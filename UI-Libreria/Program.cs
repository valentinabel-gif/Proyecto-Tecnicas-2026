using System;
using System.Windows.Forms;


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

            //Application.Run(new FormVendedor());

            //Application.Run(new InicioEncargadoStock()); 
            //Application.Run(new Inicioadministrador());
            Application.Run(new login());
            //Application.Run(new Gerente.inicioGerente());

        }
    }
}
