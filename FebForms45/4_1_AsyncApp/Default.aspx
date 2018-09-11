<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AsyncApp.Default" 
    Async="true" AsyncTimeout="60" %>

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
        <tr>
            <th>URL</th>
            <th>Длина, байт</th>
            <th>Время запроса, мс</th>
            <th>Общее время запроса, мс</th>
        </tr>
        <tr>
            <td><%: GetResult().Url %></td>
            <td><%: GetResult().Length %></td>
            <td><%: GetResult().Blocked %></td>
            <td><%: GetResult().Total%></td>
        </tr>
    </table>
</body>
</html>
