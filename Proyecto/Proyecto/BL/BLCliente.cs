using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Modelos;
namespace Proyecto.BL
{
    public class BLCliente
    {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();

        public bool InsertarClientes(int cedula, string genero, string fechaNacimiento, string nombre, string primerApellido, string segundoApellido,
                                      string telefono1,string telefono2, string correo, int idProvincia, int idCanton, int idDistrito, string direccion)
        {
            int registrosAfectados = 0;

            registrosAfectados = modeloBD.sp_InsertarCliente(cedula, genero,fechaNacimiento,nombre,primerApellido,segundoApellido, telefono1, 
                                                             telefono2, correo, idProvincia, idCanton, idDistrito, direccion);

            if (registrosAfectados>0)
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