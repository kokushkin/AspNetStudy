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
            //ViewBag.Message = TempData["Message"];
            //ViewBag.Date = TempData["Date"];
            return View();
        }

        public RedirectResult Redirect()
        {
            return RedirectPermanent("/Basic/Index");
        }

        public RedirectToRouteResult RedirectRoute()
        {
            TempData["Message"] = "Привет";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
        }

        public HttpStatusCodeResult StatusCode()
        {
            // Ошибка 404 - URL не может быть обслужен
            //return new HttpStatusCodeResult(404, "Страница не найдена");

            return new HttpUnauthorizedResult();
        }
    }
}