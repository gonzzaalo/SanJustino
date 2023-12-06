using Microsoft.Reporting.WinForms;
using SanJustino.Data;
using SanJustino.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanJustino.ViewForms
{
    public partial class LocalidadesViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        ClubSanJustinoContext context = new ClubSanJustinoContext();

        public LocalidadesViewForm()
        {
            InitializeComponent();
            //Para que el reporte ocupe todo el formulario
            reporte.Dock = DockStyle.Fill;

            //Establece la vista de impresion
            reporte.SetDisplayMode(DisplayMode.PrintLayout);

            //Establece el zoom al 100%
            reporte.ZoomMode = ZoomMode.Percent;
            reporte.ZoomPercent = 100;

            Controls.Add(reporte);
        }

        private void LocalidadesViewForm_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "SanJustino.Reportes.LocalidadesReport.rdlc";

            var localidades = from localidad in context.Localidades
                              join provincia in context.Provincias
                              on localidad.ProvinciaId equals provincia.Id
                              orderby localidad.ProvinciaId
                              select new
                              {
                                  Id = localidad.Id,
                                  Nombre = localidad.Nombre,
                                  CodigoPostal= localidad.CodigoPostal,
                                  ProvinciaId = localidad.ProvinciaId,
                                  Provincia = provincia.Nombre

                              };

            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSLocalidades", localidades));

            reporte.RefreshReport();
        }
    }
}
