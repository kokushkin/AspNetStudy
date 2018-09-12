using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace AsyncApp
{
    public class AsyncHandler : HttpTaskAsyncHandler

    {

        public override async Task ProcessRequestAsync(HttpContext context)

        {

            string webResponse

                = await new WebClient().DownloadStringTaskAsync("http://professorweb.ru");

            context.Response.ContentType = "text/plain";

            context.Response.Write(string.Format("Длина загруженной страницы: {0}",

                webResponse.Length));

        }

    }
}