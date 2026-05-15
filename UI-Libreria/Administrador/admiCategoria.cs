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
    public partial class admiCategoria : UserControl
    {
        public admiCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admiCategoria_Load(object sender, EventArgs e)
        {

            dgvCategorias.Rows.Add("1", "Bebidas");

            dgvCategorias.Rows.Add("2", "Golosinas");

            dgvCategorias.Rows.Add("3", "Lácteos");
        }
    }
    }

