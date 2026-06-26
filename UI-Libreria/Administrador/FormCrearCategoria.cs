using BLL_Libreria;
using System;
using System.Windows.Forms;

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
            DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
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
                {
                    throw new Exception("El nombre de la categoría es obligatorio.");
                }

                _categoriaBLL.CrearCategoria(txtCrearCategoria.Text.Trim());
                MessageBox.Show("Categoría creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtCrearCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
