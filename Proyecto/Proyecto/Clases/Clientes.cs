using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Clases
{
    public class Clientes
    {
        public int idCliente { get; set; }
        public int cedula { get; set; }
        public string genero { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string telefono1 { get; set; }
        public string telefono2 { get; set; }
        public string correo { get; set; }
        public int id_provincia { get; set; }
        public int id_canton { get; set; }
        public int id_distrito { get; set; }
        public string direccion { get; set; }


    } 
}