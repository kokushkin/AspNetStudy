using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_4_Lists
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                for (int i = 3; i <= 5; i++)
                {
                    Listbox1.Items.Add("Option " + i.ToString());
                    DropdownList1.Items.Add("Option " + i.ToString());
                    CheckboxList1.Items.Add("Option " + i.ToString());
                    RadiobuttonList1.Items.Add("Option " + i.ToString());
                }
            }
        }

        protected void Button1_Click(object sender, System.EventArgs e)
        {
            Response.Write("<b>Выбранные элементы в Listbox1:</b><br/>");
            foreach (ListItem li in Listbox1.Items)
            {
                if (li.Selected) Response.Write("- " + li.Text + "<br/>");
            }

            Response.Write("<b>Выбранный элемент в DropdownList1:</b><br/>");
            Response.Write("- " + DropdownList1.SelectedItem.Text + "<br/>");

            Response.Write("<b>Выбранные элементы в CheckboxList1:</b><br/>");
            foreach (ListItem li in CheckboxList1.Items)
            {
                if (li.Selected) Response.Write("- " + li.Text + "<br/>");
            }

            Response.Write("<b>Выбранный элемент в RadiobuttonList1:</b><br/>");
            Response.Write("- " + RadiobuttonList1.SelectedItem.Text + "<br/><br/><br/>");
        }
    }
}