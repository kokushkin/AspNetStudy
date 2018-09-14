﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GameTest.aspx.cs" Inherits="ClientDev.GameTest" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <style>
        div { margin-bottom: 10px; }
    </style>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jquery") %>
    <script>
        function GetObjectString(dataObject) {
            if (typeof dataObject === "string") {
                return dataObject;
            } else {
                var message = "";
                for (var prop in dataObject) {
                    message += prop + ": " + dataObject[prop] + "\n";
                }
                return message;
            }
        }

        $(document).ready(function () {
            $("button").click(function (e) {
                var action = $(e.target).attr("data-action");
                $.ajax({
                    url: action == "all" ? "/api/game" : "/api/game/1",
                    type: "GET",
                    dataType: "json",
                    success: function (data) {
                        if (Array.isArray(data)) {
                            var message = "";
                            for (var i = 0; i < data.length; i++) {
                                message += "Item " + [i] + "\n"
                                    + GetObjectString(data[i]) + "\n\n";
                            }
                            $("#results").text(message);
                        } else {
                            $("#results").text(GetObjectString(data));
                        }
                    }
                });
                e.preventDefault();
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <button data-action="all">Все записи</button>
            <button data-action="one">Одна запись</button>
        </div>
        <textarea id="results" cols="40" rows="10"></textarea>
    </form>
</body>
</html>