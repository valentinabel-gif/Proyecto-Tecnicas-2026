using BLL_Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE_Libreria;
using BLL_Libreria.Seguridad_y_Usuario___Login;

namespace UI_Libreria.VendedorMayorista
{
    public partial class UcInicioVendedor : UserControl
    {
        public UcInicioVendedor()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UcInicioVendedor_Load(object sender, EventArgs e)
        {
            if (Sesion.Instancia.HaySesionActiva())
            {
                lblBienvenida.Text = $"¡Hola, {Sesion.Instancia.UsuarioActivo.NombreUsuario}!";
            }
            else
            {
                lblBienvenida.Text = "¡Hola, Vendedor!";
            }

            lblFecha.Text = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy");
        }
    }
}
