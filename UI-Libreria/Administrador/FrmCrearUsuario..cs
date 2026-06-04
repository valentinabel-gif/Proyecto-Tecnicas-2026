using BE_Libreria;
using BLL_Libreria;
using BLL_Libreria.Seguridad_y_Usuario___Login;
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
    public partial class FormCrearUsuario : Form
    {
        public FormCrearUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelDNI_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RolBLL bll = new RolBLL();
            List<Rol> roles = bll.ObtenerRoles();

            comboBoxRoles.DataSource = roles;
            comboBoxRoles.DisplayMember = "NombreMedidaDeSeguridad";
            comboBoxRoles.ValueMember = "IdMedidaDeSeguridad";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string correo = txtCorreo.Text;
                string dni = txtDNI.Text;
                string contrasena = txtContrasena.Text;
                string username = txtUsername.Text;
                if (string.IsNullOrWhiteSpace(nombre))
                { throw new Exception("El nombre es obligatorio."); }
                if (string.IsNullOrWhiteSpace(apellido))
                { throw new Exception("El apellido es obligatorio."); }
                if (string.IsNullOrWhiteSpace(correo))
                { throw new Exception("El correo es obligatorio."); }
                if (string.IsNullOrWhiteSpace(dni))
                { throw new Exception("El dni es obligatorio."); }
                if (string.IsNullOrWhiteSpace(contrasena))
                { throw new Exception("La contraseña es obligatorio."); }
                if (string.IsNullOrWhiteSpace(username))
                { throw new Exception("El usuario es obligatorio."); }

                if (comboBoxRoles.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar un rol para el usuario.");
                }

                Rol rolSeleccionado = (Rol)comboBoxRoles.SelectedItem;

                Usuario nuevoUsuario = new Usuario(0, nombre, apellido, correo, dni, contrasena, username, rolSeleccionado);

                UsuarioBLL _usuarioBLL = new UsuarioBLL();

                _usuarioBLL.AltaUsuario(nuevoUsuario);

                MessageBox.Show("El usuario fue creado exitosamente!","EXITO",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }

}
