using System.Web;
using System.Web.Optimization;

namespace SimpleBlog
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //admin stryle bundle
            bundles.Add(new StyleBundle("~/admin/styles")
                .Include("~/content/styles/bootstrap.css")
                .Include("~/content/styles/admin.css"));


            //front end bundle
            bundles.Add(new StyleBundle("~/styles")
               .Include("~/content/styles/bootstrap.css")
               .Include("~/content/styles/site.css"));

            bundles.Add(new ScriptBundle("~/admin/scripts")
                .Include("~/scrips/jquery-3.1.1.js")
                .Include("~/scripts/jquery.validate.js")
                .Include("~/scripts/jquery.validate.unobtrusive.js")
                .Include("~/scripts/bootstrap.js"));

            bundles.Add(new ScriptBundle("~/scripts")
               .Include("~/scrips/jquery-3.1.1.js")
               .Include("~/scripts/jquery.validate.js")
               .Include("~/scripts/jquery.validate.unobtrusive.js")
               .Include("~/scripts/bootstrap.js"));




            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
            //   "~/Scripts/jquery-{version}.js"));

            // bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
            //           "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
            //          "~/Scripts/modernizr-*"));

            //bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
            //        "~/Scripts/bootstrap.js",
            //      "~/Scripts/respond.js"));

            //bundles.Add(new StyleBundle("~/Content/css").Include(
            //        "~/Content/bootstrap.css",
            //      "~/Content/site.css"));
        }
    }
}
