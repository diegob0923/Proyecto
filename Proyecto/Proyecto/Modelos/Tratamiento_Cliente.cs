//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tratamiento_Cliente
    {
        public int id_cliente { get; set; }
        public int id_tratamiento { get; set; }
        public int id_tratamiento_cliente { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        public virtual Tratamiento_Quirurgico Tratamiento_Quirurgico { get; set; }
    }
}
