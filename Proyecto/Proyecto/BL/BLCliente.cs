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

            try { 
                modeloBD.sp_InsertarCliente(cedula, genero,fechaNacimiento,nombre,primerApellido,segundoApellido, telefono1,
                                                            telefono2, correo, idProvincia, idCanton, idDistrito, direccion);
            }
            catch (Exception excepcion)
            {
                return false;
            }
                return true;
            
        }

        public List<sp_ConsultarClientePorCedula_Result> RetornarClientes(string cedula=null)
        { 
            List<sp_ConsultarClientePorCedula_Result> resultado = new List<sp_ConsultarClientePorCedula_Result>();

            if (cedula.Equals(""))
            {
                resultado = modeloBD.sp_ConsultarClientePorCedula(null).ToList();//traer todos los registros
            }
            else
            {
                resultado = modeloBD.sp_ConsultarClientePorCedula(Convert.ToInt32(cedula)).ToList();
            }
            
               


            return resultado;
        }

    }
}