//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Minomina
{
    using System;
    using System.Collections.Generic;
    
    public partial class Colaboradore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colaboradore()
        {
            this.AsigCabeceras = new HashSet<AsigCabecera>();
        }
    
        public int RECID { get; set; }
        public string Codigo_de_empleado { get; set; }
        public int RECIDPUESTO { get; set; }
        public string RolColaborador { get; set; }
        public string Estatus_Laboral { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Sexo { get; set; }
        public string Cedula_o_Pasaporte { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Cuenta_Bancaria { get; set; }
        public string Tipo_de_Cuenta { get; set; }
        public string Banco { get; set; }
        public Nullable<System.DateTime> Fecha_de_ingreso { get; set; }
        public Nullable<bool> Usuario_del_Sistema { get; set; }
        public string Pass { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AsigCabecera> AsigCabeceras { get; set; }
        public virtual Puesto Puesto { get; set; }
    }
}
