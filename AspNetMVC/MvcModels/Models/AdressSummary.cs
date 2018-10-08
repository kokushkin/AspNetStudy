using MvcModels.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcModels.Models
{
    //[System.Web.Mvc.Bind(Include = "City")]
    [ModelBinder(typeof(AddressSummaryBinder))]
    public class AdressSummary
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}