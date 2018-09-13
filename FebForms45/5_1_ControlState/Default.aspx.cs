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
        public User GetUser([Form]User user)
        {
            return user;
        }
    }
}