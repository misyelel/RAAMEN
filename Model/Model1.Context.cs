﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LABPSD_RAAMEN.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Database1Entities1 : DbContext
    {
        public Database1Entities1()
            : base("name=Database1Entities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<detail> details { get; set; }
        public virtual DbSet<header> headers { get; set; }
        public virtual DbSet<meat> meats { get; set; }
        public virtual DbSet<raman> ramen { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}
