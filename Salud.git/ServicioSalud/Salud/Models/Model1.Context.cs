﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Salud.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SaludEntities : DbContext
    {
        public SaludEntities()
            : base("name=SaludEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<TB_Atencion> TB_Atencion { get; set; }
        public DbSet<TB_Box> TB_Box { get; set; }
        public DbSet<TB_Comuna> TB_Comuna { get; set; }
        public DbSet<TB_Condicion> TB_Condicion { get; set; }
        public DbSet<TB_DatosMedicos> TB_DatosMedicos { get; set; }
        public DbSet<TB_Diagnostico> TB_Diagnostico { get; set; }
        public DbSet<TB_Especialidad> TB_Especialidad { get; set; }
        public DbSet<TB_Fpago> TB_Fpago { get; set; }
        public DbSet<TB_Lugar> TB_Lugar { get; set; }
        public DbSet<TB_MedioLlegada> TB_MedioLlegada { get; set; }
        public DbSet<TB_Motivo> TB_Motivo { get; set; }
        public DbSet<TB_MotivoAnula> TB_MotivoAnula { get; set; }
        public DbSet<TB_Paciente> TB_Paciente { get; set; }
        public DbSet<TB_Profesional> TB_Profesional { get; set; }
        public DbSet<TB_Servicio> TB_Servicio { get; set; }
        public DbSet<TB_Signos> TB_Signos { get; set; }
        public DbSet<TB_Tipo> TB_Tipo { get; set; }
        public DbSet<TB_Usuario> TB_Usuario { get; set; }
    }
}
