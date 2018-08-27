using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_5_1
{
    public class DynamicPanel : Panel, ICallbackEventHandler, ICallbackContainer
    {
        public event EventHandler Refreshing;

        public void RaiseCallbackEvent(string eventArgument)
        {
            // Инициировать событие для уведомления клиента о том, что затребовано обновление
            if (Refreshing != null)
            {
                Refreshing(this, EventArgs.Empty);
            }
        }

        public string GetCallbackResult()
        {
            // Подготовить текстовый ответ, который будет отправлен обратно странице
            EnsureChildControls();

            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter writer = new HtmlTextWriter(sw))
                {
                    // Добавить идентификатор этой панели
                    writer.Write(this.ClientID + "_");

                    // Сгенерировать только часть страницы, находящуюся внутри панели
                    this.RenderContents(writer);
                }
                return sw.ToString();
            }
        }

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            string script = @"<script type='text/javascript'>
            function RefreshPanel(result, context)
            {
               if (result != '')
               {
                 var separator = result.indexOf('_'); 
                 var elementName = result.substr(0, separator);
                 var panel = document.getElementById(elementName);
                 panel.innerHTML = result.substr(separator+1);
               }
             }
          </script>";

            Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
                "RefreshPanel", script);
        }

        public string GetCallbackScript(IButtonControl buttonControl, string argument)
        {
            return Page.ClientScript.GetCallbackEventReference(
                this, "", "RefreshPanel", "null", true);
        }
    }
}