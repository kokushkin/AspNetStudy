using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ControllersAndActions.Controllers
{
    public class DerivedController : Controller
    {
        // GET: Derived
        public ActionResult Index()
        {
            ViewBag.Message =
                "Привет из контроллера DerivedController метода действия Index";
            return View("MyView");
        }

        public ActionResult ActionMethod()
        {
            // Получить доступ к разнообразным свойствам из объектов контекста
            string userName = User.Identity.Name;
            string serverName = Server.MachineName;
            string clientIP = Request.UserHostAddress;
            DateTime dateStamp = HttpContext.Timestamp;

            // Извлечь отправленные данные из Request.Form 
            string oldProductName = Request.Form["OldName"];
            string newProductName = Request.Form["NewName"];

            // ...

            return View();
        }

        public ActionResult WeatherForecast(DateTime forDate, string city = "Москва", int page = 1)
        {
            // реализовать прогноз погоды
            return View();
        }

    }
}