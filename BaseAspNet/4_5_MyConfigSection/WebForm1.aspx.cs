﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _4_5_MyConfigSection
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OrderService custSection =
    (OrderService)ConfigurationManager.GetSection("orderService");

            txt1.InnerHtml = "Извлеченная информация из web.config/orderService... <br/><br/>"
                + "<b>Location:</b> " + custSection.Location +
                "<br /><b>Available:</b> " + custSection.Available.ToString() +
                "<br /><b>Timeout:</b> " + custSection.PollTimeout.ToString() + "<br /><br />";
        }
    }
}