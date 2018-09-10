<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Count.aspx.cs" Inherits="PathsAndURLs.Count" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    Доступные числа:
    <ul>
        <asp:Repeater ID="Repeater1" ItemType="System.Int32" 
            SelectMethod="GetNumbers" runat="server">
            <ItemTemplate>
                <li><%# Item %></li>                    
            </ItemTemplate>
        </asp:Repeater>
    </ul> 
</body>
</html>
