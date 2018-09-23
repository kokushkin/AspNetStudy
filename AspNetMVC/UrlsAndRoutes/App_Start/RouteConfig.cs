using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

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

            routes.MapRoute("ShopSchema2", "Shop/OldMethod",
                defaults: new { action = "Index", controller = "Home" });

            routes.MapRoute("ShopSchema", "Shop/{action}",
                defaults: new { action = "Index", controller = "Home" });

            routes.MapRoute(null, "X{controller}/{action}");

            routes.MapRoute(null, "Public/{controller}/{action}",
                defaults: new { action = "Index", controller = "Home" });

            routes.MapRoute("MyRoute", "{controller}/{action}",
                defaults: new { action = "Index", controller = "Home" });
        }
    }
}
