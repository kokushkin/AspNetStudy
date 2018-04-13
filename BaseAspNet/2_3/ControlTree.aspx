<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlTree.aspx.cs" Inherits="_2_3.ControlTree" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <p><i>Элемент HTML (не веб-элемент управления ASP.NET).</i></p>
    <form id="ControlForm" method="post" runat="server">
        <div>
            <asp:Panel ID="MainPanel" runat="server" Height="112px">
                <p>
                    <asp:Button ID="Button1" runat="server" Text="Button1"/>
                    <asp:Button ID="Button2" runat="server" Text="Button2"/>
                    <asp:Button ID="Button3" runat="server" Text="Button3"/>
                </p>
                <p>
                    <asp:Label ID="Label1" runat="server" Width="48px">Name:</asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </p>
            </asp:Panel>
            <p>
                <asp:Button ID="Button4" runat="server" Text="Button4" />
            </p>
        </div>
    </form>
    <p><i>Элемент HTML (не веб-элемент управления ASP.NET).</i></p>
</body>
</html>
