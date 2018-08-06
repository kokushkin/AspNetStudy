<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5_4.Default" %>

<!DOCTYPE html>

<html>
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

        function CallServerForUpdate() {
            var txt1 = document.getElementById("txt1");
            var txt2 = document.getElementById("txt2");

            var url = "CalculatorCallbackHandler.ashx?value1=" +
                txt1.value + "&value2=" + txt2.value;
            xmlRequest.open("GET", url);
            xmlRequest.onreadystatechange = ApplyUpdate;
            xmlRequest.send(null);
        }

        function ApplyUpdate() {
            // Проверить успешность получения ответа
            if (xmlRequest.readyState == 4) {
                if (xmlRequest.status == 200) {
                    var lbl = document.getElementById("lblResponse");

                    var response = xmlRequest.responseText;

                    if (response == "-") {
                        lbl.innerHTML = "Вы ввели некорректные числа.";
                    }
                    else {
                        var responseStrings = response.split(",");
                        lbl.innerHTML = "Сумма чисел: " +
                            responseStrings[0] + " <br>Сейчас: " + responseStrings[1];
                    }
                }
            }
        }
        
    </script>
</head>
<body onload="CreateXMLHttpRequest();">
    <form id="form1" runat="server">
        <div>
            <table style="width: 296px">
                <tr>
                    <td style="width: 55px">
                        <img src="lava_lamp.gif" alt="Animated Lamp" /></td>
                    <td style="font-size: x-small; width: 190px; font-family: Verdana">
                        Обратите внимание, что анимация GIF-изображения не останавливается, при синхронном 
                        запросе страница полностью бы обновилась.
                    </td>
                </tr>
            </table>
            <br />
            <br />
            Число 1: 
            <asp:TextBox ID="txt1" runat="server" onKeyUp="CallServerForUpdate();"></asp:TextBox><br />
            Число 2: 
            <asp:TextBox ID="txt2" runat="server" onKeyUp="CallServerForUpdate();"></asp:TextBox>
            <br /><br />
            <asp:Label ID="lblResponse" runat="server" BackColor="#FFFFC0" BorderStyle="Groove"
                BorderWidth="2px" Style="padding-right: 10px; padding-left: 10px; padding-bottom: 10px; padding-top: 10px"
                Width="440px" Font-Bold="True" Font-Names="Verdana" Font-Size="Small">
            </asp:Label>
        </div>
    </form>
</body>
</html>
