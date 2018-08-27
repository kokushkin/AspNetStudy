using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_9_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ScriptManager1_Navigate(object sender, HistoryEventArgs e)
        {
            if (e.State["Wizard1"] == null)
            {
                // Восстановить состояние страницы no умолчанию (например, для первой страницы)
                Wizard1.ActiveStepIndex = 0;
            }
            else
            {
                Wizard1.ActiveStepIndex = Int32.Parse(e.State["Wizard1"]);
            }
            Page.Title = "Step " + (Wizard1.ActiveStepIndex + 1).ToString();
        }

        protected void Wizard1_ActiveStepChanged(object sender, EventArgs e)
        {
            // Проверить, что это асинхронная обратная отправка, 
            // а не попытка выполнить навигацию
            if ((ScriptManager1.IsInAsyncPostBack) && (!ScriptManager1.IsNavigating))
            {
                string currentStep = Wizard1.ActiveStepIndex.ToString();
                ScriptManager1.AddHistoryPoint("Wizard1", Wizard1.ActiveStepIndex.ToString(),
                    "Шаг " + (Wizard1.ActiveStepIndex + 1).ToString());
            }
        }
    }
}