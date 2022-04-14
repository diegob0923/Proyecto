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

        public List<sp_ConsultarDoctoresPorCedula_Result> RetornarClientes(string cedula = null)
        {
            List<sp_ConsultarDoctoresPorCedula_Result> resultado = new List<sp_ConsultarDoctoresPorCedula_Result>();

            if (cedula.Equals(""))
            {
                resultado = modeloBD.sp_ConsultarDoctoresPorCedula(null).ToList();//traer todos los registros
            }
            else
            {
                resultado = modeloBD.sp_ConsultarDoctoresPorCedula(Convert.ToInt32(cedula)).ToList();
            }




            return resultado;
        }
    }
}
