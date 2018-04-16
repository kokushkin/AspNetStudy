using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_2_1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Выполнить инициализацию, только если страница запрашивается впервые. 
            // После этого данная информация отслеживается в состоянии представления
            if (!IsPostBack)
            {
                // Установить атрибуты стиля для настройки внешнего вида страницы
                TextBox1.Style["font-size"] = "20px";
                TextBox1.Style["color"] = "red";

                // Использовать немного отличающийся, но эквивалентный 
                // синтаксис для установки атрибута стиля
                TextBox1.Style.Add("background-color", "lightyellow");

                // Установить текст, отображаемый по умолчанию
                TextBox1.Value = "<Вставьте ваш e-mail>";

                // Установить другие нестандартные атрибуты. 
                TextBox1.Attributes["onfocus"] = "alert(TextBox1.value);";

            }
        }
    }
}