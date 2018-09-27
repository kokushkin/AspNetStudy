using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        // GET: Example
        public ViewResult Index()
        {
            ViewBag.Message = "Привет";
            ViewBag.Date = DateTime.Now;
            return View();
        }
    }
}