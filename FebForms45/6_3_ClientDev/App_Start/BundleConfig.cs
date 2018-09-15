using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace ClientDev.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            Bundle validation = new ScriptBundle("~/bundle/validation")
     .Include("~/Scripts/jquery-{version}.js",
         "~/Scripts/jquery.validate.js",
         "~/Scripts/jquery.validate.unobtrusive.js");

            Bundle jquery = new CdnScriptBundle("~/bundle/jquery")
             .CdnInclude("~/Scripts/jquery-{version}.js",
                 "http://ajax.aspnetcdn.com/ajax/jQuery/jquery-{version}.min.js");

            Bundle jqueryui = new ScriptBundle("~/bundle/jqueryui");
            jqueryui.CdnPath =
                "https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/jquery-ui.min.js";
            jqueryui.Include("~/Scripts/jquery-{version}.js", "~/Scripts/jquery-ui-{version}.js");

            Bundle basicStyles = new StyleBundle("~/bundle/basicCSS")
                    .Include("~/MainStyles.css", "~/ErrorStyles.css");

            Bundle jqueryUIStyles = new StyleBundle("~/Content/themes/base/jqueryUICSS");
            jqueryUIStyles.CdnPath =
                "https://ajax.googleapis.com/ajax/libs/jqueryui/1.11.2/themes/smoothness/jquery-ui.min.css";
            jqueryUIStyles.IncludeDirectory("~/Content/themes/base", "*.css");




            bundles.UseCdn = true;

            bundles.Add(jquery);
            bundles.Add(jqueryui);
            bundles.Add(basicStyles);
            bundles.Add(jqueryUIStyles);
        }
    }
}