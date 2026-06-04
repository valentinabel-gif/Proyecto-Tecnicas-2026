using System;
using System.Windows.Forms;

namespace UI_Libreria.EncargadoDeStock
{
    public partial class UcProductos : UserControl
    {
        public UcProductos()
        {
            InitializeComponent();

            ConfigurarTabla();
            CargarProductos();
        }

        private void ConfigurarTabla()
        {
            dataGridView1.AllowUserToAddRows = false;

            // COLUMNAS
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Precio", "Precio");

            // BOTON EDITAR
            DataGridViewButtonColumn btnEditar = new DataGridViewButtonColumn();

            btnEditar.Name = "Editar";
            btnEditar.HeaderText = "Editar";
            btnEditar.Text = "✏️";
            btnEditar.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btnEditar);

            // BOTON ELIMINAR
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();

            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "Eliminar";
            btnEliminar.Text = "🗑";
            btnEliminar.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(btnEliminar);
        }

        private void CargarProductos()
        {
            dataGridView1.Rows.Add(1, "Mouse", 15000);
            dataGridView1.Rows.Add(2, "Teclado", 30000);
            dataGridView1.Rows.Add(3, "Monitor", 120000);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            // ELIMINAR
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }

            // EDITAR
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                MessageBox.Show("Editar producto");
            }
        }
    }
}
