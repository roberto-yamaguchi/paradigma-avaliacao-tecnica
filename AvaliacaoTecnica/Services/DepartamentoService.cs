using AvaliacaoTecnica.Interfaces;
using AvaliacaoTecnica.Models;
using System.Collections.Generic;
using System.Linq;

namespace AvaliacaoTecnica.Services
{
    public class DepartamentoService : IDepartamentoService
    {
        private readonly EmpresaEntities _dbContext;

        public DepartamentoService(EmpresaEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Departamento> GetDepartamentos()
        {
            return _dbContext.Set<Departamento>().ToList();
        }
    }
}