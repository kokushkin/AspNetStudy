using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_2_2
{
    public delegate void LinkClickedEventHandler(object sender, LinkTableEventArgs e);

    public partial class LinkTable : System.Web.UI.UserControl
    {
        public string Title
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        private LinkTableItem[] items;
        public LinkTableItem[] Items
        {
            get { return items; }
            set
            {
                items = value;

                // Обновить GridView
                gridLinkList.DataSource = items;
                gridLinkList.DataBind();
            }
        }

        public event LinkClickedEventHandler LinkClicked;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gridLinkList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            // Перед генерацией события удостовериться в существовании,
            // по меньшей мере, одного зарегистрированного обработчика события
            if(LinkClicked != null)
            {
                // Получить объект LinkButton, на котором был выполнен щелчок
                LinkButton link = (LinkButton)e.CommandSource;

                // Создать аргументы события
                LinkTableItem item = new LinkTableItem(link.Text, link.CommandArgument);
                LinkTableEventArgs args = new LinkTableEventArgs(item);

                // Запустить событие
                LinkClicked(this, args);

                // Перейти по ссылке, если получатель события не отменил операцию
                if(!args.Cancel)
                {
                    Response.Redirect(item.Url);
                }
            }
        }
    }
}