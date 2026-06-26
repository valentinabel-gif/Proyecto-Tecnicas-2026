using BE_Libreria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Libreria.Gerente
{
    public partial class FormPreciosProveedor : Form
    {
        private List<Producto> _precios;
        public FormPreciosProveedor(List<Producto> precios)
        {
            InitializeComponent();
            _precios = precios;
        }

        private void FormPreciosProveedor_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _precios;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
