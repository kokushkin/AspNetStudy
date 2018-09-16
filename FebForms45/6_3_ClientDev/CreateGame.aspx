﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateGame.aspx.cs" Inherits="ClientDev.CreateGame" %>
<%@ Register TagPrefix="control" Assembly="ClientDev" Namespace="ClientDev" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
     <style>
        th { text-align: left; }
        td[colspan="2"] { text-align: center; padding: 10px 0; }
        .error { color: red; }
        .input-validation-error { border: medium solid red;}
    </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/validation") %>
</head>
<body>
    <form id="form1" runat="server">
        <div id="errorSummary" data-valmsg-summary="true" class="error">
            <ul><li style="display:none"></li></ul>
            <asp:ValidationSummary runat="server" CssClass="error" />
        </div>
        <table>
           <control:ValidationRepeater runat="server" 
                ItemType="ClientDev.ValidationRepeaterDataItem"
                ModelType ="ClientDev.Models.Game"
                Properties="Name, Category, Price" >
                <PropertyTemplate>
                    <tr>
                        <td><%# Item.PropertyName %></td>
                        <td>
                            <input id="<%# Item.PropertyName %>"  
                                name="<%# Item.PropertyName %>"  
                                <%# Item.ValidationAttributes %> />
                        </td>
                    </tr>
                </PropertyTemplate>
            </control:ValidationRepeater>
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
