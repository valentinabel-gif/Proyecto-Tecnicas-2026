using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_Libreria;
using BE_Libreria;

namespace UI_Libreria.Administrador
{
    public partial class FormCrearCategoria : Form
    {
        private CategoriaBLL _categoriaBLL;
        public FormCrearCategoria(CategoriaBLL categoriaBLL)
        {
            InitializeComponent();
            _categoriaBLL = categoriaBLL;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCrearCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btcCrearCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCrearCategoria.Text))
                    throw new Exception("El nombre de la categoría es obligatorio.");

                _categoriaBLL.CrearCategoria(txtCrearCategoria.Text.Trim());
                MessageBox.Show("Categoría creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
