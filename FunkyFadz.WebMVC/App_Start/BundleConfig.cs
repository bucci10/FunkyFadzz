using System.Web;
using System.Web.Optimization;

namespace FunkyFadz.WebMVC
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/fliplightbox.min.js",
                "~/Scripts/functions.js",
                "~/Scripts/jquery-1.10.2.intellisense.js",
                "~/Scripts/jquery-1.10.2.js",
                "~/Scripts/jquery-1.10.2.min.js",
                "~/Scripts/jquery-2.1.1.min.js",
                "~/Scripts/bxslider.min.js",
                "~/Scripts/jquery.easing.1.3.js",
                "~/Scripts/jquery.isotope.min.js",
                "~/Scripts/jquery.validate-vsdoc.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.validate.min.js",
                "~/Scripts/jquery.validate.unobtrusive.js",
                "~/Scripts/jquery.validate.unobtrusive.min.js",
                "~/Scripts/modernizr-2.6.2.js",
                "~/Scripts/respond.min.js",
                "~/Scripts/wow.min.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/animate.css",
                "~/Content/bootstrap-theme.css",
                "~/Content/demo.css",
                "~/Content/fontawesome.css",
                "~/Content/isotope.css",
                "~/Content/jquery.bxslider.css",
                "~/Content/normalize.css",
                "~/Content/overwrite.css",
                "~/Content/set1.css",
                "~/Content/set2.css",
                "~/Content/style.css",
                "~/Content/site.css"));
        }
    }
}
