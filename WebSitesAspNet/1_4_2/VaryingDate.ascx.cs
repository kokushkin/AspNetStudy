using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_4_2
{
    public partial class VaryingDate : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (lstMode.SelectedIndex)
            {
                case 0:
                    TimeMsg.Font.Size = FontUnit.Large;
                    break;
                case 1:
                    TimeMsg.Font.Size = FontUnit.Small;
                    break;
                case 2:
                    TimeMsg.Font.Size = FontUnit.Medium;
                    break;
            }
            TimeMsg.Text = DateTime.Now.ToString("F");

            //проверка как сказывается кеширование на полях ввода
            Label1.Text = TextBox1.Text;
        }
    }    
}