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

    public partial class TUSUARIOS
    {
        [Display(Name = "Código")]
        [DisplayFormat(DataFormatString = "{0:F0}", ApplyFormatInEditMode = true)]
        public decimal usu_codigo { get; set; }
        public string usu_nombres { get; set; }
        public string usu_apellidos { get; set; }
        public string usu_cedula { get; set; }
        public string usu_clave { get; set; }
        public string usu_email { get; set; }
        public string usu_telefono { get; set; }
        public bool usu_administrador { get; set; }
        public bool usu_estado { get; set; }
        public string usu_observacion { get; set; }
    }
}