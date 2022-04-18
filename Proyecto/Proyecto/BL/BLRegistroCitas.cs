using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Modelos;

namespace Proyecto.BL
{
    public class BLRegistroCitas
     {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();

        public bool InsertarRegistroCitas(int idDoctor, int idCliente, string fechaCita,string horaCita,int especialidad, 
            string observaciones, string estadoCita )
        {

            try
            {

                modeloBD.sp_InsertarRegistroCitas(idDoctor,idCliente,fechaCita,horaCita,especialidad,
            observaciones, estadoCita);
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }

        public List<sp_ConsultarRegistroCitas_Result> RetornaCitaCliente (string idCliente= null) {
            List<sp_ConsultarRegistroCitas_Result> registroCitas = new List<sp_ConsultarRegistroCitas_Result>();
            registroCitas = modeloBD.sp_ConsultarRegistroCitas(Convert.ToInt32(idCliente)).ToList();

            return registroCitas;

                }
        
            

    }
}