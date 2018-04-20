using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_6_Calendar
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = "Вы выбрали следующие даты: <br />";
            foreach (DateTime dt in Calendar1.SelectedDates)
            {
                Label1.Text += dt.ToLongDateString() + "<br />";
            }
        }


        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsWeekend)
            {
                e.Cell.BackColor = System.Drawing.Color.Green;
                e.Cell.ForeColor = System.Drawing.Color.Yellow;
                e.Day.IsSelectable = false;
            }
        }
    }
}