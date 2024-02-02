using AvaliacaoTecnica.Interfaces;
using AvaliacaoTecnica.Resolver;
using AvaliacaoTecnica.Services;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace AvaliacaoTecnica
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ConfigureDependencyInjection();
        }

        private void ConfigureDependencyInjection()
        {
            var container = new UnityContainer();

            // Registro de serviços
            container.RegisterType<IDepartamentoService, DepartamentoService>();
            container.RegisterType<IPessoaService, PessoaService>();

            // Define o DependencyResolver para usar o Unity
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
