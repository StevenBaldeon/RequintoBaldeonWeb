﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbModels : DbContext
    {
        public DbModels()
            : base("name=DbModels")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<R_ARTISTAS_PATROCINADORES> R_ARTISTAS_PATROCINADORES { get; set; }
        public virtual DbSet<R_EVENTOS_ARTISTAS> R_EVENTOS_ARTISTAS { get; set; }
        public virtual DbSet<TARTISTAS> TARTISTAS { get; set; }
        public virtual DbSet<TEVENTOS> TEVENTOS { get; set; }
        public virtual DbSet<TFORMATOS> TFORMATOS { get; set; }
        public virtual DbSet<TPATROCINADORES> TPATROCINADORES { get; set; }
        public virtual DbSet<TUSUARIOS> TUSUARIOS { get; set; }
    }
}
