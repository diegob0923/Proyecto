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

        public List<sp_ConsultarDoctoresPorCedula_Result> RetornarDoctores(string cedula = null)
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

        public sp_ConsultarDoctoresPorCedula_Result ConsultarDoctoresCedula(int id)
        {

            sp_ConsultarDoctoresPorCedula_Result resultado = new sp_ConsultarDoctoresPorCedula_Result();
                resultado = modeloBD.sp_ConsultarDoctoresPorCedula(id).FirstOrDefault();
            return resultado;
        }

        public bool ModificaDoctores(int id_Doctor, int cedula, string genero, string fechaNacimiento, string nombre, string primerApellido, string segundoApellido, string telefonoPrincipal,
            string telefonoSecundario, string correoElectronico, int carneCodigoRespectivo, int idProvincia, int idCanton, int idDistrito, string direccion, int especialidadMedica, string horaAlmuerzo)

        {
            try
            {
                modeloBD.sp_ModificaDoctores(id_Doctor, cedula, genero, fechaNacimiento, nombre, primerApellido, segundoApellido, telefonoPrincipal,
                    telefonoSecundario, correoElectronico, carneCodigoRespectivo, idProvincia, idCanton, idDistrito,
                    direccion, especialidadMedica, horaAlmuerzo);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool EliminarDoctores(int id_Doctor)
        {
            try
            {
                modeloBD.sp_BorrarDoctores(id_Doctor);
            }
            catch(Exception exception)
            {
                return false;
            }
            return true;
        }
    }
}
