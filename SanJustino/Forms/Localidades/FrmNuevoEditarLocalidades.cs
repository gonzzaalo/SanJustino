using SanJustino.Forms.Provincias;
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
    public partial class FrmNuevoEditarLocalidades : Form
    {
        RepositoryLocalidades repositoryLocalidades = new RepositoryLocalidades();
        RepositoryProvincias repositoryProvincias = new RepositoryProvincias();

        public int IdAgregadoModificado { get; set; }

        //Campos que utilizamos si modificamos a  un contacto
        int idModificado = 0;
        Localidad localidad = new Localidad();
        public FrmNuevoEditarLocalidades()
        {
            InitializeComponent();
            CargarComboProvincias();
        }

        private void CargarComboProvincias()
        {
            cboProvincia.DataSource = repositoryProvincias.GetAll();
            cboProvincia.DisplayMember = "Nombre";
            cboProvincia.ValueMember = "Id";

        }

        public FrmNuevoEditarLocalidades(int idAModificar)
        {
            InitializeComponent();
            this.idModificado = idAModificar;
            CargarComboProvincias();
            CargarDatosDeLocalidadAModificar();
        }

        private void CargarDatosDeLocalidadAModificar()
        {
            localidad = repositoryLocalidades.GetById(this.idModificado);

            txtNombre.Text = localidad.Nombre;
            txtLocalidad.Text = localidad.CodigoPostal;
            cboProvincia.SelectedValue = localidad.ProvinciaId ?? 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            localidad.Nombre = txtNombre.Text;
            localidad.CodigoPostal = txtLocalidad.Text;
            localidad.ProvinciaId = (int)cboProvincia.SelectedValue;

            if (this.idModificado == 0)
            {
                repositoryLocalidades.Add(localidad);
            }
            else
            {
                localidad.Id = this.idModificado;
                repositoryLocalidades.Update(localidad);
            }
            this.IdAgregadoModificado = localidad.Id;
            this.Close();
        }

        private void btnNuevoAgregarProvincia_Click(object sender, EventArgs e)
        {

            FrmProvincias frmProvincias = new FrmProvincias();
            frmProvincias.ShowDialog();
            CargarComboProvincias();
        }
    }
}
