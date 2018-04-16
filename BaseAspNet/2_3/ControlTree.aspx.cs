using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace _2_3
{
    public partial class ControlTree : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Header.Title = "Структура страницы ASP.NET";
            Page.Header.Description = "Описание возможностей ASP.NET по динамическому использованию элементов на странице";
            Page.Header.Keywords = "C#, .NET, ASP.NET";

            //А вот как можно добавить в заголовок другой метадескриптор
            HtmlMeta metaTag = new HtmlMeta();
            metaTag.HttpEquiv = "Content-Type";
            metaTag.Content = "text/html; charset=utf-8";
            Page.Header.Controls.Add(metaTag);


            DisplayControl(Page.Controls, 0);
            Response.Write("<hr/>");
        }

        private void DisplayControl(ControlCollection controls, int depth)
        {
            foreach (Control control in controls)
            {
                // Количество отступов в представлении дерева элементов управления
                Response.Write(new String('-', depth * 4) + "> ");

                // Отобразить элемент управления
                Response.Write(control.GetType().ToString() + " - <b>" +
                  control.ID + "</b><br />");

                if (control.Controls != null)
                {
                    DisplayControl(control.Controls, depth + 1);
                }
            }
        }
    }
}