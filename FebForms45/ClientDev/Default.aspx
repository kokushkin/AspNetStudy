<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClientDev.Default" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
    <%: System.Web.Optimization.Styles.Render("~/bundle/basicCSS", "~/bundle/jqueryUICSS") %>
    <%: System.Web.Optimization.Scripts.Render("~/bundle/jqueryui") %>
    <script>
        $(document).ready(function () {
            $('input[type=submit]').button();
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input type="submit" name="color" value="Red" />
            <input type="submit" name="color" value="Green" />
            <input type="submit" name="color" value="Blue" />
        </div>
        <div>
            <span class="message">
                Выбран цвет:
                <span id="selectedValue" runat="server">
                    <span class="error">Ничего не выбрано</span>
                </span>
            </span>
        </div>
    </form>
</body>
</html>