using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AsyncApp
{
    public class MultiWebSiteResult
    {
        public string Url { get; set; }
        public long Length { get; set; }
        public long StartTime { get; set; }
    }

    public partial class Multiples : System.Web.UI.Page
    {
        private ConcurrentQueue<MultiWebSiteResult> results;

        protected void Page_Load(object sender, EventArgs e)
        {
            string[] targetUrls
                = { "http://asp.net", "http://professorweb.ru", "http://google.com" };
            results = new ConcurrentQueue<MultiWebSiteResult>();

            foreach (string targetUrl in targetUrls)
            {
                MultiWebSiteResult result = new MultiWebSiteResult { Url = targetUrl };
                results.Enqueue(result);

                RegisterAsyncTask(new PageAsyncTask(async () =>
                {
                    result.StartTime
                            = (long)DateTime.Now.Subtract(Context.Timestamp).TotalMilliseconds;
                    string webContent = await new WebClient().DownloadStringTaskAsync(targetUrl);
                    result.Length = webContent.Length;
                    rep.DataBind();
                }));
            }
        }

        public IEnumerable<MultiWebSiteResult> GetResults()
        {
            return results;
        }
    }
}