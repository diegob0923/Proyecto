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
        
        public sp_ConsultarRegistroCitas_Result ConsultarRegistroCitasId(int id)
        {
            sp_ConsultarRegistroCitas_Result registro = new sp_ConsultarRegistroCitas_Result();
            registro = modeloBD.sp_ConsultarRegistroCitas(id).FirstOrDefault();
            return registro;

        }
        public bool ModificaRegistroCitas(int idDoctor, int idCliente, string fechaCita, string horaCita, int especialidad,
        string observaciones, string estadoCita)
        {
            try
            {
                modeloBD.sp_ModificaRegistroCitas(idDoctor, idCliente, fechaCita, horaCita, especialidad, observaciones,estadoCita);
            }
              
            catch(Exception exception)
            {
                return false;
            }
            return true;
        }

        internal void ModificaRegistroCitas(int v1, int v2, int v3, string text1, string text2, string text3, string text4, string text5)
        {
            throw new NotImplementedException();
        }

        public bool EliminarRegistroCitas(int idCliente)
        {
            try
            {
                modeloBD.sp_BorrarRegistroCita(idCliente);
            }
            catch(Exception exception)
               {
                return false;
            }
            return true;
        }

    }
}