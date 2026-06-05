using BE_Libreria;
using BLL_Libreria;
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
    public partial class admiUsuario : UserControl
    {
        private List<Usuario> _listaUsuarios = new List<Usuario>();
        private UsuarioBLL _usuarioBLL = new UsuarioBLL();

        public admiUsuario()
        {
            InitializeComponent();
        }
        private void txtBuscar_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void admiUsuario_Load(object sender, EventArgs e)
        {

            CargarListaUsuarios();

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(textoBusqueda))
            {
                dgvUsuarios.DataSource = new List<Usuario>(_listaUsuarios);
                return;
            }

            List<Usuario> filtrados = _listaUsuarios
                .Where(u => u.UsernameUsuario.ToLower().Contains(textoBusqueda) ||
                            u.NombreRolUsuario.ToLower().Contains(textoBusqueda))
                .ToList();

            dgvUsuarios.DataSource = filtrados;
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            btnBuscarUsuario_Click(sender, e);
        }

        private void CargarListaUsuarios()
        {
            _listaUsuarios = _usuarioBLL.RecuperarTodosLosUsuarios();
            dgvUsuarios.DataSource = new List<Usuario>(_listaUsuarios);
        }
    }
}
