﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClientDev
{
    public partial class EventValidationDemo : System.Web.UI.Page
    {
        //protected void Page_Load(object sender, EventArgs e)
        //{
        //    controlValue.InnerText = nameSelect.SelectedValue;
        //    formValue.InnerText = Request.Form["nameSelect"];
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            formValue.InnerText = Request.Form["nameSelect"];
        }
    }
}