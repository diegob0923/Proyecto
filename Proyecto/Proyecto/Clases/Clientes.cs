using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Clases
{
    public class Clientes
    {
        #region atributos
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
        #endregion atributos




        #region constructores
        public Clientes(int cedula, string genero, DateTime fecha_nacimiento, string nombre, string primerApellido,
                        string segundoApellido, string telefono1, string telefono2, string correo, int id_provincia, int id_canton,
                        int id_distrito, string direccion)
        {
            this.cedula = cedula;
            this.genero = genero;
            this.fecha_nacimiento = fecha_nacimiento;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.correo = correo;
            this.id_provincia = id_provincia;
            this.id_canton = id_canton;
            this.id_distrito = id_distrito;
            this.direccion = direccion;
        }
        public Clientes()
        {
            cedula = 0;
            genero = "";
            fecha_nacimiento = DateTime.Now;
            nombre = "";
            primerApellido = "";
            segundoApellido = "";
            telefono1 = "";
            telefono2 = "";
            correo = "";
            id_provincia = 0;
            id_canton = 0;
            id_distrito = 0;
            direccion = "";
        }
        #endregion constructores



        #region funciones

        #endregion funciones





        #region metodos

        #endregion metodos
    }
}