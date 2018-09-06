using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace ErrorHandling
{
    public enum Failure
    {
        None,
        Database,
        FileSystem,
        Network
    }

    public class Global : System.Web.HttpApplication
    {
        protected void Application_Error(object sender, EventArgs e)
        { }

        protected void Application_EndRequest(object sender, EventArgs e)
        { }
    }
}