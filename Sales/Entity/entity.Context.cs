﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SalesEntities : DbContext
    {
        public SalesEntities()
            : base("name=SalesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Areas> Areas { get; set; }
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<CustomerBridgeGrade> CustomerBridgeGrade { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<CusWork> CusWork { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<ManEmp> ManEmp { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Scheduale> Scheduale { get; set; }
        public virtual DbSet<Specials> Specials { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Types> Types { get; set; }
    }
}
