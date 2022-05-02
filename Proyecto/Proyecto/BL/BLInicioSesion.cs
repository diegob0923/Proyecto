using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto.Modelos;
namespace Proyecto.BL
{
    public class BLInicioSesion
    {
        CentroMedicoEntities modeloBD = new CentroMedicoEntities();
        public string tipo { get; set; }
        public string nombre { get; set;}
        public bool Autenticacion(string usuario, string contrasena)
        {

            sp_RetornaUsuarioValido_Result respuesta = modeloBD.sp_RetornaUsuarioValido(usuario, contrasena).FirstOrDefault();

            if (respuesta == null)
            {
                return false;
            }
            else
            {
                tipo = respuesta.Tipo_Usuario;
                nombre = respuesta.Nombre_Completo;
                return true;
            }
        }
    }
}