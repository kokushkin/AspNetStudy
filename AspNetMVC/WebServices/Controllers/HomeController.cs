using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class HomeController : Controller
    {
        ReservationRepository repository = ReservationRepository.Current;
        public ViewResult Index()
        {
            return View(repository.GetAll());
        }

        public ActionResult Add(Reservation item)
        {
            if (ModelState.IsValid)
            {
                repository.Add(item);
                return RedirectToAction("Index");
            }
            else return View("Index");
        }

        public ActionResult Update(Reservation item)
        {
            if (ModelState.IsValid && repository.Update(item))
                return RedirectToAction("Index");
            else return View("Index");
        }
    }
}