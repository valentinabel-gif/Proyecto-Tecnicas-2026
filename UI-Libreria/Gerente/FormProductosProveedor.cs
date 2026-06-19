using BE_Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI_Libreria.EncargadoDeStock;

namespace UI_Libreria.Gerente
{
    public partial class FormProductosProveedor : Form
    {
        private List<Producto> _productos;
        public FormProductosProveedor(List<Producto> productos)
        {
            InitializeComponent();
            _productos = productos;
        }

        private void FormProductosProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _productos;
        }
    }
}
