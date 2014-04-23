using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Optimization;

namespace HipChatWeb
{
  public class BundleConfig
  {
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.unobtrusive*", "~/Scripts/jquery.validate*"));

      bundles.Add(new ScriptBundle("~/bundles/knockout").Include("~/Scripts/knockout-{version}.js", "~/Scripts/knockout.validation.js"));

      bundles.Add(new ScriptBundle("~/bundles/app").Include(
          "~/Scripts/sammy-{version}.js",
          "~/Scripts/app/common.js",
          "~/Scripts/app/app.datamodel.js",
          "~/Scripts/app/app.viewmodel.js",
          "~/Scripts/app/home.viewmodel.js",
          "~/Scripts/app/_run.js"));

      bundles.Add(new ScriptBundle("~/bundles/signalr").Include("~/Scripts/jquery.signalR-{version}.js"));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/dateformat").Include("~/Scripts/jquery.dateFormat-{version}.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/Site.css"));

      bundles.Add(new StyleBundle("~/Content/bootstrap-flatly").Include("~/Content/Flatly/bootstrap*"));

      bundles.Add(new StyleBundle("~/Content/bootstrap-darkly").Include("~/Content/Darkly/bootstrap*"));

      bundles.Add(new StyleBundle("~/Content/bootstrap-yeti").Include("~/Content/Yeti/bootstrap*"));

      bundles.Add(new StyleBundle("~/Content/chat").Include("~/Content/chat.css"));

      // Set EnableOptimizations to false for debugging. For more information,
      // visit http://go.microsoft.com/fwlink/?LinkId=301862
      BundleTable.EnableOptimizations = true;
    }
  }
}
