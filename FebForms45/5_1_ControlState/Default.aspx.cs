using ControlState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlState
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                DisplayUser(GetUser());
        }

        protected User GetUser()
        {
            User model = new User();

            IValueProvider provider = new FormValueProvider(ModelBindingExecutionContext);
            if (this.TryUpdateModel<User>(model, provider))
                return model;
            else
                throw new FormatException("Не удалось привязать модель");
        }

        protected void DisplayUser(User user)
        {
            sname.InnerText = user.Name;
            sage.InnerText = user.Age.ToString();
            scell.InnerText = user.Cell;
            szip.InnerText = user.Zip;
        }
    }
}