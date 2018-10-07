﻿using HelperMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelperMethods.Controllers
{
    public class PeopleController : Controller
    {
        private List<User> UserData = new List<User> {
            new User {FirstName = "Иван", LastName = "Иванов", Role = Role.Admin},
            new User {FirstName = "Петр", LastName = "Петров", Role = Role.User},
            new User {FirstName = "Сидор", LastName = "Сидоров", Role = Role.User},
            new User {FirstName = "Вася", LastName = "Васильев", Role = Role.Guest}
        };

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult GetPeopleData(string selectedRole = "All")
        {
            IEnumerable<User> users = UserData;
            if (selectedRole != "All")
            {
                Role selected = (Role)Enum.Parse(typeof(Role), selectedRole);
                users = UserData.Where(p => p.Role == selected);
            }
            return PartialView(users);
        }

        //??????????
        public ActionResult GetPeople(string selectedRole = "All")
        {
            return View((Object)selectedRole);
        }

        //public ActionResult GetPeople()
        //{
        //    return View(UserData);
        //}

        //[HttpPost]
        //public ActionResult GetPeople(string selectedRole)
        //{
        //    if (selectedRole == "All" || selectedRole == null)
        //        return View(UserData);
        //    else
        //    {
        //        Role roleSelected = (Role)Enum.Parse(typeof(Role), selectedRole);
        //        return View(UserData.Where(user => user.Role == roleSelected));
        //    }
        //}
    }
}