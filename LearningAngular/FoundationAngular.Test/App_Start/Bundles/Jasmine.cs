using System.Web.Optimization;

// ReSharper disable once CheckNamespace
namespace FoundationAngular.Test
{
    public static class Jasmine
    {
        public static Bundle Scripts()
        {
            return new ScriptBundle("~/bundles/jasmine").Include(
                      "~/Scripts/jasmine/jasmine.js",
                      "~/Scripts/jasmine/jasmine-html.js",
                      "~/Scripts/jasmine/boot.js");
        }
    }
}


//<script type="text/javascript" src="/Scripts/jasmine/jasmine.js"></script>
//  <script type="text/javascript" src="/Scripts/jasmine/jasmine-html.js"></script>
//  <script type="text/javascript" src="/Scripts/jasmine/boot.js"></script>
