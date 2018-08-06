<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_1_6_1.WebForm1" Theme="FunkyTheme"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server">Test</asp:TextBox>  <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" BackColor="#FFFFC0" Width="154px">
                <asp:ListItem>Test</asp:ListItem>
            </asp:ListBox>
            <br /><br /><br />
            <asp:Button ID="Button1" runat="server" Text="OK" Font-Bold="False" 
            	Font-Names="Futura Hv BT" Font-Size="Large" Width="69px" />
            <asp:Button ID="Button2" runat="server" Text="Отмена" 
            	Font-Names="Futura Hv BT" Font-Size="Large" Width="83px" /><br />
        </div>
    </form>
</body>
</html>
