//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Pessoa
    {
        public int Id { get; set; }
        public int DepartamentoId { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
    
        public virtual Departamento Departamento { get; set; }
    }
}
