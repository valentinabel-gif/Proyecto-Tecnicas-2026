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
    public partial class admiInicio : UserControl
    {
        public admiInicio()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearUsuInicio_Click(object sender, EventArgs e)
        {
            FormCrearUsuario form = new FormCrearUsuario();
            form.Show();
        }
    }
}
