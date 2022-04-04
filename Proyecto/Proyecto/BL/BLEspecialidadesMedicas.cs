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
            int registrosAfectados = 0;

            registrosAfectados = modeloBD.sp_InsertarEspecialidadMedica(nombre, descripcion);

            if (registrosAfectados > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}