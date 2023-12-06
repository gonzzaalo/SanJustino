using SanJustino.Models;
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

namespace SanJustino.Forms.Localidades
{
    public partial class FrmLocalidades : Form
    {
        RepositoryLocalidades repositoryLocalidades = new RepositoryLocalidades();


        public FrmLocalidades()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            dataGridLocalidades.DataSource = repositoryLocalidades.GetAll();

        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrillaFiltrada();
        }

        private void CargarGrillaFiltrada()
        {
            dataGridLocalidades.DataSource = repositoryLocalidades.GetAll(txtBusqueda.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarLocalidades frmNuevoEditarLocalidades = new FrmNuevoEditarLocalidades();
            frmNuevoEditarLocalidades.ShowDialog();
            CargarGrilla();
            SeleccionarIdAgregadoModificado(frmNuevoEditarLocalidades.IdAgregadoModificado);

        }



        private void SeleccionarIdAgregadoModificado(int idAgregadoModificado)
        {
            foreach (DataGridViewRow fila in dataGridLocalidades.Rows)
            {
                if ((int)fila.Cells[0].Value == idAgregadoModificado)
                {
                    dataGridLocalidades.CurrentCell = fila.Cells[0];
                    break;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Obtenemos el id a Modificar
            int idAModificar = (int)dataGridLocalidades.CurrentRow.Cells[0].Value;

            //Llamamos al formulario Nuevo/Editar y le pasamos como argumento el IdAModificar
            FrmNuevoEditarLocalidades frmNuevoEditarLocalidades = new FrmNuevoEditarLocalidades(idAModificar);
            frmNuevoEditarLocalidades.ShowDialog();
            CargarGrilla();
            SeleccionarIdAgregadoModificado(frmNuevoEditarLocalidades.IdAgregadoModificado);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Obtenemos el id y el nombre de la localidad seleccionada
            int idABorrar = (int)dataGridLocalidades.CurrentRow.Cells[0].Value;
            string localidadABorrar = (string)dataGridLocalidades.CurrentRow.Cells[1].Value;

            //Preguntamos si esta seguro de eliminar la localidad
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea eliminar ésta localidad {localidadABorrar}?", "Eliminar localidad", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si responde si, intentamos borrar en un try
            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    repositoryLocalidades.Remove(idABorrar);
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
