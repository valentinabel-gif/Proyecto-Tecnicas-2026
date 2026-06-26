using BE_Libreria;
using BE_Libreria.Stock;
using BLL_Libreria;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI_Libreria.Administrador
{
    public partial class admiCategoria : UserControl, IObservadorCategoria
    {

        private List<Categoria> _listaCategorias = new List<Categoria>();
        private CategoriaBLL _categoriaBLL;
        public admiCategoria(CategoriaBLL categoriaBLL)
        {
            InitializeComponent();
            _categoriaBLL = categoriaBLL;
            _categoriaBLL.RegistrarObservador(this);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void admiCategoria_Load(object sender, EventArgs e)
        {
            DatosGrilla();
            CargarListaCategorias();
        }

        private void DatosGrilla()
        {
            dgvCategorias.AutoGenerateColumns = false;
            dgvCategorias.Columns.Clear();

            dgvCategorias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ID", DataPropertyName = "IdCategoria", Width = 50 });
            dgvCategorias.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nombre", DataPropertyName = "NombreCategoria", Width = 200 });
            dgvCategorias.Columns.Add(new DataGridViewButtonColumn { Name = "colEliminarCategoria", HeaderText = "", Text = "ELIMINAR", UseColumnTextForButtonValue = true, Width = 100 });
            dgvCategorias.Columns.Add(new DataGridViewButtonColumn { Name = "colEditarCategoria", HeaderText = "", Text = "EDITAR", UseColumnTextForButtonValue = true, Width = 100 });
        }

        private void CargarListaCategorias()
        {
            _listaCategorias = _categoriaBLL.RecuperarCategorias();
            dgvCategorias.DataSource = new List<Categoria>(_listaCategorias);
        }

        public void Actualizar()
        {
            CargarListaCategorias();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormCrearCategoria formCrear = new FormCrearCategoria(_categoriaBLL);
            formCrear.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCategorias_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Categoria categoriaSeleccionada = _listaCategorias[e.RowIndex];

            if (dgvCategorias.Columns[e.ColumnIndex].Name == "colEditarCategoria")
            {
                FormEditarCategoria formEditar = new FormEditarCategoria(categoriaSeleccionada, _categoriaBLL);
                formEditar.ShowDialog();
            }

            if (dgvCategorias.Columns[e.ColumnIndex].Name == "colEliminarCategoria")
            {
                DialogResult confirmacion = MessageBox.Show(
                    $"¿Está seguro que desea eliminar la categoría {categoriaSeleccionada.NombreCategoria}?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        _categoriaBLL.EliminarCategoria(categoriaSeleccionada.IdCategoria);
                        MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }

            }
        }
    }
}

