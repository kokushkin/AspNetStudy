using System;
using System.IO;
using System.Web;

namespace PathsAndURLs
{
    public class ExtensionlessHandler : IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<p>HTTP-обработчик Expressionless</p>");
            string vpath = context.Request.Path;
            if (vpath == "/")
            {
                context.Server.Transfer("/Default.aspx");
            }
            else if (File.Exists(context.Request.MapPath(vpath + ".aspx")))
            {
                context.Server.Transfer(vpath + ".aspx");
            }
            else
            {
                context.Response.StatusCode = 404;
                context.ApplicationInstance.CompleteRequest();
            }
        }

        #endregion
    }
}
