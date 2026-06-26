using BE_Libreria;
using BLL_Libreria;
using BLL_Libreria.Seguridad_y_Usuario___Login;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Libreria.Administrador
{
    public partial class FormEditarUsuario : Form
    {
        //private Usuario _usuario;
        private UsuarioBLL _usuarioBLL;
        private int id_usuario;
        public FormEditarUsuario(int idusuario, UsuarioBLL usuarioBLL)
        {
            InitializeComponent();
            id_usuario = idusuario;
            //_usuario = usuario;
            _usuarioBLL = usuarioBLL;
        }

        private void FormEditarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                // Carga los roles en el combo
                RolBLL rolBLL = new RolBLL();
                List<Rol> roles = rolBLL.ObtenerRoles();
                cmbRol.DataSource = roles;
                cmbRol.DisplayMember = "NombreMedidaDeSeguridad";
                cmbRol.ValueMember = "IdMedidaDeSeguridad";

                // Carga los datos del usuario en los campos
                // UsuarioBLL usuarioBLL = new UsuarioBLL();
                Usuario usuario = _usuarioBLL.RecuperarUsuarioPorId(id_usuario);

                txtNombre.Text = usuario.NombreUsuario;
                txtApellido.Text = usuario.ApellidoUsuario;
                txtDni.Text = usuario.DniUsuario;
                txtUsuario.Text = usuario.UsernameUsuario;
                txtCorreo.Text = usuario.CorreoUsuario;
                cmbRol.SelectedValue = usuario.RolUsuario.IdMedidaDeSeguridad;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text.Trim();
                string apellido = txtApellido.Text.Trim();
                string correo = txtCorreo.Text.Trim();
                string dni = txtDni.Text.Trim();
                string username = txtUsuario.Text.Trim();

                if (string.IsNullOrWhiteSpace(nombre))
                    throw new Exception("El nombre es obligatorio.");
                if (string.IsNullOrWhiteSpace(apellido))
                    throw new Exception("El apellido es obligatorio.");
                if (string.IsNullOrWhiteSpace(username))
                    throw new Exception("El nombre de usuario es obligatorio.");
                if (string.IsNullOrWhiteSpace(correo))
                    throw new Exception("El correo es obligatorio.");
                if (!correo.Contains("@") || !correo.Contains("."))
                    throw new Exception("El correo no tiene un formato válido.");
                if (cmbRol.SelectedItem == null)
                    throw new Exception("Debe seleccionar un rol.");

                Rol rolSeleccionado = (Rol)cmbRol.SelectedItem;

                Usuario usuarioModificado = new Usuario(id_usuario, nombre, apellido, correo, dni, "", username, rolSeleccionado);

                //UsuarioBLL usuarioBLL = new UsuarioBLL();
                _usuarioBLL.ModificarUsuario(usuarioModificado);

                MessageBox.Show("Usuario modificado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir sin guardar?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // nombre, solo leytras y espacio
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        // apellido solo letras y espacio
        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        // valida que dni solo tenga numeros 
        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        // usuario, letra,numero,guion y guin bajo
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '_' || e.KeyChar == '-' || char.IsControl(e.KeyChar));
        }

        // correo, letras,numeros, y caracteres como . y _
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_' || e.KeyChar == '-' || char.IsControl(e.KeyChar));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
