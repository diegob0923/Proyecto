using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Clases
{
    public class TratamientosPaciente
    {
        #region atributos
        public int idCliente { get; set; }
        public int idTratamiento { get; set; }


        #endregion atributos

        #region constructores
        public TratamientosPaciente(int idCliente, int idTratamiento)
        {
            this.idCliente = idCliente;
            this.idTratamiento = idTratamiento;

        }

        public TratamientosPaciente()
        {
            idCliente = 0;
            idTratamiento = 0;
        }
        # endregion constructores



        #region funciones

        # endregion funciones





        #region metodos

        # endregion metodos
    }
}