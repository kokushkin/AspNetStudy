<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Multiples.aspx.cs" Inherits="AsyncApp.Multiples" 
    Async="true"%>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <style>
        table { border: thin solid black; border-collapse: collapse; font-family: Tahoma}
        th, td { text-align: left; padding: 5px; border: thin solid black;}
    </style>
</head>
<body>
    <table>
        <tr><th>Время начала</th><th>URL</th><th>Длина</th></tr>
        <asp:Repeater id="rep" SelectMethod="GetResults" 
                ItemType="AsyncApp.MultiWebSiteResult" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Item.StartTime %></td>
                    <td><%# Item.Url %></td>
                    <td><%# Item.Length %></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</body>
</html>
