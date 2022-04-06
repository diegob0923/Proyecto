using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Modelos;

namespace Proyecto.BL
{
    public class BlDoctores
    {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();

        public bool InsertarDoctores(int cedula, string genero, string fechaNacimiento, string nombre, string primerApellido, string segundoApellido, string telefonoPrincipal,
            string telefonoSecundario, string correoElectronico, int carneCodigoRespectivo, int idProvincia, int idCanton, int idDistrito, string direccion, int especialidadMedica, string horaAlmuerzo)

        {
            try
            {
                modeloBD.sp_InsertarDoctores(cedula, genero, fechaNacimiento, nombre, primerApellido, segundoApellido, telefonoPrincipal,
                     telefonoSecundario, correoElectronico, carneCodigoRespectivo, idProvincia, idCanton, idDistrito, direccion,
                     especialidadMedica,horaAlmuerzo);

            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;

        }

        internal void InsertarDoctores(int v1, string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8, short v2, short v3, short v4, string text9, int v5, string text10)
        {
            throw new NotImplementedException();
        }
    }
}
