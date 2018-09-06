<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotFoundShared.aspx.cs" Inherits="ErrorHandling.NotFoundShared" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title></title>
    <style>
        body { font-family: sans-serif;}
    </style>
</head>
<body>
    <h1>Извините</h1>
    <p>В приложении возникла какая-то ошибка и мы не смогли обработать ваш запрос.</p>
    <p>(Вы задали запрос <strong><span id="errorSrc" runat="server"></span></strong>
        для страницы: <span id="requestedURL" runat="server"></span>)</p>
    <p><a href="Default.aspx">Перейти на главную?</a></p>
</body>
</html>