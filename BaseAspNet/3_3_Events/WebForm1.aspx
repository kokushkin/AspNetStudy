<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_3_3_Events.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h3>Список событий:</h3>
            <asp:ListBox ID="lstEvents" runat="server" Height="107px" Width="355px"></asp:ListBox><br />
            <h3>Элементы управления вводом:</h3>
            <asp:TextBox ID="TextBox" runat="server" AutoPostBack="True" OnTextChanged="CtrlChanged"></asp:TextBox><br />
            <br />
            <asp:CheckBox ID="CheckBox" runat="server" AutoPostBack="True" OnCheckedChanged="CtrlChanged"></asp:CheckBox><br />
            <br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="Sample" AutoPostBack="True" 
                OnCheckedChanged="CtrlChanged"></asp:RadioButton>
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="Sample" AutoPostBack="True"
                OnCheckedChanged="CtrlChanged"></asp:RadioButton>
        </div>
    </form>
</body>
</html>
