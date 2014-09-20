using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using FoundationAngular.Test.App_Start;

namespace FoundationAngular.Test
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery/jquery-{version}.js"));
            bundles.Add(new StyleBundle("~/Content/jasmine").Include("~/Content/jasmine/jasmine.css"));


            bundles.Add(new ScriptBundle("~/bundles/angular").Include("~/Scripts/angular/angular.js"));
            bundles.Add(new ScriptBundle("~/bundles/app").Include("~/Scripts/app/controllers.js", 
                                                                  "~/Scripts/app/classes.js", 
                                                                  "~/Scripts/app/helpers.js",
                                                                  "~/Scripts/phonecatTests/phoneListControllerSpec.js"));


            bundles.Add(Jasmine.Scripts());
            bundles.Add(Samples.Scripts());
        }
    }
}



  //<script type="text/javascript" src="/Scripts/jasmine/jasmine.js"></script>
  //  <script type="text/javascript" src="/Scripts/jasmine/jasmine-html.js"></script>
  //  <script type="text/javascript" src="/Scripts/jasmine/boot.js"></script>

  //  <!-- include source files here... -->
  //  <script type="text/javascript" src="/Scripts/jasmine-samples/Player.js"></script>
  //  <script type="text/javascript" src="/Scripts/jasmine-samples/Song.js"></script>
  //  <script type="text/javascript" src="../../../FoundationAngular/Scripts/app/controllers.js"></script>

  //  <!-- include spec files here... -->
  //  <script type="text/javascript" src="/Scripts/jasmine-samples/SpecHelper.js"></script>
  //  <script type="text/javascript" src="/Scripts/jasmine-samples/PlayerSpec.js"></script>
  //  <script type="text/javascript" src="/Scripts/phonecatTests/phoneListControllerSpec.js"></script>