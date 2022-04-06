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
    }
}