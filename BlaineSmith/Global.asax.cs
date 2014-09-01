using System.Web.Optimization;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using BlaineSmith.App_Start;
using MongoDB.Driver;

namespace BlaineSmith
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            CreateBlogDatabase();
        }

         private static void CreateBlogDatabase()
        {
            var settings = new MongoServerSettings { Server = new MongoServerAddress("localhost", 27017) };
            var server = new MongoServer(settings);
            var database = server.GetDatabase("Blog");
            server.Disconnect();
        }

    }
}