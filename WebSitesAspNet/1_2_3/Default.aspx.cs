using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_2_2
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Установить заголовок
            LinkTable1.Title = "Список ссылок";

            // Добавить коллекцию ссылок
            LinkTableItem[] items = new LinkTableItem[3];
            items[0] = new LinkTableItem("ProfessorWeb", "http://www.professorweb.ru");
            items[1] = new LinkTableItem("Microsoft", "http://www.microsoft.com");
            items[2] = new LinkTableItem("AddPHP", "http://www.addphp.ru");
            LinkTable1.Items = items;
        }

        protected void LinkTable1_LinkClicked(object sender, LinkTableEventArgs e)
        {
            Label1.Text = "Вы щелкнули по ссылке <b>\"" + e.SelectedItem.Text +
                "\"</b>, но перенаправление на страницу " + e.SelectedItem.Url +
                " не сработает, т.к. мы переопределили поведение в обработчие события LinkTable.LinkClicked";
            e.Cancel = true;
        }
    }
}