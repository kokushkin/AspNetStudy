<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5_2_1.Default"%>
<%--<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5_2_1.Default" ValidateRequest="false"%>--%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtInput" runat="server" Width="298px"></asp:TextBox>
            <asp:Button ID="cmdSubmit" runat="server" Text="Отправить" OnClick="cmdSubmit_Click" />
            <br /><br />
            <asp:Label ID="Label1" runat="server" />
        </div>
    </form>
</body>
</html>
