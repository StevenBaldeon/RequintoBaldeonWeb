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
    using System.ComponentModel.DataAnnotations;

    public partial class TEVENTOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TEVENTOS()
        {
            this.R_EVENTOS_ARTISTAS = new HashSet<R_EVENTOS_ARTISTAS>();
        }
        [Display(Name = "Código")]
        [DisplayFormat(DataFormatString = "{0:F0}", ApplyFormatInEditMode = true)]
        public decimal eve_codigo { get; set; }
        [Display(Name = "Nombre")]
        public string eve_nombre { get; set; }
        [Display(Name = "Descripción")]
        public string eve_descripcion { get; set; }
        [Display(Name = "Fecha")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public System.DateTime eve_fecha { get; set; }

        [Display(Name = "Hora")]
        [DataType(DataType.Time)]
        public System.TimeSpan eve_hora { get; set; }
        [Display(Name = "Ubicación")]
        public string eve_ubicacion { get; set; }
        [Display(Name = "Precio")]
        public Nullable<decimal> eve_precio_entrada { get; set; }
        [Display(Name = "Imágen")]
        public string eve_imagen { get; set; }
        [Display(Name = "Estado")]
        public Nullable<bool> eve_estado { get; set; }
        [Display(Name = "Observación")]
        public string eve_observacion { get; set; }
        [Display(Name = "Dirección")]
        public string eve_direccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<R_EVENTOS_ARTISTAS> R_EVENTOS_ARTISTAS { get; set; }
    }
}
