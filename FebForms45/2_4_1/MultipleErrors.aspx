<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultipleErrors.aspx.cs" Inherits="ErrorHandling.MultipleErrors" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <h1>Извините</h1>
    <p>В приложении возникли следующие проблемы:</p>
    <p>
        <asp:Repeater ID="Repeater1" ItemType="System.String" SelectMethod="GetErrorMessages" runat="server">
            <HeaderTemplate>
                <ul>
            </HeaderTemplate>
            <ItemTemplate>
                <li><%# Item %></li>        
            </ItemTemplate>
            <FooterTemplate>
                </ul>
            </FooterTemplate>
        </asp:Repeater>
    </p>
    <p><a href="Default.aspx">Перейти на главную?</a></p>    
</body>
</html>