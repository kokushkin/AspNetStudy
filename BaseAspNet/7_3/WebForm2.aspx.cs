﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sourceEmployee_Selecting(object sender,
            ObjectDataSourceSelectingEventArgs e)
        {
            if (e.InputParameters["employeeID"] == null) e.Cancel = true;
        }
    }
}