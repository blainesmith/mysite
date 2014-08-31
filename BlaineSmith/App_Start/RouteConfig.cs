using System.Web.Mvc;
using System.Web.Routing;

namespace BlaineSmith.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Index",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Shared", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}