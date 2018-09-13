<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Data.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Магазин игр</title>
    <style> 
        div { margin-bottom: 10px;}
        th, td { text-align: left; min-width: 65px;}
        td {padding-bottom: 5px;}
        th, table { border-bottom: solid thin black;}
        th:last-child, td:last-child { text-align: right;}
        body { font-family: "Arial Narrow", sans-serif;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <asp:Repeater ID="Repeater1" ItemType="Data.Models.Game"
                    SelectMethod="GetGamesData" runat="server">
                    <HeaderTemplate>
                        <tr>
                            <th>Название</th>
                            <th>Категория</th>
                            <th>Цена</th>
                        </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#: Item.Name %></td>
                            <td><%#: Item.Category %></td>
                            <td><%#: Item.Price.ToString("F2") %></td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
        <div>
            Фильтр:
            <select name="filterSelect">
                <asp:Repeater ID="Repeater2" ItemType="Data.CategoryView"
                    SelectMethod="GetCategories" runat="server">
                    <ItemTemplate>
                <option <%# Item.Selected %>><%# Item.Name %></option>
                    </ItemTemplate>
                </asp:Repeater>
            </select>
            <button type="submit">Выбрать</button>
        </div>
    </form>
</body>
</html>