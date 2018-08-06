using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_1_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                DropDownList1.DataSource = MultiView1.Views;
                DropDownList1.DataTextField = "ID";
                DropDownList1.DataBind();
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = DropDownList1.SelectedIndex;
        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {
            DropDownList1.SelectedIndex = MultiView1.ActiveViewIndex;
        }
    }
}