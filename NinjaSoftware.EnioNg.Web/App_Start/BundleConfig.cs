using System.Web;
using System.Web.Optimization;

namespace NinjaSoftware.EnioNg.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui.js",
                        "~/Scripts/jquery.datepicker.hr.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/custom-script-setup").Include(
                "~/Scripts/jqGrid/i18n/grid.locale-hr.js",
                "~/Scripts/jqGrid/jquery.jqGrid.js",
                "~/Scripts/NinjaSoftwareLib.js",
                "~/Scripts/enioNg.textResources.js",
                "~/Scripts/Home/Api.js",
                "~/Scripts/angular.js"));

            bundles.Add(new ScriptBundle("~/bundles/angular-app").Include(
                "~/Scripts/Home/EnioApp.js",
                "~/Scripts/Home/ArtiklController.js",
                "~/Scripts/Home/PdvController.js",
                "~/Scripts/Home/PartnerController.js",
                "~/Scripts/Home/TarifaController.js",
                "~/Scripts/Home/ConfigController.js",
                "~/Scripts/Home/RacunController.js"
                ));

            bundles.Add(new ScriptBundle("~/bundles/globalize").Include(
                "~/Scripts/globalize.js",
                "~/Scripts/globalize.culture.hr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
