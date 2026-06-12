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
        //private ClienteBLL _clienteBLL = new ClienteBLL();
        public UcGestionClientes()
        {
            InitializeComponent();
        }

        private void UcGestionClientes_Load(object sender, EventArgs e)
        {
            try
            {
                // 2. Poblamos la grilla automáticamente al abrir la pantalla
                //dgvClientes.DataSource = _clienteBLL.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el listado de clientes: {ex.Message}");
            }
        }

        // Eventos para los botones que agregaste abajo a la izquierda
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Mañana meteremos la lógica para armar el objeto 'new Cliente(...)' 
            // con lo que el usuario escribió en los TextBox y pasárselo a la BLL
        }
    }
}
