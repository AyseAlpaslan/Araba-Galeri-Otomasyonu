﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ARBotomasyonu
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ARBEntities1 : DbContext
    {
        public ARBEntities1()
            : base("name=ARBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Araclar> Araclars { get; set; }
        public virtual DbSet<Kayit> Kayits { get; set; }
        public virtual DbSet<Musteriler> Musterilers { get; set; }
        public virtual DbSet<Subeler> Subelers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
