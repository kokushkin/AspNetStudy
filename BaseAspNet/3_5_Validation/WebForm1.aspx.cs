using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_5_Validation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ValidateEmpID2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            try
            {
                args.IsValid = (int.Parse(args.Value) % 5 == 0);
            }
            catch
            {
                args.IsValid = false;
            }
        }

        protected void OptionsChanged(object sender, EventArgs e)
        {
            // Просмотреть все элементы управления 
            // проверкой достоверности. 
            foreach (BaseValidator validator in Page.Validators)
            {
                // Включить или отключить элементы управления проверкой 
                // достоверности в зависимости от значения флажка Validators 
                // enabled (chkEnableValidators). 
                validator.Enabled = chkEnableValidators.Checked;

                // Включить или отключить проверку достоверности 
                // на стороне клиента в зависимости от значения флажка 
                // Client-side validation enabled (chkEnableClientSide). 
                validator.EnableClientScript = chkEnableClientSide.Checked;
            }

            // Сконфигурировать сводную информацию по проверке достоверности 
            // на основе значений двух последних флажков
            Summary.ShowMessageBox = chkShowMsgBox.Checked;
            Summary.ShowSummary = chkShowSummary.Checked;
        }

        protected void Button_Click(object sender, EventArgs e)
        {

        }
    }
}