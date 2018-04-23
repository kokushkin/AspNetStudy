using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _5_1_ViewState
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cmdSave_Click(object sender, EventArgs e)
        {
            return;
            // Сохранить текущий текст        
            SaveAllText(Page.Controls, true);
        }

        private void SaveAllText(ControlCollection controls, bool saveNested)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    // Сохранить текст с использованием уникального                 
                    // идентификатора элемента управления                
                    ViewState[control.ID] = ((TextBox)control).Text;
                }

                if ((control.Controls != null) && saveNested)
                {
                    SaveAllText(control.Controls, true);
                }
            }
        }

        private void RestoreAllText(ControlCollection controls, bool saveNested)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    if (ViewState[control.ID] != null)
                        ((TextBox)control).Text = (string)ViewState[control.ID];
                }

                if ((control.Controls != null) && saveNested)
                {
                    RestoreAllText(control.Controls, true);
                }
            }
        }

        protected void cmdRestore_Click(object sender, EventArgs e)
        {
            // Извлечь последний сохраненный текст        
            RestoreAllText(Page.Controls, true);
        }
    }
}