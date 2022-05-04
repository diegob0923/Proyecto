using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Proyecto.Modelos;
using Proyecto.BL;
using Microsoft.Reporting.WebForms;

namespace Proyecto.Formularios
{
    public partial class frmrReporteExpediente : System.Web.UI.Page
    {
        BLReportes oBLReportes = new BLReportes();
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btBuscar_Click(object sender, EventArgs e)
        {
            this.contruirReporte();
        }

        void contruirReporte()
        {

            ///indicar la ruta del reporte
            string rutaReporte = "~/Reportes/rptClienterdlc.rdlc";
            ///construir la ruta física
            string rutaServidor = Server.MapPath(rutaReporte);
            ///Validar que la ruta física exista
            if (!File.Exists(rutaServidor))
            {
                this.lblResultado.Text =
                    "El reporte seleccionado no existe";
                return;
            }
            else
            {
                rpvExpedientes.LocalReport.ReportPath = rutaServidor;
                var infoFuenteDatos = this.rpvExpedientes.LocalReport.GetDataSourceNames();
                ///limpiar los datos de la fuente de datos
                rpvExpedientes.LocalReport.DataSources.Clear();
                ///obtener los datos del reporte
                List<GenerarReporteExpediente_Result> datosReporte = oBLReportes.ReporteExpediente(Convert.ToInt32(txtCedula.Text));
                ///crear la fuente de datos
                ReportDataSource fuenteDatos = new ReportDataSource();
                fuenteDatos.Name = infoFuenteDatos[0];
                fuenteDatos.Value = datosReporte;
                // agregar la fuente de datos al reporte
                this.rpvExpedientes.LocalReport.DataSources.Add(fuenteDatos);

                /// mostrar los datos en el reporte
                this.rpvExpedientes.LocalReport.Refresh();
            }
        }
    }
}