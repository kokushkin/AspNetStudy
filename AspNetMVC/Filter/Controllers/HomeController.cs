﻿using Filter.Infrastructure;
using System;
using System.Collections.Generic;
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
    }
}