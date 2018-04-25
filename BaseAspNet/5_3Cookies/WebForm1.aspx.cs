using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_3Cookies
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Создать объект cookie-набора
            HttpCookie cookie = new HttpCookie("My localhost cookie 1");

            // Установить значения в нем
            cookie["A"] = "Russian1";
            cookie["B"] = "ru-ru1";

            // Добавить куки в ответ
            Response.Cookies.Add(cookie);

            cookie.Expires = DateTime.Now.AddYears(1);

            // Создать объект cookie-набора
            cookie = new HttpCookie("My localhost cookie 2");

            // Установить значения в нем
            cookie["A"] = "Russian2";
            cookie["B"] = "ru-ru2";

            // Добавить куки в ответ
            Response.Cookies.Add(cookie);

            cookie.Expires = DateTime.Now.AddYears(1);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookieReq = Request.Cookies["My localhost cookie 1"];
        
            string language;
            if (cookieReq != null)
            {
                language = cookieReq["A"];
            }

            cookieReq = Request.Cookies["My localhost cookie 2"];

            if (cookieReq != null)
            {
                language = cookieReq["A"];
            }
        }
    }
}