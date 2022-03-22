using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Clases
{
    public class EspecialidadesMedicas
    {
        #region atributos
        public string nombre { get; set; }
        public string descripcion { get; set; }

        #endregion atributos

        #region constructores
        public EspecialidadesMedicas(string nombre, string descripcion)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
        }

        public EspecialidadesMedicas()
        {
            this.nombre = "";
            this.descripcion = "";
        }
        # endregion constructores



        #region funciones

        # endregion funciones





        #region metodos

        # endregion metodos
    }
}