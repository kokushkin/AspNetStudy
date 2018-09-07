﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace PathsAndURLs
{
    public class SimpleModule : IHttpModule
    {
        public void Init(HttpApplication app)
        {
            app.BeginRequest += (src, args) => ProcessRequest(app);
        }

        private void ProcessRequest(HttpApplication app)
        {
            WriteMsg("URL запроса: {0}", app.Request.RawUrl);
        }

        private void WriteMsg(string formatString, params object[] vals)
        {
            Debug.WriteLine(formatString, vals);
        }

        public void Dispose()
        {
            // Нечего освобождать
        }
    }
}