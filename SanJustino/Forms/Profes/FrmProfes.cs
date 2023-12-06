using SanJustino.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanJustino.Forms.Profes
{
    public partial class FrmProfes : Form
    {
        RepositoryProfesores repositoryProfesores = new RepositoryProfesores();

        public FrmProfes()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dataGridProfesores.DataSource = repositoryProfesores.GetAll();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarProfe frmNuevoEditarProfe = new FrmNuevoEditarProfe();
            frmNuevoEditarProfe.ShowDialog();
            CargarGrilla();
            SeleccionarIdAgregadoModificado(frmNuevoEditarProfe.IdAgregadoModificado);
        }

        private void SeleccionarIdAgregadoModificado(int idAgregadoModificado)
        {
            foreach (DataGridViewRow fila in dataGridProfesores.Rows)
            {
                if ((int)fila.Cells[0].Value == idAgregadoModificado)
                {
                    dataGridProfesores.CurrentCell = fila.Cells[0];
                    break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idAModificar = (int)dataGridProfesores.CurrentRow.Cells[0].Value;

            FrmNuevoEditarProfe frmNuevoEditarProfe = new FrmNuevoEditarProfe(idAModificar);
            frmNuevoEditarProfe.ShowDialog();
            CargarGrilla();
            SeleccionarIdAgregadoModificado(frmNuevoEditarProfe.IdAgregadoModificado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se obtine el id y el nombre del deporte a Eliminar
            int idABorrar = (int)dataGridProfesores.CurrentRow.Cells[0].Value;
            string ProfesorABorrar = (string)dataGridProfesores.CurrentRow.Cells[1].Value;

            //Preguntamos si esta seguro de Eliminar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea eliminar el deporte {ProfesorABorrar}?", "Eliminar deporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si responde si, eliminamos en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    repositoryProfesores.Remove(idABorrar);
                    CargarGrilla();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
