using Microsoft.Reporting.WinForms;
using SanJustino.Data;
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
    public partial class DeporteViewForm : Form
    {
        ReportViewer reporte = new ReportViewer();
        ClubSanJustinoContext context = new ClubSanJustinoContext();
        public DeporteViewForm()
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

        private void DeporteViewForm_Load(object sender, EventArgs e)
        {
            reporte.LocalReport.ReportEmbeddedResource = "SanJustino.Reportes.DeportesReport.rdlc";

            var deporte = context.Deportes.ToList();

            reporte.LocalReport.DataSources.Add(new ReportDataSource("DSDeportes", deporte));

            reporte.RefreshReport();
        }
    }
}
