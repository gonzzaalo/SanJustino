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

namespace SanJustino.Forms
{
    public partial class FrmDeportistas : Form
    {
        RepositoryDeportistas repositoryDeportistas = new RepositoryDeportistas();
        public FrmDeportistas()
        {
            InitializeComponent();
            CargarGrilla();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void CargarGrilla()
        {
            ClubSanJustinoContext context = new ClubSanJustinoContext();
            if (txtBusqueda.Text.Trim().Length > 0)
            {
                dataGridDeportistas.DataSource = repositoryDeportistas.GetAll(txtBusqueda.Text);
            }
            else
            {
                dataGridDeportistas.DataSource = repositoryDeportistas.GetAll();
            }
            dataGridDeportistas.Columns[0].Visible = false;
            dataGridDeportistas.Columns[6].Visible = false;
            dataGridDeportistas.Columns[8].Visible = false;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            FrmNuevoModificarDeportista frmNuevoModificarDeportista = new FrmNuevoModificarDeportista();
            frmNuevoModificarDeportista.ShowDialog();
            CargarGrilla();

        }

        private void Modificar_Click(object sender, EventArgs e)
        {
            // Se obtiene el ID a modificar
            int idAModificar = (int)dataGridDeportistas.CurrentRow.Cells[0].Value;

            //LLamada al formulario Nuevo/Editar y le pasamos como argumento il IdAModificar

            FrmNuevoModificarDeportista frmNuevoModificarDeportista = new FrmNuevoModificarDeportista(idAModificar);
            frmNuevoModificarDeportista.ShowDialog();
            CargarGrilla();
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Obtenemos el id y el nombre del deportista seleccionado
            int idABorrar = (int)dataGridDeportistas.CurrentRow.Cells[0].Value;
            string deportistaABorrar = (string)dataGridDeportistas.CurrentRow.Cells[1].Value + " " + dataGridDeportistas.CurrentRow.Cells[2].Value;

            //Preguntamos si esta seguro de querer Eliminar
            DialogResult pregunta = MessageBox.Show($"¿Está seguro que desea Eliminar al deportista {deportistaABorrar} ?", "Eliminar Contacto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Si responde si, intentamos eliminar en un try
            if(pregunta == DialogResult.Yes)
            {
                try
                {
                    repositoryDeportistas.Remove(idABorrar);
                    CargarGrilla();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}
