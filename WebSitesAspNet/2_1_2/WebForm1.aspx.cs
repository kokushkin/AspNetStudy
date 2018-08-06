using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _2_1_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            lblSummary.Text = String.Format(
            "<b>Вы выбрали: </b><br>Язык программирования: <em>{0}</em><br>" +
            "Число сотрудников: <em>{1}</em><br>Городов: <em>{2}</em><br>Программы: <em>",
            lstLanguage.Text, txtEmpCount.Text, txtLocCount.Text);
            foreach (ListItem item in lstTools.Items)
            {
                if (item.Selected)
                {
                    lblSummary.Text += item + " ";
                }
            }
            lblSummary.Text += "</em><br>";
        }
    }
}