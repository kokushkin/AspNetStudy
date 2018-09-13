﻿using System;
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
            Bundle jquery = new ScriptBundle("~/bundle/jquery")
                .Include("~/Scripts/jquery-{version}.js");
            Bundle jqueryui = new ScriptBundle("~/bundle/jqueryui")
                .Include("~/Scripts/jquery-{version}.js", "~/Scripts/jquery-ui-{version}.js");

            Bundle basicStyles = new StyleBundle("~/bundle/basicCSS")
                .Include("~/MainStyles.css", "~/ErrorStyles.css");
            Bundle jqueryUIStyles = new StyleBundle("~/Content/themes/base/jqueryUICSS")
                    .IncludeDirectory("~/Content/themes/base", "*.css");

            bundles.Add(jquery);
            bundles.Add(jqueryui);
            bundles.Add(basicStyles);
            bundles.Add(jqueryUIStyles);
        }
    }
}