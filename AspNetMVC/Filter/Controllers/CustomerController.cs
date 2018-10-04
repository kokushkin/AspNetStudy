using Filter.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filter.Controllers
{
    [SimpleMessage(Message = "A")]
    public class CustomerController : Controller
    {
        public string Index()
        {
            return "Это контроллер Customer";
        }

        [CustomOverrideActionFilters]
        [SimpleMessage(Message = "Б")]
        public string OtherMethod()
        {
            return "Это метод действия OtherMethod в контроллере Customer";
        }
    }
}