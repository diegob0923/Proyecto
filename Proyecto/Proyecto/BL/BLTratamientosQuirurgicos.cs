using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Modelos;

namespace Proyecto.BL
{
    public class BLTratamientosQuirurgicos
    {

        CentroMedicoEntities modeloBD = new CentroMedicoEntities();

        public bool InsertarTratamientosQuirurgicos(string nombre, string descripcion)
        {

            try
            {
                modeloBD.sp_InsertarTratamientoQuirurgico(nombre, descripcion);
            }
            catch (Exception exception)
            {
                return false;
            }

            return true;

        }

        public List<sp_ConsultarTratamientosQuirurgicos_Result> ConsultarTratamientosQuirurgicos(string nombre = null, string descripcion = null)
        {
            List<sp_ConsultarTratamientosQuirurgicos_Result> registros = new List<sp_ConsultarTratamientosQuirurgicos_Result>();

            registros = modeloBD.sp_ConsultarTratamientosQuirurgicos(nombre, descripcion).ToList();

            return registros;

        }

        public sp_ConsultarTratamientosQuirurgicosID_Result ConsultarTratamientosQuirurgicosID(int id)
        {
            sp_ConsultarTratamientosQuirurgicosID_Result registros = new sp_ConsultarTratamientosQuirurgicosID_Result();

            registros = modeloBD.sp_ConsultarTratamientosQuirurgicosID(id).FirstOrDefault();

            return registros;

        }

        public bool ModificarTratamientoQuirurgico(int idTratamiento, string nombre, string desccripcion)
        {
            try
            {
                modeloBD.sp_ModificarTratamientoQuirurgico(idTratamiento, nombre, desccripcion);
            
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }


        public bool EliminarTratamientoQuirurgico(int idTratamiento)
        {
            try
            {
                modeloBD.sp_BorrarTratamientosQuirurgicos(idTratamiento);
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }
    }
}