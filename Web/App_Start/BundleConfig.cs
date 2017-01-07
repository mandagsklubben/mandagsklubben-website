using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Mandagsklubben.Web
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            var lessBundle = new Bundle("~/Styles").IncludeDirectory("~/Content", "*.less");
            lessBundle.Transforms.Add(new LessTransform());
            lessBundle.Transforms.Add(new CssMinify());
            bundles.Add(lessBundle);

            bundles.Add(new ScriptBundle("~/JavaScripts").Include(
                        "~/Scripts/moment.min.js",
                        "~/Scripts/knockout-2.3.0.js",
                         "~/Scripts/jquery-2.0.3.min.js"));

            BundleTable.EnableOptimizations = true;
        }

        private class LessTransform : IBundleTransform
        {
            public void Process(BundleContext context, BundleResponse response)
            {
                response.Content = dotless.Core.Less.Parse(response.Content);
                response.ContentType = "text/css";
            }
        }
    }
}