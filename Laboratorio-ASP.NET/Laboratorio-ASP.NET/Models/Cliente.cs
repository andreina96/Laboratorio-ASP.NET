//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Laboratorio_ASP.NET.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Cuenta = new HashSet<Cuenta>();
            this.Telefono = new HashSet<Telefono>();
        }
    
        [Display(Name = "C�dula:")]
        public string Cedula { get; set; }
        [Display(Name = "Nombre:")]
        public string Nombre { get; set; }
        [Display(Name = "1� Apellido:")]
        public string Apellido1 { get; set; }
        [Display(Name = "2� Apellido:")]
        public string Apellido2 { get; set; }
        [Display(Name = "Correo:")]
        public string Correo { get; set; }
        [Display(Name = "Direcci�n:")]
        public string Direccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cuenta> Cuenta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Telefono> Telefono { get; set; }
    }
}
