using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Clases
{
    public class Doctores
    {
        #region atributos
        public int cedula { get; set; }
        public string genero { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string nombre { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string telefonoPrincipal { get; set; }
        public string telefonoSecundario{ get; set; }
        public string correoElectronico { get; set; }
        public int id_provincia { get; set; }
        public int id_canton { get; set; }
        public int id_distrito { get; set; }
        public string direccion { get; set; }
        public int especialidad { get; set; }
        public int horaAlmuerzo { get; set; }
        #endregion atributos




        #region constructores
        public Doctores(int cedula, string genero, DateTime fecha_nacimiento, string nombre, string primerApellido,
                        string segundoApellido, string telefonoPrincipal, string telefonoSecundario, string correoElectronico, int id_provincia, 
                        int id_canton, int id_distrito, string direccion, int especialidad,int horaAlmuerzo)
        {
            this.cedula = cedula;
            this.genero = genero;
            this.fecha_nacimiento = fecha_nacimiento;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.telefonoPrincipal = telefonoPrincipal;
            this.telefonoSecundario = telefonoSecundario;
            this.correoElectronico = correoElectronico;
            this.id_provincia = id_provincia;
            this.id_canton = id_canton;
            this.id_distrito = id_distrito;
            this.direccion = direccion;
            this.especialidad = especialidad;
            this.horaAlmuerzo = horaAlmuerzo;
        }
        public Doctores()
        {
            cedula = 0;
            genero = "";
            fecha_nacimiento = DateTime.Now;
            nombre = "";
            primerApellido = "";
            segundoApellido = "";
            telefonoPrincipal = "";
            telefonoSecundario = "";
            correoElectronico = "";
            id_provincia = 0;
            id_canton = 0;
            id_distrito = 0;
            direccion = "";
            especialidad = 0;
            horaAlmuerzo = 0;
        }
        #endregion constructores



        #region funciones

        #endregion funciones





        #region metodos

        #endregion metodos
    }
}