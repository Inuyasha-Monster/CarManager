using System.Web;
using System.Web.Optimization;

namespace CarManager.Web
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // user cdn 
            bundles.UseCdn = true;
            // user optimization 压缩
            BundleTable.EnableOptimizations = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            // test cdn

            bundles.Add(new ScriptBundle("~/Scripts/Jquery", "http://apps.bdimg.com/libs/jquery/2.1.4/jquery.js").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/Scripts/Jquery-Validate", "https://cdnjs.cloudflare.com/ajax/libs/jquery-validate/1.15.1/jquery.validate.min.js").Include("~/Scripts/jquery.validate.js"));
            bundles.Add(new ScriptBundle("~/Scripts/Jquery-Validate-Unobtrusive", "https://cdnjs.cloudflare.com/ajax/libs/jquery-validation-unobtrusive/3.2.6/jquery.validate.unobtrusive.min.js").Include("~/Scripts/jquery.validate.unobtrusive.js"));

        }
    }
}
