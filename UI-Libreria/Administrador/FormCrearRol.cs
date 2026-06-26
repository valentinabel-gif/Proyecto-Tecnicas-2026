using BLL_Libreria.Seguridad_y_Usuario___Login;
using System;
using System.Windows.Forms;

namespace UI_Libreria.Administrador
{
    public partial class FormCrearRol : Form
    {

        private RolBLL _rolBLL;

        public FormCrearRol(RolBLL rolBLL)
        {
            InitializeComponent();
            _rolBLL = rolBLL;
        }

        private void FormCrearRol_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click_1(object sender, EventArgs e)
        {

            try
            {
                string nombreRol = txtNombreRol.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombreRol))
                {
                    throw new Exception("El nombre del rol es obligatorio.");
                }

                _rolBLL.CrearRol(nombreRol);

                MessageBox.Show("El rol fue creado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void txtNombreRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }
    }
}
