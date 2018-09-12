<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ControlState.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Привязка моделей</title>
    <style>
        label {display: inline-block;width: 100px;text-align: right; margin: 5px;}
        div.panel {float: left;margin-left: 10px;}
        div.panel label { text-align: right;}
        div.error, span.error { color: red;}
        button { margin: 10px 100px;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ValidationSummary HeaderText="Исправьте следующие ошибки:" CssClass="error" runat="server" />
        <div class="panel">
            <div>
                <label>Имя:</label>
                <input id="name" runat="server" />
            </div>
            <div>
                <label>Возраст:</label>
                <input id="age" runat="server" />
            </div>
            <div>
                <label>Номер:</label>
                <input id="cell" runat="server" />
            </div>
            <div>
                <label>Индекс:</label>
                <input id="zip" runat="server" />
            </div>
            <button type="submit">Отправить</button>
        </div>
        <div class="panel">
            <div><label>Ваше имя:</label><span id="sname" runat="server"></span></div>
            <div><label>Ваш возраст:</label><span id="sage" runat="server"></span></div>
            <div><label>Ваш номер:</label><span id="scell" runat="server"></span></div>
            <div><label>Ваш индекс:</label><span id="szip" runat="server"></span></div>
        </div>
    </form>

</body>
</html>