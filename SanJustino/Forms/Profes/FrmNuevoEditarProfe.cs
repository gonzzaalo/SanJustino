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

namespace SanJustino.Forms.Profes
{
    public partial class FrmNuevoEditarProfe : Form
    {
        RepositoryProfesores repositoryProfesores = new RepositoryProfesores();

        public int IdAgregadoModificado { get; set; }

        //Campos que se usan para modificar un deporte
        int idModificado = 0;
        Profesor profesor = new Profesor();

        public FrmNuevoEditarProfe()
        {
            InitializeComponent();
        }

        public FrmNuevoEditarProfe(int idAModificar)
        {
            InitializeComponent();
            this.idModificado = idAModificar;
            CargarDatosDeProfesAModificar();
        }

        private void CargarDatosDeProfesAModificar()
        {
            profesor = repositoryProfesores.GetById(this.idModificado);

            txtNombre.Text = profesor.Nombre;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            profesor.Nombre = txtNombre.Text;


            if (this.idModificado == 0)
            {
                repositoryProfesores.Add(profesor);
            }
            else
            {
                profesor.Id = this.idModificado;
                repositoryProfesores.Update(profesor);
            }
            this.IdAgregadoModificado = profesor.Id;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
