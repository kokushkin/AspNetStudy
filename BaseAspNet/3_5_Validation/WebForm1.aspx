<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_3_5_Validation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server">Name:</asp:Label>
            <asp:TextBox runat="server" Width="200px" ID="Name" />
            <asp:RequiredFieldValidator runat="server" ID="ValidateName" ControlToValidate="Name"
                ErrorMessage="Имя пустое" Display="dynamic">*
            </asp:RequiredFieldValidator>
            <br />
            <asp:Label runat="server">Date:</asp:Label>
            <asp:TextBox runat="server" Width="200px" ID="DayOff" />
            <asp:RangeValidator runat="server" ID="ValidateDayOff2" ControlToValidate="DayOff"
                MinimumValue="01/01/2012" MaximumValue="31/12/2012" Type="Date"
                ErrorMessage="Значение даты не входит в указанный диапазон" Display="dynamic"
                SetFocusOnError="True">*
            </asp:RangeValidator>
            <br />
            <asp:Label runat="server">Age:</asp:Label>
            <asp:TextBox runat="server" Width="200px" ID="Age" />
            <asp:CompareValidator runat="server" ID="ValidateAge" ControlToValidate="Age"
                ValueToCompare="18" Type="Integer"
                Operator="GreaterThanEqual" ErrorMessage="Вы должны быть старше 18 лет" Display="dynamic">*
            </asp:CompareValidator>
            <br />
            <asp:Label runat="server">Password:</asp:Label>
            <asp:TextBox TextMode="Password" runat="server" Width="200px" ID="Password" />
            <br />
            <asp:Label runat="server">Password:</asp:Label>
            <asp:TextBox runat="server" TextMode="Password" Width="200px" ID="Password2" />
            <asp:CompareValidator runat="server" ControlToValidate="Password2" ControlToCompare="Password" Type="String"
                ErrorMessage="Пароли не совпадают" Display="dynamic" ID="Comparevalidator1" Name="Comparevalidator1">
		 <img src="errorIcon.gif" alt="Пароли не совпадают" />
            </asp:CompareValidator>
            <br />
            <asp:Label runat="server">Email:</asp:Label>
            <asp:TextBox runat="server" Width="200px" ID="Email" />
            <asp:RegularExpressionValidator runat="server" ID="ValidateEmail"
                ControlToValidate="Email" ValidationExpression=".*@.{2,}\..{2,}"
                ErrorMessage="Некорректный формат E-mail" Display="dynamic">*
            </asp:RegularExpressionValidator>
            <br />
            <asp:Label runat="server">ID(/5):</asp:Label>
            <asp:TextBox runat="server" Width="200px" ID="EmpID" />
            <asp:CustomValidator runat="server" ID="ValidateEmpID2" ControlToValidate="EmpID"
                ClientValidationFunction="EmpIDClientValidate"
                ErrorMessage="Значение ID должно быть кратно 5" Display="dynamic"
                OnServerValidate="ValidateEmpID2_ServerValidate">*
            </asp:CustomValidator>            
            <script type="text/javascript">
                function EmpIDClientValidate(ctl, args) {

                    // Значение кратно 5, если остаток от деления на 5 равен 0
                    args.IsValid = (args.Value % 5 == 0);
                }
            </script>
            <br />
            <asp:ValidationSummary runat="server" ID="Summary" DisplayMode="BulletList" 
        HeaderText="<b>Пожалуйста, исправьте следующие ошибки: </b>" ShowSummary="true" ShowMessageBox="true" />
            <br />
            <asp:Button ID="Button" runat="server" Text="Button" OnClick="Button_Click" />
            <br />
            <asp:CheckBox ID="chkEnableValidators" runat="server" OnCheckedChanged="OptionsChanged" Checked="True"/>Validators enabled
            <br />
            <asp:CheckBox ID="chkEnableClientSide" runat="server" OnCheckedChanged="OptionsChanged" Checked="True" />Client-side validation enabled
            <br />
            <asp:CheckBox ID="chkShowMsgBox" runat="server" OnCheckedChanged="OptionsChanged" Checked="True"/>Show message box
            <br />
            <asp:CheckBox ID="chkShowSummary" runat="server" OnCheckedChanged="OptionsChanged" Checked="True"/>Show summary
        </div>
    </form>
</body>
</html>
