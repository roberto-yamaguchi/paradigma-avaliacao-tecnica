using AvaliacaoTecnica.Models;
using System.Collections.Generic;

namespace AvaliacaoTecnica.Interfaces
{
    public interface IPessoaService
    {
        IEnumerable<Pessoa> GetPessoas();
        Pessoa GetPessoaPorId(int id);
        IEnumerable<Pessoa> GetPessoaPorDepartamentoId(int departamentoId);
        IEnumerable<Pessoa> ObterPessoasComMaiorSalarioPorDepartamento();
    }
}
