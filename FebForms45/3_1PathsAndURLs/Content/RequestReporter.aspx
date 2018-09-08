<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RequestReporter.aspx.cs" Inherits="PathsAndURLs.Content.RequestReporter" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
</head>
<body>
    <table>
        <tr>
            <td>Оригинальный путь</td>
            <td><%= Request.FilePath %></td>
        </tr>
        <tr>
            <td>Оригинальный физический путь к файлу</td>
            <td><%= Request.PhysicalPath %></td>
        </tr>
        <tr>
            <td>Текущий виртуальный путь</td>
            <td><%= Request.CurrentExecutionFilePath %></td>
        </tr>
        <tr>
            <td>Текущий виртуальный путь к файлу</td>
            <td><%= Server.MapPath(Request.CurrentExecutionFilePath) %></td>
        </tr>
    </table>
</body>
</html>
