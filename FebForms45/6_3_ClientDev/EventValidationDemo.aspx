<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EventValidationDemo.aspx.cs" 
    Inherits="ClientDev.EventValidationDemo" EnableEventValidation="false"%>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <style> 
        div { margin-bottom: 10px; }
    </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery") %>
    <script>
        $(document).ready(function () {
            var targetElem = $("#nameSelect");
            targetElem.attr("disabled", "true");
            $.ajax({
                url: "/api/game",
                type: "GET",
                success: function (data) {
                    for (var i = 0; i < data.length; i++) {
                        $("<option>" + data[i].Name
                            + "</option>").appendTo("#nameSelect");
                    }
                    targetElem.removeAttr("disabled");
                }
            });
        });
    </script>
</head>
<body>
<%--    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="nameSelect" runat="server">
                <asp:ListItem>Все</asp:ListItem>
            </asp:DropDownList>
            <button type="submit">Отправить</button>
        </div>
        <div>Значение из элемента управления: <span id="controlValue" runat="server"></span></div>
        <div>Значение из формы: <span id="formValue" runat="server"></span></div>
    </form>--%>
    <form id="form1" runat="server">
            <div>
                <select id="nameSelect" runat="server"> 
                    <option>Все</option>
                </select>
                <button type="submit">Отправить</button>
            </div>
            <div>Значение из формы: <span id="formValue" runat="server"></span></div>
    </form>
</body>
</html>
