using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Libreria.Administrador
{
    public partial class admiRol : UserControl
    {
        public admiRol()
        {
            InitializeComponent();
        }

        private void admiRol_Load(object sender, EventArgs e)
        {
            dgvRoles.Rows.Add("1", "Administrador", "Crear usuario");

            dgvRoles.Rows.Add("2", "Vendedor", "Agregar Porductos");

            dgvRoles.Rows.Add("3", "Encargado", "Generar Reporte");
        }
    }
}
