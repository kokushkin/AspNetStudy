using MvcModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModels.Controllers
{
    public class HomeController : Controller
    {
        private List<User> UserCollection = new List<User> {
            new User {UserId = 1, FirstName = "Иван",
                LastName = "Иванов", Role = Role.Admin},
            new User {UserId = 2, FirstName = "Петр",
                LastName = "Петров", Role = Role.User},
            new User {UserId = 3, FirstName = "Сидор",
                LastName = "Сидоров", Role = Role.User},
            new User {UserId = 4, FirstName = "Вася",
                LastName = "Васильев", Role = Role.Guest}
        };

        public ActionResult Index(int id = 1)
        {
            User user = UserCollection.Single(u => u.UserId == id);
            return View(user);
        }

        public ActionResult CreateUser()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult CreateUser(User model)
        {
            return View("Index", model);
        }

        public ActionResult DisplaySummary([Bind(Prefix = "HomeAddress", Exclude = "Country")] AdressSummary summary)
        {
            return View(summary);
        }

        public ActionResult Names(List<string> names)
        {
            names = names ?? new List<string>();
            return View(names);
        }

        public ActionResult Address(List<AdressSummary> addresses)
        {
            addresses = addresses ?? new List<AdressSummary>();
            return View(addresses);
        }
    }
}