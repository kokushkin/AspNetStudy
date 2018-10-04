﻿using Filter.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Controllers
{
    public class HomeController : Controller
    {
        //[Authorize(Users = "admin")]
        [CustomAuth(true)]
        public string Index()
        {
            return "Это метод действия Index в контроллере Home";
        }

        [GoogleAuth]
        [Authorize(Users = "alex@google.com")]
        public string List()
        {
            return "Это метод действия List в контроллере Home";
        }

        [HandleError(ExceptionType = typeof(ArgumentOutOfRangeException),
            View = "RangeError")]
        public string RangeTest(int id)
        {
            if (id > 100)
            {
                return String.Format("Значение ID: {0}", id);
            }
            else
            {
                throw new ArgumentOutOfRangeException("id", id, "");
            }
        }

        //[CustomAction]
        //[ProfileAction]
        //[ProfileResult]
        //[ProfileAll]
        private Stopwatch timer;
        public string FilterTest()
        {
            return "Это метод действия FilterTest в контроллере Home";
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        protected override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                    string.Format("<div>Общее время: {0}</div>",
                        timer.Elapsed.TotalSeconds));
        }
    }
}