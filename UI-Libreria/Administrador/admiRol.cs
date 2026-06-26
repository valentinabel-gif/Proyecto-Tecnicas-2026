using BE_Libreria;
using BE_Libreria.Seguridad_y_Usuario;
using BLL_Libreria.Seguridad_y_Usuario___Login;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace UI_Libreria.Administrador
{
    public partial class admiRol : UserControl, IObservadorRol
    {
        private List<Rol> _listaRoles = new List<Rol>();
        private RolBLL _rolBll;

        public admiRol(RolBLL rolBLL)
        {
            InitializeComponent();
            _rolBll = rolBLL;
            _rolBll = rolBLL;
            _rolBll.RegistrarObservador(this);

        }

        private void admiRol_Load(object sender, EventArgs e)
        {
            DatosGrilla();
            CargarListaRoles();

        }

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Rol rolSeleccionado = _listaRoles[e.RowIndex];

            if (dgvRoles.Columns[e.ColumnIndex].Name == "colModificarRol")
            {
                FormEditarRol formEditar = new FormEditarRol(rolSeleccionado, _rolBll);
                formEditar.ShowDialog();
                CargarListaRoles(); // recarga al volver
            }

            if (dgvRoles.Columns[e.ColumnIndex].Name == "colEliminarRol")
            {
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea eliminar el rol {rolSeleccionado.NombreMedidaDeSeguridad}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        _rolBll.EliminarRol(rolSeleccionado.IdMedidaDeSeguridad);
                        MessageBox.Show("Rol eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarListaRoles();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }

        public void DatosGrilla()
        {
            dgvRoles.AutoGenerateColumns = false;
            dgvRoles.Columns.Clear();

            dgvRoles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "IdMedidaDeSeguridad", Width = 50 });
            dgvRoles.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre Rol", DataPropertyName = "NombreMedidaDeSeguridad", Width = 150 });
            dgvRoles.Columns.Add(new DataGridViewButtonColumn { Name = "colEliminarRol", HeaderText = "", Text = "ELIMINAR ROL", UseColumnTextForButtonValue = true, Width = 120 });
            dgvRoles.Columns.Add(new DataGridViewButtonColumn { Name = "colModificarRol", HeaderText = "", Text = "MODIFICAR ROL", UseColumnTextForButtonValue = true, Width = 120 });

        }

        public void CargarListaRoles()
        {
            _listaRoles = _rolBll.ObtenerRoles();
            dgvRoles.DataSource = new List<Rol>(_listaRoles);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelbuscarRol_TextChanged(object sender, EventArgs e)
        {
            btnBuscarRol_Click(sender, e);
        }

        private void btnBuscarRol_Click(object sender, EventArgs e)
        {
            string RolBuscado = labelbuscarRol.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(RolBuscado))
            {
                dgvRoles.DataSource = new List<Rol>(_listaRoles);
                lblBusqueda.Visible = false;
                return;
            }

            List<Rol> filtrados = _listaRoles
                .Where(u => u.NombreMedidaDeSeguridad.ToLower().Contains(RolBuscado)).ToList();

            dgvRoles.DataSource = filtrados;

            if (filtrados.Count == 0)
            {
                lblBusqueda.Visible = true;
            }
            else
            {
                lblBusqueda.Visible = false;
            }
        }

        public void Actualizar()
        {
            CargarListaRoles();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormCrearRol form = new FormCrearRol(_rolBll);
            form.ShowDialog();
        }

        private void lblBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}
