﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AvaliacaoTecnica.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EmpresaEntities : DbContext
    {
        public EmpresaEntities()
            : base("name=EmpresaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Pessoa> Pessoa { get; set; }
        public virtual DbSet<V_MAIOR_SALARIO_POR_DEPARTAMENTO> V_MAIOR_SALARIO_POR_DEPARTAMENTO { get; set; }
    }
}
