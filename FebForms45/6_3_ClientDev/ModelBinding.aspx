<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModelBinding.aspx.cs" Inherits="ClientDev.ModelBinding" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery") %>
    <script>

        function getData() {
            $.ajax({
                url: "/api/game",
                type: "GET",
                data: {
                    categoryFilter: $("#category").val()
                },
                success: function (data) {
                    var list = $("#list");
                    list.empty();
                    for (var i = 0; i < data.length; i++) {
                        list.append("<li>" + data[i].Name + "</li");
                    }
                }
            });
        }

        $(document).ready(function () {
            getData();
            $("#category").change(getData);
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Категория: 
            <select id="category">
                <option>Все</option>
                <option>Симулятор</option>
                <option>Шутер</option>
                <option>RPG</option>
            </select>
        </div>
        <div>
            <ol id="list"></ol>
        </div>
    </form>
</body>
</html>