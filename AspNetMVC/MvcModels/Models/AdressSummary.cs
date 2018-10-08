using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcModels.Models
{
    //[System.Web.Mvc.Bind(Include = "City")]
    public class AdressSummary
    {
        public string City { get; set; }
        public string Country { get; set; }
    }
}