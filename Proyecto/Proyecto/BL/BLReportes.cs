using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Modelos;
namespace Proyecto.BL
{
    public class BLReportes
    {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();


        public List<GenerarReporteExpediente_Result> ReporteExpediente(int cedula)
        {
            List<GenerarReporteExpediente_Result> datosReporte = modeloBD.GenerarReporteExpediente(cedula).ToList();
            return datosReporte;
        }
    }
}