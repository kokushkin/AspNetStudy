using ControlState.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState
{
    public partial class Data : System.Web.UI.Page
    {
        int maxValue;
        string operation;

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                maxValue = int.Parse(max.Value);
                OperationSelector selector = FindControl("opSelector") as OperationSelector;

                if (selector != null)
                    operation = selector.SelectedOperator;
            }
        }

        public IEnumerable<string> GetData()
        {
            if (operation != null)
            {
                for (int i = 1; i < maxValue; i++)
                {
                    yield return string.Format("{0} {1} {2} = {3}",
                        maxValue, operation == "Сложить" ? "+" : "-",
                        i, operation == "Сложить" ? (maxValue + i) : (maxValue - i));
                }
            }
        }
    }
}