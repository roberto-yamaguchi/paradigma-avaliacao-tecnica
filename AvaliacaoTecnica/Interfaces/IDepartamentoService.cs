using AvaliacaoTecnica.Models;
using System.Collections.Generic;

namespace AvaliacaoTecnica.Interfaces
{
    public interface IDepartamentoService
    {
        IEnumerable<Departamento> GetDepartamentos();
    }
}