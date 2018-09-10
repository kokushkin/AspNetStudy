<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConfigFiles.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
</head>
<body>
    <asp:Repeater ID="Repeater1" runat="server" SelectMethod="GetConfig" ItemType="System.String">
        <HeaderTemplate>
            <ul>
        </HeaderTemplate>
        <FooterTemplate>
            </ul>
        </FooterTemplate>
        <ItemTemplate>
            <li><%# Item %></li>
        </ItemTemplate>
    </asp:Repeater>
</body>
</html>