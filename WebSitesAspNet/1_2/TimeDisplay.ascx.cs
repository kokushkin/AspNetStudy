using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_2
{
    public partial class TimeDisplay : System.Web.UI.UserControl
    {
        public string Format
        {
            get;
            set;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
                RefreshTime();
        }

        protected void lnkTime_Click(object sender, EventArgs e)
        {
            RefreshTime();
        }

        public void RefreshTime()
        {
            lnkTime.Text = Format == null ?
                DateTime.Now.ToLongTimeString() : DateTime.Now.ToString(Format);
        }
    }
}