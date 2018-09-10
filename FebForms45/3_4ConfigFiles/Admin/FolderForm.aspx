<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FolderForm.aspx.cs" Inherits="ConfigFiles.Admin.FolderForm" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <h3>Это файл ~/Admin/FolderForm.aspx</h3>
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
