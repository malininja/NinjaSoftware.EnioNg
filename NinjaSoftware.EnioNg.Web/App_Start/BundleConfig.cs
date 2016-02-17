using System.Web;
using System.Web.Optimization;

namespace NinjaSoftware.EnioNg.Web
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.1.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/custom-script-setup").Include(
                "~/Scripts/jqGrid/i18n/grid.locale-hr.js",
                "~/Scripts/jqGrid/jquery.jqGrid.js",
                "~/Scripts/NinjaSoftwareLib.js",
                "~/Scripts/enioNg.textResources.js",
                "~/Scripts/Home/Api.js",
                "~/Scripts/angular.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/Site.css",
                "~/Content/jqGrid/ui.jqgrid.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
            "~/Content/themes/base/jquery-ui.css"));
        }

        //    bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
        //                "~/Content/themes/base/jquery.ui.core.css",
        //                "~/Content/themes/base/jquery.ui.resizable.css",
        //                "~/Content/themes/base/jquery.ui.selectable.css",
        //                "~/Content/themes/base/jquery.ui.accordion.css",
        //                "~/Content/themes/base/jquery.ui.autocomplete.css",
        //                "~/Content/themes/base/jquery.ui.button.css",
        //                "~/Content/themes/base/jquery.ui.dialog.css",
        //                "~/Content/themes/base/jquery.ui.slider.css",
        //                "~/Content/themes/base/jquery.ui.tabs.css",
        //                "~/Content/themes/base/jquery.ui.datepicker.css",
        //                "~/Content/themes/base/jquery.ui.progressbar.css",
        //                "~/Content/themes/base/jquery.ui.theme.css"));
        //}
    }
}