using System.Web;
using System.Web.Optimization;

namespace AssetManagementAPII
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/fontawesome.min.css",
                      "~/Content/fontawesome.css"
                      ));

            bundles.Add(new StyleBundle("~/LoginContent/css").Include(
                      "~/Content/adminlte.min.css"));

            bundles.Add(new StyleBundle("~/standard/css").Include(
                      "~/Content/all.min.css",
                      "~/Content/adminlte.min.css",
                      "~/Content/fontawesome.min.css",
                      "~/Content/fontawesome.css",
                      "~/Content/select2.css",
                      "~/Content/style.css"));

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-3.4.1.min.js",
                      "~/Scripts/jquery-ui.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"
                      ));


            bundles.Add(new ScriptBundle("~/Scripts/datatables").Include(
                        "~/Scripts/jquery.dataTables.js",
                        "~/Scripts/dataTables.bootstrap4.js",
                        "~/Scripts/jquery.dataTables.min.js"));

            bundles.Add(new ScriptBundle("~/standard/js").Include(
                      "~/Scripts/Chart.min.js",
                      "~/Scripts/utility.js",
                      "~/Scripts/config.js",
                      "~/Scripts/common.js",
                      "~/Scripts/main.js",
                      "~/Scripts/select2.min.js",
                      "~/Scripts/jstree.js"
                      ));

            bundles.Add(new ScriptBundle("~/standard/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.min.js"));
        }
    }
}
