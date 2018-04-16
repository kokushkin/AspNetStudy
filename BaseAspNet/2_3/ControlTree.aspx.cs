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





            //добавляем динамическую кнопку
            //каждый раз ее нужно создавать заново.
            //если это повторная отправка которая была вызвана щедчком по кнопке, то тут мы ее все равно создаем и 
            //только тогда будет вызван обработчик, присоединенный ниже
            
            // Создать новый объект кнопки. 
            Button newButton = new Button();

            // Присвоить некоторый текст и идентификатор для будущего извлечения. 
            newButton.Text = "* Dynamic Button *";
            newButton.ID = "newButton";

            // Добавить кнопку к панели. 
            MainPanel.Controls.Add(newButton);

            // Подключить обработчик событий Button.Click
            newButton.Click += dynamicButton_Click;
            
        }

        private void dynamicButton_Click(object sender, EventArgs e)
        {

            //удаление динамичской кнопки, возможно меет места в сценариях, когда нужно чтобы после щелчка по ней она исчезла.
            //Хотя если щелкнуть затем по другой кнопке, Этот обработчик не вызовиться и она опять появиться
            // Поиск динамической кнопки в коллекции Page.Controls
            Button foundButton = (Button)Page.FindControl("newButton");
            // Удаление кнопки
            if (foundButton != null)
                foundButton.Parent.Controls.Remove(foundButton);


            return;
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