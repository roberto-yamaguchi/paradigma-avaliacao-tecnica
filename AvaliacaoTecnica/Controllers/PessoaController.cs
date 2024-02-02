using AvaliacaoTecnica.Interfaces;
using System.Web.Mvc;

namespace AvaliacaoTecnica.Controllers
{
    public class PessoaController : Controller
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        public ActionResult Pessoas()
        {
            var pessoas = _pessoaService.GetPessoas();
            return View(pessoas);
        }

        public ActionResult GetPessoaPorId(int id) 
        {
            var pessoa = _pessoaService.GetPessoaPorId(id);

            if (pessoa == null)
            {
                return HttpNotFound();
            }

            return View(pessoa);
        }

        public ActionResult GetPessoaPorDepartamento(int departamentoId)
        {
            var pessoas = _pessoaService.GetPessoaPorDepartamentoId(departamentoId);
            return View(pessoas);
        }

        public ActionResult PessoasComMaiorSalarioPorDepartamento()
        {
            var pessoasComMaiorSalarioPorDepartamento = _pessoaService.ObterPessoasComMaiorSalarioPorDepartamento();
            return View(pessoasComMaiorSalarioPorDepartamento);
        }
    }
}