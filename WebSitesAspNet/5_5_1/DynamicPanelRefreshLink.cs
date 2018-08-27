using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_5_1
{
    public class DynamicPanelRefreshLink : LinkButton
    {
        public DynamicPanelRefreshLink()
        {
            PanelID = "";
        }

        public string PanelID
        {
            get { return (string)ViewState["DynamicPanelID"]; }
            set { ViewState["DynamicPanelID"] = value; }
        }

        protected override void AddAttributesToRender(HtmlTextWriter writer)
        {
            if (!DesignMode)
            {
                DynamicPanel pnl = (DynamicPanel)Page.FindControl(PanelID);
                if (pnl != null)
                {
                    writer.AddAttribute("onclick", pnl.GetCallbackScript(this, ""));
                    writer.AddAttribute("href", "#");
                }
            }
        }
    }
}