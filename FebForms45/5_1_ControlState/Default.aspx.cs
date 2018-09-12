using ControlState.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
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

            string name = Request.Form["Name"];
            if (String.IsNullOrEmpty(name))
                throw new FormatException("Пожалуйста, введите имя");
            else if (name.Length < 3 || name.Length > 20)
                throw new FormatException("Имя должно содержать от 3 до 20 символов");
            else if (!Regex.IsMatch(name, @"^[A-Za-zА-Яа-я\s]+"))
                throw new FormatException("В имени допускаются только буквы и пробелы");
            else
                model.Name = name;

            string age = Request.Form["age"];
            if (String.IsNullOrEmpty(age))
                throw new FormatException("Пожалуйста, введите возраст");
            else
            {
                int ageValue;
                if (!int.TryParse(age, out ageValue))
                    throw new FormatException("Некорректное значение для возраста");
                else
                {
                    if (ageValue < 5 || ageValue > 100)
                        throw new FormatException("Возраст должен находится в пределах от 5 до 100");
                    else
                        model.Age = ageValue;
                }
            }

            model.Cell = Request.Form["Cell"];
            model.Zip = Request.Form["Zip"];
            return model;
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