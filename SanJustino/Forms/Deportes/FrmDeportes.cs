using Microsoft.EntityFrameworkCore.Diagnostics;
using SanJustino.Data;
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

namespace SanJustino.Forms.Deportes
{
    public partial class FrmDeportes : Form
    {
        RepositoryDeportes repositoryDeportes = new RepositoryDeportes();
        public FrmDeportes()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            if (txtBusqueda.Text.Trim().Length > 0)
            {
                dataGridDeportes.DataSource = repositoryDeportes.GetAll(txtBusqueda.Text);
            }
            else
            {
                dataGridDeportes.DataSource = repositoryDeportes.GetAll();
            }
            dataGridDeportes.Columns[0].Visible = false;
            dataGridDeportes.Columns[3].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarDeporte frmNuevoEditarDeporte = new FrmNuevoEditarDeporte();
            frmNuevoEditarDeporte.ShowDialog();
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Se obtiene el id y el nombre del contacto seleccionado
            int idABorrar = (int)dataGridDeportes.CurrentRow.Cells[0].Value;
            string DeporteABorrar = (string)dataGridDeportes.CurrentRow.Cells[1].Value + " " + dataGridDeportes.CurrentRow.Cells[2].Value;

            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea eliminar el deporte {DeporteABorrar}?", "Eliminar deporte", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    repositoryDeportes.Remove(idABorrar);
                    CargarGrilla();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            //Se obtiene el id a modificar
            int idAModificar = (int)dataGridDeportes.CurrentRow.Cells[0].Value;


            FrmNuevoEditarDeporte frmNuevoEditarDeporte = new FrmNuevoEditarDeporte(idAModificar);
            frmNuevoEditarDeporte.ShowDialog();
            CargarGrilla();
        }
    }
}
