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

    public partial class Hardware
    {
        public Hardware()
        {
            this.RegistroPrestamo = new HashSet<RegistroPrestamo>();
        }

        [Display(Name="#")]
        public int HardId { get; set; }
        [Display(Name="Nombre del hardware")]
        public string HardNombre { get; set; }
        [Display(Name="Stock de disponibilidad")]
        public int HardStock { get; set; }
    
        public virtual ICollection<RegistroPrestamo> RegistroPrestamo { get; set; }
    }
}
