using System.Web;
using System.Web.Optimization;

namespace Sales
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                                   "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/main.js",
                      "~/Scripts/datatablemin.js",
                      "~/Scripts/datatablebootstrap.js",
                      "~/Scripts/qrcode.min.js",
                      "~/Scripts/primary.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/main.css",
                      "~/Content/datatable.css",
                      "~/Content/style.css"
                      ));
        }
    }
}
