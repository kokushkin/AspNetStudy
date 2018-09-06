<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DynamicFailure.aspx.cs" Inherits="ErrorHandling.DynamicFailure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style>
        body { font-family: sans-serif;}
    </style>
</head>
<body>
<h1>Извините</h1>
    <p>В приложении возникла какая-то ошибка и мы не смогли обработать ваш запрос.</p>
    <p><a href="<%: Request["aspxerrorpath"] %>">Попробуйте обновить страницу.</a></p>
</body>
</html>