using AvaliacaoTecnica.Interfaces;
using AvaliacaoTecnica.Models;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace AvaliacaoTecnica.Services
{
    public class PessoaService : IPessoaService
    {
        private readonly EmpresaEntities _dbContext;

        public PessoaService(EmpresaEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Pessoa> GetPessoas()
        {
            return _dbContext.Set<Pessoa>().Include(p => p.Departamento).ToList();
        }

        public Pessoa GetPessoaPorId(int id)
        {
            return _dbContext.Set<Pessoa>().Find(id);
        }

        public IEnumerable<Pessoa> GetPessoaPorDepartamentoId(int departamentoId)
        {
            return _dbContext.Set<Pessoa>().Where(p => p.DepartamentoId == departamentoId).ToList();
        }

        public IEnumerable<Pessoa> ObterPessoasComMaiorSalarioPorDepartamento()
        {
            return (from pessoa in _dbContext.Pessoa
                    where pessoa.Salario == (from p in _dbContext.Pessoa
                                             where p.DepartamentoId == pessoa.DepartamentoId
                                             select p.Salario).Max()
                    select pessoa);
        }
    }
}