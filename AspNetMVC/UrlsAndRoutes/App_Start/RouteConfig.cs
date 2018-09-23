using System;
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

            //routes.MapRoute(
            //    name: "MyRoute",
            //    url: "{controller}/{action}/{id}/{*catchcall}",
            //    defaults: new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //        id = UrlParameter.Optional
            //    }
            //);

            routes.MapRoute(
                name: "GoogleChromeRoute",
                url: "{*catchcall}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index"
                },
                constraints: new
                {
                    custom = new UserAgentConstraint("Chrome")
                },
                namespaces: new[] { "UrlsAndRoutes.AdditionalControllers" });

            routes.MapRoute(
                name: "MyRoute",
                url: "{controller}/{action}/{id}/{*catchcall}",
                defaults: new
                {
                    controller = "Home",
                    action = "Index",
                    id = UrlParameter.Optional
                },
                namespaces: new[] { "UrlsAndRoutes.Controllers" },
                constraints: new
                {
                    controller = "^H.*",
                    action = "^Index$|^CustomVariable$",
                    httpMethod = new HttpMethodConstraint("GET", "POST"),
                    id = new CompoundRouteConstraint(new IRouteConstraint[] {
                        new AlphaRouteConstraint(),
                        new MinLengthRouteConstraint(6)})
                });
        }
    }
}
