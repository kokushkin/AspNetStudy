using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _7_13_Simple_Data_Caching
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                Label1.Text += "Страница отправлена.<br />";
            }
            else
            {
                Label1.Text += "Страница создана.<br />";
            }

            DateTime? testItem = (DateTime?)Cache["TestItem"];
            if (testItem == null)
            {
                Label1.Text += "Создание объекта TestItem...<br />";
                testItem = DateTime.Now;

                Label1.Text += "Сохранение объекта TestItem в кэше сервера на 30 сек. <br />";
                Cache.Insert("TestItem", testItem, null,
                  DateTime.Now.AddSeconds(30), TimeSpan.Zero);
            }
            else
            {
                Label1.Text += "Извлечение TestItem из кэша...<br />";
                Label1.Text += "TestItem = '" + testItem.ToString();
                Label1.Text += "'<br />";
            }
            Label1.Text += "<br />";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}