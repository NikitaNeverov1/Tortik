﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Torti
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TortEntities : DbContext
    {
        public TortEntities()
            : base("name=TortEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ingredienty> Ingredienty { get; set; }
        public virtual DbSet<Instruments> Instruments { get; set; }
        public virtual DbSet<Izdelie> Izdelie { get; set; }
        public virtual DbSet<Oborudovanie> Oborudovanie { get; set; }
        public virtual DbSet<Polzovatel> Polzovatel { get; set; }
        public virtual DbSet<Postavshik> Postavshik { get; set; }
        public virtual DbSet<Specific_ingredienty> Specific_ingredienty { get; set; }
        public virtual DbSet<Specific_operation> Specific_operation { get; set; }
        public virtual DbSet<Specific_PFabricat> Specific_PFabricat { get; set; }
        public virtual DbSet<Specific_tort_decoration> Specific_tort_decoration { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tort_decoration> Tort_decoration { get; set; }
        public virtual DbSet<Type_oborudovanie> Type_oborudovanie { get; set; }
        public virtual DbSet<Zakaz> Zakaz { get; set; }
    }
}
