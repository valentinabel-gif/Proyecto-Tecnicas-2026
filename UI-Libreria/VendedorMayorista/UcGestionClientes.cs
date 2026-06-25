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

namespace UI_Libreria.VendedorMayorista
{
    public partial class UcGestionClientes : UserControl
    {
        private ClienteBLL _clienteBLL = new ClienteBLL();
        private Cliente _clienteSeleccionado;
        public UcGestionClientes()
        {
            InitializeComponent();
        }

        private void UcGestionClientes_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            CargarClientes();
        }

        // ─── CONFIGURAR GRILLA ───

        private void ConfigurarGrilla()
        {
            dgvClientes.ReadOnly = true;
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.MultiSelect = false;
            dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        // ─── CARGAR TODOS LOS CLIENTES ───

        private void CargarClientes()
        {
            try
            {
                List<Cliente> clientes = _clienteBLL.ObtenerTodos();

                DataTable tabla = new DataTable();
                tabla.Columns.Add("ID");
                tabla.Columns.Add("Nombre");
                tabla.Columns.Add("Apellido");
                tabla.Columns.Add("DNI");
                tabla.Columns.Add("CUIT");
                tabla.Columns.Add("Razón Social");
                tabla.Columns.Add("Condición Fiscal");

                foreach (Cliente c in clientes)
                {
                    tabla.Rows.Add(
                        c.IdCliente,
                        c.NombreCliente,
                        c.ApellidoCliente,
                        c.DniCliente,
                        c.CuitCliente,
                        c.RazonSocial,
                        c.CondicionFiscal
                    );
                }

                dgvClientes.DataSource = tabla;

                if (dgvClientes.Columns["ID"] != null)
                {
                    dgvClientes.Columns["ID"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── SELECCIONAR FILA → LLENAR CAMPOS ───

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow fila = dgvClientes.Rows[e.RowIndex];

            txtNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            txtApellido.Text = fila.Cells["Apellido"].Value?.ToString();
            txtDNI.Text = fila.Cells["DNI"].Value?.ToString();
            txtCUIT.Text = fila.Cells["CUIT"].Value?.ToString();
            txtRazonSocial.Text = fila.Cells["Razón Social"].Value?.ToString();
            txtCondicionFiscal.Text = fila.Cells["Condición Fiscal"].Value?.ToString();

            int idSeleccionado = Convert.ToInt32(fila.Cells["ID"].Value);
            _clienteSeleccionado = _clienteBLL.ObtenerPorId(idSeleccionado);

            btnAgregar.Enabled = false;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        // ─── LIMPIAR CAMPOS ───

        private void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
            txtCUIT.Text = "";
            txtRazonSocial.Text = "";
            txtCondicionFiscal.Text = "";
            _clienteSeleccionado = null;
            btnAgregar.Enabled = true;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // ─── AGREGAR ───

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                if (!string.IsNullOrWhiteSpace(txtDNI.Text) && _clienteBLL.ExisteCuit(txtDNI.Text))
                {
                    MessageBox.Show("El DNI ingresado ya pertenece a un cliente registrado.", "DNI duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrWhiteSpace(txtCUIT.Text) && _clienteBLL.ExisteCuit(txtCUIT.Text))
                {
                    MessageBox.Show("El CUIT ingresado ya pertenece a un cliente registrado.", "CUIT duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Cliente nuevoCliente = new Cliente(0, txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCondicionFiscal.Text, txtRazonSocial.Text, txtCUIT.Text);

                _clienteBLL.AgregarCliente(nuevoCliente);

                MessageBox.Show("Cliente agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── MODIFICAR ───

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_clienteSeleccionado == null)
            {
                MessageBox.Show("Seleccione un cliente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarCampos())
            {
                return;
            }

            try
            {
                Cliente clienteModificado = new Cliente(_clienteSeleccionado.IdCliente, txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCondicionFiscal.Text, txtRazonSocial.Text, txtCUIT.Text);

                _clienteBLL.ModificarCliente(clienteModificado);

                MessageBox.Show("Cliente modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─── ELIMINAR ───

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_clienteSeleccionado == null)
            {
                MessageBox.Show( "Seleccione un cliente de la lista.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show( $"¿Está seguro que desea eliminar a " + $"{_clienteSeleccionado.NombreCliente} " + $"{_clienteSeleccionado.ApellidoCliente}?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    _clienteBLL.EliminarCliente(_clienteSeleccionado.IdCliente);

                    MessageBox.Show("Cliente eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    CargarClientes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool ValidarCampos()
        {
            //nombre obligatorio y solo letras
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }
            foreach (char c in txtNombre.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("El nombre solo puede contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNombre.Focus();
                    return false;
                }
            }

            //apellido obligatorio y solo letras
            if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El apellido es obligatorio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtApellido.Focus();
                return false;
            }
            foreach (char c in txtApellido.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("El apellido solo puede contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtApellido.Focus();
                    return false;
                }
            }

            //dni 7 u 8 digitos solo num
            if (!string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                foreach (char c in txtDNI.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("El DNI solo puede contener números.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtDNI.Focus();
                        return false;
                    }
                }
                if (txtDNI.Text.Length != 7 && txtDNI.Text.Length != 8)
                {
                    MessageBox.Show("El DNI debe tener 7 u 8 dígitos.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDNI.Focus();
                    return false;
                }
            }

            //cuit 11 digitos
            if (!string.IsNullOrWhiteSpace(txtCUIT.Text))
            {
                foreach (char c in txtCUIT.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        MessageBox.Show("El CUIT solo puede contener números, sin guiones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCUIT.Focus();
                        return false;
                    }
                }
                if (txtCUIT.Text.Length != 11)
                {
                    MessageBox.Show("El CUIT debe tener exactamente 11 dígitos.","Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCUIT.Focus();
                    return false;
                }
            }

            //al menos DNI o CUIT obligatorio
            if (string.IsNullOrWhiteSpace(txtDNI.Text) && string.IsNullOrWhiteSpace(txtCUIT.Text))
            {
                MessageBox.Show("Debe ingresar al menos un DNI o CUIT.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            //cond fiscal obligatoria y solo letras
            if (string.IsNullOrWhiteSpace(txtCondicionFiscal.Text))
            {
                MessageBox.Show("La condición fiscal es obligatoria.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCondicionFiscal.Focus();
                return false;
            }
            foreach (char c in txtCondicionFiscal.Text)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    MessageBox.Show("La condición fiscal solo puede contener letras.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCondicionFiscal.Focus();
                    return false;
                }
            }

            return true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
