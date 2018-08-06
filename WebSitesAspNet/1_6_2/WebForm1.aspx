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
            	Font-Names="Futura Hv BT" Font-Size="Large" Width="69px" SkinID="Dramatic" />
            <asp:Button ID="Button2" runat="server" Text="Отмена" 
            	Font-Names="Futura Hv BT" Font-Size="Large" Width="83px" /><br />
            <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
            <asp:ImageButton ID="ImageButton1" runat="server" SkinID="OKButton" />
            <asp:ImageButton ID="ImageButton2" runat="server" SkinID="CancelButton" />
        </div>
    </form>
</body>
</html>
