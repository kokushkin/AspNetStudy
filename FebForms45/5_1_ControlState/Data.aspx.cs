using ControlState.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState
{
    public partial class Data : System.Web.UI.Page
    {
        public IEnumerable<string> GetData([Form] int? maxValue,
            [Control("opSelector", "SelectedOperator")] string operation)
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