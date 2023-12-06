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

namespace SanJustino.Forms.Provincias
{
    public partial class FrmProvincias : Form
    {
        RepositoryProvincias repositoryProvincias = new RepositoryProvincias();

        public FrmProvincias()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            if (txtBusqueda.Text.Trim().Length > 0)
            {
                dataGridProvincias.DataSource = repositoryProvincias.GetAll(txtBusqueda.Text);
            }
            else
            {
                dataGridProvincias.DataSource = repositoryProvincias.GetAll();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoEditarProvincia frmNuevoEditarProvincia = new FrmNuevoEditarProvincia();
            frmNuevoEditarProvincia.ShowDialog();
            CargarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProvinciaActual = (int)dataGridProvincias.CurrentRow.Cells[0].Value;
            string nombreProvincia = (string)dataGridProvincias.CurrentRow.Cells[1].Value;

            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea eliminar la provincia {nombreProvincia}?", "Eliminar provincia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (pregunta == DialogResult.Yes)
            {
                try
                {
                    repositoryProvincias.Remove(idProvinciaActual);
                    CargarGrilla();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int idProvinciaActual = (int)dataGridProvincias.CurrentRow.Cells[0].Value;

            FrmNuevoEditarProvincia frmNuevoEditarProvincia = new FrmNuevoEditarProvincia(idProvinciaActual);
            frmNuevoEditarProvincia.ShowDialog();
            CargarGrilla();
        }
    }
}
