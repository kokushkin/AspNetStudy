using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_3_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Помните, что элемент управления должен загружаться 
            // в обработчике события Page.Load.
            // Событие DropDownList.SelectedIndexChanged запускается слишком поздно
            string ctrlName = lstControls1.SelectedItem.Value;
            if (ctrlName.EndsWith(".ascx"))
            {
                PlaceHolder1.Controls.Add(Page.LoadControl(ctrlName));
            }
            PanelLabel1.Text = "Загружено..." + ctrlName;
        }
    }
}