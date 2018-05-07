using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_1_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Построить выражения привязки
            this.DataBind();
        }

        protected string GetFilePath()
        {
            return "myimg.jpg";
        }

        protected string FilePath
        {
            get { return "myimg.jpg"; }
        }
    }
}