using SanJustino.Data;
using SanJustino.Forms.Profes;
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

namespace SanJustino.Forms.Deportes
{
    public partial class FrmNuevoEditarDeporte : Form
    {
        ClubSanJustinoContext context = new ClubSanJustinoContext();
        RepositoryDeportes repositoryDeportes = new RepositoryDeportes();

        //Campos que se utilizan si se modifica un deporte
        int idModificado = 0;
        Deporte deporte = new Deporte();


        public FrmNuevoEditarDeporte()
        {
            InitializeComponent();
            CargarComboProfes();
        }

        private void CargarComboProfes()
        {
            cboProfesor.DataSource = context.Profesores.ToList();
            cboProfesor.DisplayMember = "Nombre";
            cboProfesor.ValueMember = "Id";
        }

        public FrmNuevoEditarDeporte(int idAModificar)
        {
            InitializeComponent();
            this.idModificado = idAModificar;
            CargarComboProfes();
            CargarDatosDeDeporteAModificar();
        }

        private void CargarDatosDeDeporteAModificar()
        {
            deporte = repositoryDeportes.GetById(this.idModificado);
            txtNombre.Text = deporte.Nombre;
            txtHorario.Text = deporte.Horarios;
            cboProfesor.SelectedValue = deporte.ProfesorId ?? 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            deporte.Nombre = txtNombre.Text;
            deporte.Horarios = txtHorario.Text;
            deporte.ProfesorId = (int)cboProfesor.SelectedValue;

            if (this.idModificado == 0)
            {
                repositoryDeportes.Add(deporte);
            }
            else
            {
                deporte.Id = this.idModificado;
                repositoryDeportes.Update(deporte);
            }
            this.Close();
        }

        private void btnAgregarModoficarProfes_Click(object sender, EventArgs e)
        {
            FrmProfes frmProfes = new FrmProfes();
            frmProfes.ShowDialog();
            CargarComboProfes();
            
        }
    }
}
