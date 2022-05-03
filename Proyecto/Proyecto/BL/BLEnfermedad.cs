using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Modelos;

namespace Proyecto.BL
{
    public class BLEnfermedad
    {

        CentroMedicoEntities modeloBD = new CentroMedicoEntities();

        public bool InsertarEnfermedad(string nombre, string descripcion)
        {

            try
            {
                modeloBD.sp_InsertarEnfermedad(nombre, descripcion);
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;

        }


        public List<sp_ConsultarEnfermedades_Result> ConsultarEnfermedad(string nombre = null, string descripcion = null)
        {
            List<sp_ConsultarEnfermedades_Result> registros = new List<sp_ConsultarEnfermedades_Result>();

            registros = modeloBD.sp_ConsultarEnfermedades(nombre,descripcion).ToList();

            return registros;

        }

        public sp_ConsultarEnfermedadesID_Result ConsultarEnfermedadID(int id)
        {
            sp_ConsultarEnfermedadesID_Result registros = new sp_ConsultarEnfermedadesID_Result();

            registros = modeloBD.sp_ConsultarEnfermedadesID(id).FirstOrDefault();

            return registros;

        }

        public bool ModificarEnfermedad(int idEnfermedad, string nombre, string desccripcion)
        {
            try
            {
                modeloBD.sp_ModificarEnfermedad(idEnfermedad, nombre, desccripcion);
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }

        public bool EliminarEnfermedad(int idEnfermedad)
        {
            try
            {
                modeloBD.sp_BorrarEnfermedades(idEnfermedad);
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }
    }
}