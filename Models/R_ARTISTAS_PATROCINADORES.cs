//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RequintoBaldeonWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class R_ARTISTAS_PATROCINADORES
    {
        public decimal rap_codigo { get; set; }
        public decimal art_codigo { get; set; }
        public decimal pat_codigo { get; set; }
        public string rap_detalle { get; set; }
        public System.DateTime rap_fecha_inicio { get; set; }
        public Nullable<System.DateTime> rap_fecha_fin { get; set; }
        public Nullable<bool> rap_estado { get; set; }
        public string rap_observacion { get; set; }
    
        public virtual TARTISTAS TARTISTAS { get; set; }
        public virtual TPATROCINADORES TPATROCINADORES { get; set; }
    }
}
