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
    public partial class admiInicio : UserControl
    {

        private UsuarioBLL _usuarioBLL = new UsuarioBLL();
        private RolBLL _rolBLL = new RolBLL();

        private UsuarioBLL _listaUsuarioBLL = new UsuarioBLL();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admiInicio_Load(object sender, EventArgs e)
        {
            CargarEstadisticas();
            DatosGrilla();
            CargarListaUsuarios();

        }

        private void CargarEstadisticas()
        {
            cantUsuarios.Text = _usuarioBLL.ContarUsuarios().ToString();
            cantRoles.Text = _rolBLL.ContarRoles().ToString();
            cantPermisos.Text = _rolBLL.ContarPermisos().ToString();
        }
        private void DatosGrilla()
        {
            ListaUsuarios.AutoGenerateColumns = false;
            ListaUsuarios.Columns.Clear();

            ListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Usuario", DataPropertyName = "UsernameUsuario", Width = 150 });
            ListaUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            { HeaderText = "Rol", DataPropertyName = "NombreRolUsuario", Width = 150 });
        }

        private void CargarListaUsuarios()
        {
            List<Usuario> usuarios = _usuarioBLL.RecuperarTodosLosUsuarios();
            ListaUsuarios.DataSource = usuarios;
        }
    }
}
