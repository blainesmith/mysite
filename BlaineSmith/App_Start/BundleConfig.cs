using System.Web.Optimization;

namespace BlaineSmith
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                "~/Scripts/JQuery/jquery-{version}.js",
                 "~/Scripts/Bootstrap/bootstrap.js",
                "~/Scripts/JQuery/jquery.easing.min.js",
                "~/Scripts/JQuery/jquery.easypiechart.js",               
                "~/Scripts/Angular/angular.js",
                "~/Scripts/Angular/angular-route.js",
                "~/Scripts/angular-ui/ui-bootstrap.js",
                "~/Scripts/angular-ui/ui-bootstrap-tpls.js"
                ));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/animate.css",
                "~/Content/font-awesome.css",
                "~/Content/main.css"
                )); //Application Specific Styles

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/site/Startup").IncludeDirectory("~/Scripts/Startup", "*.js", true));
            bundles.Add(new ScriptBundle("~/site/Template").IncludeDirectory("~/Scripts/Template", "*.js", true));
            bundles.Add(new ScriptBundle("~/site/Controllers").IncludeDirectory("~/Scripts/Site/Controllers", "*.js", true));
            bundles.Add(new ScriptBundle("~/site/Dialogs").IncludeDirectory("~/Scripts/Site/Dialogs", "*.js", true));
            bundles.Add(new ScriptBundle("~/site/Directives").IncludeDirectory("~/Scripts/Site/Directives", "*.js", true));
            //bundles.Add(new ScriptBundle("~/site/Filters").IncludeDirectory("~/Scripts/Site/Filters", "*.js", true));
            bundles.Add(new ScriptBundle("~/site/Services").IncludeDirectory("~/Scripts/Site/Services", "*.js", true));
        }
    }
}