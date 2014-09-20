using System.Web.Optimization;
// ReSharper disable once CheckNamespace


namespace FoundationAngular.Test.App_Start
{
    public static class Samples
    {
        public static Bundle Scripts()
        {
            return new ScriptBundle("~/bundles/samples").Include(
                      "~/Scripts/jasmine-samples/Player.js",
                      "~/Scripts/jasmine-samples/Song.js",
                      "~/Scripts/jasmine-samples/SpecHelper.js",
                      "~/Scripts/jasmine-samples/PlayerSpec.js");
        }
    }
}