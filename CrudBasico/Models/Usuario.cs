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

    public partial class Usuario
    {
        public Usuario()
        {
            this.RegistroPrestamo = new HashSet<RegistroPrestamo>();
        }
        [Display(Name = "Matricula del usuario")]
        public string UsuMatricula { get; set; }
        [Display(Name = "Nombre del usuario")]
        public string UsuNombre { get; set; }
        [Display(Name = "Apellidos del usuario")]
        public string UsuApellidos { get; set; }
        [Display(Name = "Clave del usuario")]
        public string UsuClave { get; set; }
    
        public virtual ICollection<RegistroPrestamo> RegistroPrestamo { get; set; }
    }
}
