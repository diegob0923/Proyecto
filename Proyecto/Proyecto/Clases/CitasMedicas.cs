using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Clases
{
    public class CitasMedicas
    {

        #region atributos
       
        public int idDoctor { get; set; }
        public int idCliente { get; set; }
        public DateTime fechaCita { get; set; }
        public int horaCita { get; set; }
        public int especialidad { get; set; }
        public string observaciones { get; set; }
        public string estadoCita { get; set; }
        #endregion atributos

        #region constructores
        public CitasMedicas(int idDoctor, int idCliente, DateTime fechaCita, int horaCita, int especialidad, string observaciones, string estadoCita)
        {
            this.idDoctor = idDoctor;
            this.idCliente = idCliente;
            this.fechaCita = fechaCita;
            this.horaCita = horaCita;
            this.especialidad = especialidad;
            this.observaciones = observaciones;
            this.estadoCita = estadoCita;
    }

        public CitasMedicas()
        {
            this.idDoctor = 0;
            this.idCliente = 0;
            this.fechaCita = DateTime.Now;
            this.horaCita = 0;
            this.especialidad = 0;
            this.observaciones = "";
            this.estadoCita = "";
        }
        # endregion constructores



        #region funciones

        # endregion funciones





        #region metodos

        # endregion metodos
    }
}