using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_3_Events
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CtrlChanged(Object sender, EventArgs e)
        {
            string ctrlName = ((Control)sender).ID;
            lstEvents.Items.Add(ctrlName + " Changed");

            // Выбрать последний элемент, чтобы список прокрутился 
            // и последние записи стали видимыми
            lstEvents.SelectedIndex = lstEvents.Items.Count - 1;
        }
    }
}