<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5_5.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Основы ASP.NET</title>
    <script type="text/javascript">
        var xmlRequest;

        function CreateXMLHttpRequest() {
            try {
                // Этот код работает, если XMLHttpRequest является частью JavaScript
                xmlRequest = new XMLHttpRequest();
            }
            catch (err) {
                // В противном случае требуется объект ActiveX
                xmlRequest = new ActiveXObject("Microsoft.XMLHTTP");
            }
        }

        function ClientCallback(result, context) {
            // Найти элемент списка
            var lstTerritories = document.getElementById("lstTerritories");

            // Очистить содержимое списка
            lstTerritories.innerHTML = "";

            // Получить массив со списком территориальных записей
            var rows = result.split("||");

            for (var i = 0; i < rows.length - 1; ++i) {
                // Разбить каждую запись на два поля
                var fields = rows[i].split("|");
                var territoryDesc = fields[0];
                var territoryID = fields[1];

                // Создать элемент списка
                var option = document.createElement("option");

                // Сохранить идентификатор в атрибуте value
                option.value = territoryID;

                // Отобразить описание в тексте элемента списка
                option.innerHTML = territoryDesc;

                // Добавить элемент в конец списка
                lstTerritories.appendChild(option);
            }
        }
    </script>
</head>
<body onload="CreateXMLHttpRequest();">
    <form id="form1" runat="server">
        <div style="font-family: Verdana; font-size: small">
            Выберите регион, а затем город:<br />
            <br />
            <asp:DropDownList ID="lstRegions" runat="server" Width="210px" DataSourceID="sourceRegions" 
                DataTextField="RegionDescription" DataValueField="RegionID" />
            <asp:DropDownList ID="lstTerritories" runat="server" Width="275px" />
            <br /><br /><br />
            <asp:Button ID="cmdOK" runat="server" Text="OK" Width="50px" OnClick="cmdOK_Click" />
            <br /><br />
            <asp:Label ID="lblInfo" runat="server"></asp:Label>
            <asp:SqlDataSource ID="sourceRegions" runat="server" ConnectionString="<%$ ConnectionStrings:Northwind %>" 
                SelectCommand="SELECT 0 As RegionID, '' AS RegionDescription UNION SELECT RegionID, RegionDescription FROM Region" />
        </div>
    </form>
</body>
</html>
