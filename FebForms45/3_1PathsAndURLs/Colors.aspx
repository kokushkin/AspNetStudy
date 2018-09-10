<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Colors.aspx.cs" Inherits="PathsAndURLs.Colors" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
</head>
<body>
    Доступные цвета:
    <ol>
        <asp:Repeater ID="Repeater1" ItemType="System.String" 
            SelectMethod="GetColors" runat="server">
            <ItemTemplate>
                <li><%# Item %></li>                    
            </ItemTemplate>
        </asp:Repeater>
    </ol>
</body>
</html>