using AvaliacaoTecnica.Interfaces;
using System.Web.Mvc;

namespace AvaliacaoTecnica.Controllers
{
    public class DepartamentoController : Controller
    {
        private readonly IDepartamentoService _departamentoService;
        public DepartamentoController(IDepartamentoService departamentoService)
        {
            _departamentoService = departamentoService;
        }

        public ActionResult Departamentos() 
        { 
            var departamentos = _departamentoService.GetDepartamentos();
            return View(departamentos);
        }     
    }
}