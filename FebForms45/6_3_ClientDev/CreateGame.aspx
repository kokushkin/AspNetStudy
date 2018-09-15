<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateGame.aspx.cs" Inherits="ClientDev.CreateGame" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
     <style>
        th { text-align: left; }
        td[colspan="2"] { text-align: center; padding: 10px 0; }
        .error { color: red; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ValidationSummary runat="server" CssClass="error" />
        <table>
            <tr>
                <td>Название:</td>
                <td><input id="Name" runat="server" /></td>
            </tr>
            <tr>
                <td>Категория:</td>
                <td><input id="Category" runat="server" /></td>
            </tr>
            <tr>
                <td>Цена:</td>
                <td><input id="Price" runat="server" /></td>
            </tr>
            <tr>
                <td colspan="2"><input type="submit" value="Добавить игру" runat="server"/></td>
            </tr>
            <tr><th>ID</th><th>Название</th><th>Категория</th><th>Цена</th></tr>
            <asp:Repeater runat="server" 
                    ItemType="ClientDev.Models.Game" SelectMethod="GetCreated">
                <ItemTemplate>
                    <tr>
                        <td><%#: Item.GameId %></td>
                        <td><%#: Item.Name %></td>
                        <td><%#: Item.Category %></td>
                        <td><%#: Item.Price.ToString("F2") %></td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </form>
</body>
</html>
