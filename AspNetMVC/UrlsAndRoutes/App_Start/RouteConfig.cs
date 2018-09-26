﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;
using UrlsAndRoutes.Infrastructure;

namespace UrlsAndRoutes
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            //);

            //routes.MapMvcAttributeRoutes();

            ////routes.MapRoute("NewRoute", "App/Do{action}",
            ////    new { controller = "Home" });

            //routes.MapRoute(
            //    name: "Default",
            //    url: "{controller}/{action}/{id}",
            //    defaults: new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    });


            routes.MapMvcAttributeRoutes();

            routes.Add(new Route("SayHello", new CustomRouteHandler()));

            routes.Add(new LegacyRoute(
                "~/articles/About_ASPNET_MVC",
                "~/old/NET_Framework_4"
                ));

            routes.MapRoute("MyRoute", "{controller}/{action}");
            routes.MapRoute("MyOtherRoute", "App/{action}", new { controller = "Home" });
        }
    }
}
