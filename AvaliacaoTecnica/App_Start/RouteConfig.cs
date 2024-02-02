using System.Web.Mvc;
using System.Web.Routing;

namespace AvaliacaoTecnica
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Departamento", action = "Departamentos", id = UrlParameter.Optional }
            );            
        }
    }
}
