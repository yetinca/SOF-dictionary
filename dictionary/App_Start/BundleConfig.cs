using System.Web;
using System.Web.Optimization;

namespace dictionary
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js",
                       "~/Scripts/DataTables/jquery.dataTables.js",
                       "~/Scripts/DataTables/dataTables.bootstrap.js",
                       "~/Scripts/bootstrap-select.js",
                       "~/Scripts/i18n/defaults-pl_PL.js",
                       "~/Scripts/bootstrap-datepicker.js",
                       "~/Scripts/locales/bootstrap-datepicker.pl.min.js"
                     ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/Site.css",
                      "~/Content/DataTables/dataTables.bootstrap.css",
                      "~/Content/bootstrap-select.css",
                      "~/Content/bootstrap-datepicker.css",
                      "~/Content/Test.css"
                      ));
        }
    }
}
