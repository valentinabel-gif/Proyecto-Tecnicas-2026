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
using BLL_Libreria;

namespace UI_Libreria.Administrador
{
    public partial class FormEditarCategoria : Form
    {
        private Categoria _categoria;
        private CategoriaBLL _categoriaBLL;
        public FormEditarCategoria(Categoria categoria, CategoriaBLL categoriaBLL)
        {
            InitializeComponent();
            _categoria = categoria;
            _categoriaBLL = categoriaBLL;
        }

        private void FormEditarCategoria_Load(object sender, EventArgs e)
        {
            txtEditarCategoria.Text = _categoria.NombreCategoria;
        }

        private void txtEditarCategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtEditarCategoria.Text))
                    throw new Exception("El nombre de la categoría es obligatorio.");

                _categoriaBLL.ModificarCategoria(_categoria.IdCategoria, txtEditarCategoria.Text.Trim());
                MessageBox.Show("Categoría modificada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
