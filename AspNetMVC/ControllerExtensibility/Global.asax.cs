using ControllerExtensibility.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControllerExtensibility
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            ControllerBuilder.Current.DefaultNamespaces.Add("MyNamespaceController");
            ControllerBuilder.Current.DefaultNamespaces.Add("MyProject.*");

            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ControllerBuilder.Current.SetControllerFactory(
                new DefaultControllerFactory(new CustomControllerActivator()));
        }
    }
}
