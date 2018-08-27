using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_9_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //    throw new ApplicationException("Какая-то ошибка");
            SetCurrentTime();
        }

        protected void Unnamed_Tick(object sender, EventArgs e)
        {
            // Обновить счетчик тактов и сохранить его в состоянии представления
            int tickCount = 0;
            if (ViewState["TickCount"] != null)
            {
                tickCount = (int)ViewState["TickCount"];
            }

            tickCount++;
            ViewState["TickCount"] = tickCount;

            // Принять решение об отключении таймера
            if (tickCount >= 10)
            {
                Timer1.Enabled = false;
            }

            SetCurrentTime();
        }

        void SetCurrentTime()
        {
            Label1.Text = Label2.Text = Label3.Text = DateTime.Now.ToLongTimeString();
        }
    }
}