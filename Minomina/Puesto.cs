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
    
    public partial class Puesto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Puesto()
        {
            this.Colaboradores = new HashSet<Colaboradore>();
        }
    
        public int RECID { get; set; }
        public string ID_Puesto { get; set; }
        public string Puesto1 { get; set; }
        public double Salario { get; set; }
        public string Frecuencia_del_salario { get; set; }
        public Nullable<double> Pago_por_horas { get; set; }
        public Nullable<int> Cantidad_Disponible { get; set; }
        public string Deberes { get; set; }
        public Nullable<int> RECIDDEPAR { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Colaboradore> Colaboradores { get; set; }
        public virtual Departamento Departamento { get; set; }
    }
}
