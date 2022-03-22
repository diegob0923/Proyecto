using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto.Clases
{
    public class EnfermedadPaciente
    {

        #region atributos
        public int idCliente { get; set; }
        public int idEnfermedad { get; set; }
        

        #endregion atributos

        #region constructores
        public EnfermedadPaciente(int idCliente, int idEnfermedad)
        {
            this.idCliente = idCliente;
            this.idEnfermedad = idEnfermedad;
  
        }

        public EnfermedadPaciente()
        {
            idCliente = 0;
            idEnfermedad = 0;
        }
        # endregion constructores



        #region funciones

        # endregion funciones





        #region metodos

        # endregion metodos
    }
}