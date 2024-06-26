//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CrudBasico.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class RegistroPrestamo
    {
        [Display(Name = "Num. del registro")]
        public int RegId { get; set; }
        [Display(Name = "Fecha de registro")]
        [DisplayFormat(ApplyFormatInEditMode=true, DataFormatString ="0:DD/MM/YYYY")]
        [DataType(DataType.DateTime)]
        public System.DateTime RegFecha { get; set; }
        [Display(Name = "Matricula registrada")]
        public string RegMatricula { get; set; }
        [Display(Name = "Hardware registrado")]
        public int RegIdHardware { get; set; }
    
        public virtual Hardware Hardware { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
