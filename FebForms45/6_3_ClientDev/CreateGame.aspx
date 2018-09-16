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
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery") %>
    <script>
        $(document).ready(function () {
            $("input[type='submit']").click(function (e) {
                var input = $('#Name')[0];
                if (input.checkValidity() && !input.validity.customError) {
                    var length = input.value.length;
                    if (length < 5 || length > 20)
                        input.setCustomValidity("Имя должно содержать от 5 до 20 символов.");
                    else
                        input.setCustomValidity("");
                }
            })
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ValidationSummary runat="server" CssClass="error" />
        <table>
            <tr>
                <td>Название:</td>
                <td><input id="Name" runat="server" required="required" /></td>
            </tr>
            <tr>
                <td>Категория:</td>
                <td><input id="Category" runat="server" required="required" /></td>
            </tr>
            <tr>
                <td>Цена:</td>
                <td><input id="Price" runat="server" type="number" min="1" max="10000" required="required" /></td>
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
