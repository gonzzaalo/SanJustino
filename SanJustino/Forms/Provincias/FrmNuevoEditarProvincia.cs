using SanJustino.Models;
using SanJustino.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanJustino.Forms.Provincias
{
    public partial class FrmNuevoEditarProvincia : Form
    {

        RepositoryProvincias repositoryProvincias = new RepositoryProvincias();
        Provincia provincia = new Provincia();
        int idProvinciaEditada = 0;

        public int IdAgregadoEditado { get; set; }
        public FrmNuevoEditarProvincia()
        {
            InitializeComponent();
        }

        public FrmNuevoEditarProvincia(int idProvinciaAModificar)
        {
            InitializeComponent();
            this.idProvinciaEditada = idProvinciaAModificar;
            CargarDatosDeLaProvincia();
        }

        private void CargarDatosDeLaProvincia()
        {
            provincia = repositoryProvincias.GetById(this.idProvinciaEditada);
            if (provincia != null)
            {
                txtNombre.Text = provincia.Nombre;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            provincia.Nombre = txtNombre.Text;

            if ( this.idProvinciaEditada == 0)
            {
                repositoryProvincias.Add(provincia);
            }
            else
            {
                repositoryProvincias.Update(provincia);
            }
            this.IdAgregadoEditado = provincia.Id;
            this.Close();
        }
    }
}
