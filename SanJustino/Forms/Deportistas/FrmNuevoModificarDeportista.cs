using SanJustino.Data;
using SanJustino.Forms.Localidades;
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

namespace SanJustino.Forms
{
    public partial class FrmNuevoModificarDeportista : Form
    {
        ClubSanJustinoContext context = new ClubSanJustinoContext();
        RepositoryDeportistas repositoryDeportistas = new RepositoryDeportistas();
        RepositoryLocalidades repositoryLocalidades = new RepositoryLocalidades();
        RepositoryProvincias repositoryProvincias = new RepositoryProvincias();

        public int IdAgregadoModificado { get; set; }

        //Campos utilizados si modificamos el deportista
        int idModificado = 0;
        Deportista deportista = new Deportista();
        Localidad localidad = new Localidad();
        Provincia provincia = new Provincia();

        public FrmNuevoModificarDeportista()
        {
            InitializeComponent();
            CargarComboLocalidad();
            CargarComboProvincias();
        }



        private void CargarComboLocalidad()
        {
            cboLocalidad.DataSource = repositoryLocalidades.GetAll();
            cboLocalidad.DisplayMember = "Nombre";
            cboLocalidad.ValueMember = "Id";
        }

        private void CargarComboProvincias()
        {
            cboProvincia.DataSource = repositoryProvincias.GetAll();
            cboProvincia.DisplayMember = "Nombre";
            cboProvincia.ValueMember = "Id";
        }

        //Constructor que se ejecuta cuando modificamos el deportista
        public FrmNuevoModificarDeportista(int idAModificar)
        {
            InitializeComponent();
            this.idModificado = idAModificar;
            CargarComboLocalidad();
            CargarComboProvincias();
            CargarDatosDeDeportistaAModificar();
        }

        private void CargarDatosDeDeportistaAModificar()
        {
            deportista = repositoryDeportistas.GetById(this.idModificado);
            txtNombre.Text = deportista.Nombre;
            txtApellido.Text = deportista.Apellido;
            txtEmail.Text = deportista.Email;
            txtTelefono.Text = deportista.Telefono;
            txtDireccion.Text = deportista.Direccion;
            cboLocalidad.SelectedValue = deportista.LocalidadId ?? 0;
            cboProvincia.SelectedValue = deportista.ProvinciaId ?? 0;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            deportista.Nombre = txtNombre.Text;
            deportista.Apellido = txtApellido.Text;
            deportista.Email = txtEmail.Text;
            deportista.Telefono = txtTelefono.Text;
            deportista.Direccion = txtDireccion.Text;
            deportista.LocalidadId = (int)cboLocalidad.SelectedValue;
            deportista.ProvinciaId = (int)cboProvincia.SelectedValue;


            if (this.idModificado == 0)
            {
                repositoryDeportistas.Add(deportista);
            }
            else
            {
                deportista.Id = this.idModificado;
                repositoryDeportistas.Update(deportista);
            }
            this.Close();
        }

        private void btnNuevoEditLocalidad_Click(object sender, EventArgs e)
        {
            FrmLocalidades frmLocalidades = new FrmLocalidades();
            frmLocalidades.ShowDialog();
            CargarComboLocalidad();
            CargarComboProvincias();
        }

        private void btnNuevoAgregarProvincia_Click(object sender, EventArgs e)
        {
            FrmProvincias frmProvincias = new FrmProvincias();
            frmProvincias.ShowDialog();
            CargarComboProvincias();
        }
    }
}
