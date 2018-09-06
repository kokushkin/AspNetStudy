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
        {
            Failure failReason = CheckForRootCause();

            //if (failReason != Failure.None)
            //{
            //    Response.Redirect(string.Format
            //        ("/ComponentError.aspx?errorSource={0}&errorType={1}",
            //        failReason.ToString().ToLower(),
            //        Context.Error.GetType()));
            //}

            if (failReason != Failure.None)
            {
                Response.ClearHeaders();
                Response.ClearContent();
                Response.StatusCode = 200;

                Server.Execute(string.Format
                    ("/ComponentError.aspx?errorSource={0}&errorType={1}",
                    "the " + failReason.ToString().ToLower(),
                    Context.Error.GetType()));

                Context.ClearError();
            }
        }

        private Failure CheckForRootCause()
        {
            // Получить результаты последних проверок
            Array values = Enum.GetValues(typeof(Failure));
            return (Failure)values.GetValue(new Random().Next(values.Length));
        }
    }
}