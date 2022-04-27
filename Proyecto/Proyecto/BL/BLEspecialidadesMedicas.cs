using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Modelos;
namespace Proyecto.BL
{
    public class BLEspecialidadesMedicas
    {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();

        public bool insertarEspecialidadMedica(string nombre, string descripcion)
        {
            try
            {
                modeloBD.sp_InsertarEspecialidadMedica(nombre, descripcion);
            }
            catch (Exception exception)
            {
                return false;
            }
            
            return true;
            
        }

        public List<sp_ConsultarEspecialidadPorNombre_Result> ConsultarEspecialidadMedica(string nombre = null)
        {
            List<sp_ConsultarEspecialidadPorNombre_Result> registros = new List<sp_ConsultarEspecialidadPorNombre_Result>();

            registros = modeloBD.sp_ConsultarEspecialidadPorNombre(nombre).ToList();

            return registros;

        }

        public sp_ConsultarEspecialidadId_Result ConsultarEspecialidadMedicaId(int id)
        {
            sp_ConsultarEspecialidadId_Result registros = new sp_ConsultarEspecialidadId_Result();

            registros = modeloBD.sp_ConsultarEspecialidadId(id).FirstOrDefault();

            return registros;

        }

        public bool ModificarEspecialidadMedica(int idEspecialidad, string nombre, string desccripcion)
        {
            try
            {
                modeloBD.sp_ModificarEspecialidadMedica(idEspecialidad, nombre, desccripcion);
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }

        public bool EliminarEspecialidadMedica(int idEspecialidad)
        {
            try
            {
                modeloBD.sp_BorrarEspecialidadMedica(idEspecialidad);
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }

    }
}