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

        public sp_ConsultarClienteId_Result RetornarClienteId(int id)
        {
            sp_ConsultarClienteId_Result resultado = new sp_ConsultarClienteId_Result();

            resultado = modeloBD.sp_ConsultarClienteId(id).FirstOrDefault();

           return resultado;
        }


        public bool ModificarClientes(int idCliente, int cedula, string genero, string fechaNacimiento, string nombre, string primerApellido, string segundoApellido,
                                      string telefono1, string telefono2, string correo, int idProvincia, int idCanton, int idDistrito, string direccion)
        {
            try
            {
                modeloBD.sp_ModificarCliente(idCliente, cedula, genero, fechaNacimiento, nombre, primerApellido, segundoApellido,telefono1, telefono2, correo, idProvincia, idCanton, idDistrito, direccion);
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }

        public bool EliminarCliente(int idCliente)
        {
            try
            {
                modeloBD.sp_BorrarCliente(idCliente);
            }
            catch (Exception excepcion)
            {
                return false;
            }
            return true;
        }
    }
}