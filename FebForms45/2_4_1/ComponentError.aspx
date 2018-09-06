<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ComponentError.aspx.cs" Inherits="ErrorHandling.ComponentError" %>

<!DOCTYPE html>
<html>
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <h1>Извините</h1>
    <p>Произошла ошибка в файле
        <span><%: Request["errorSource"] %></span> 
        и мы не смогли корректно обработать ваш запрос.</p>
    <p>Тип ошибки - <span><%: Request["errorType"] %></span></p>
    <p><a href="Default.aspx">Перейти на главную?</a></p>    
</body>
</html>