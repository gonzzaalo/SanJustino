using SanJustino.Forms;
using SanJustino.Forms.Deportes;
using SanJustino.ViewForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanJustino
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

        }

        private void btnDeportista_Click(object sender, EventArgs e)
        {
            FrmDeportistas frmDeportistas = new FrmDeportistas();
            frmDeportistas.ShowDialog();
        }

        private void btnDeportes_Click(object sender, EventArgs e)
        {
            FrmDeportes frmDeportes = new FrmDeportes();
            frmDeportes.ShowDialog();
        }

        private void listadoDeDeportistasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeportistasViewForm deportistasViewForm = new DeportistasViewForm();
            deportistasViewForm.ShowDialog();
        }

        private void listaDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfesoresViewForm profesoresViewForm = new ProfesoresViewForm();
            profesoresViewForm.ShowDialog();
        }

        private void listadoDeDeportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeporteViewForm deporteViewForm = new DeporteViewForm();
            deporteViewForm.ShowDialog();
        }

        private void listadoDeProvinciasYSusLocadidaesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalidadesViewForm localidadesViewForm = new LocalidadesViewForm();
            localidadesViewForm.ShowDialog();
        }
    }
}
