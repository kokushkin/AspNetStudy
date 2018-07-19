using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_2_2
{
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

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}