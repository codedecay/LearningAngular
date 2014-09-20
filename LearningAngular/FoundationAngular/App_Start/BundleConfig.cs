using System.Web.Optimization;

namespace FoundationAngular
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/angular").Include("~/Content/animations.css", "~/Content/app.css"));

            bundles.Add(new ScriptBundle("~/bundles/angular").Include("~/Scripts/angular/angular.js"));

            bundles.Add(Foundation.Scripts());

        }
    }
}
