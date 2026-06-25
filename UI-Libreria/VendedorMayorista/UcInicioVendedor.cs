using BE_Libreria;
using BLL_Libreria;
using BLL_Libreria.Seguridad_y_Usuario___Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Libreria.VendedorMayorista
{
    public partial class UcInicioVendedor : UserControl
    {
        public UcInicioVendedor()
        {
            InitializeComponent();
            this.Load += UcInicioVendedor_Load;
        }

        private void UcInicioVendedor_Load(object sender, EventArgs e)
        {
            string nombre = Sesion.Instancia.HaySesionActiva() ? Sesion.Instancia.UsuarioActivo.NombreUsuario : "Vendedor";

            lblBienvenida.Text = $"¡Bienvenido, {nombre}!";
            lblBienvenida.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(40, 80, 140);
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;

            lblFecha.Text = DateTime.Now.ToString("dddd, d 'de' MMMM 'de' yyyy", new CultureInfo("es-AR"));
            lblFecha.Font = new Font("Segoe UI", 13, FontStyle.Regular);
            lblFecha.ForeColor = Color.Gray;
            lblFecha.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
    }
}
