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
    
    public partial class AsigNovedadDetalle
    {
        public int RECID { get; set; }
        public Nullable<int> RECIDHEADER { get; set; }
        public string IDAsignacion { get; set; }
        public Nullable<int> RECIDNOVEDAD { get; set; }
        public string DescNovedad { get; set; }
        public Nullable<double> Monto { get; set; }
        public Nullable<System.DateTime> FechaDesde { get; set; }
        public Nullable<System.DateTime> FechaHasta { get; set; }
        public string TipoNovedad { get; set; }
    
        public virtual AsigCabecera AsigCabecera { get; set; }
        public virtual Novedade Novedade { get; set; }
    }
}