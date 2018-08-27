<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5_5_1.Default" %>
<%@ Register Assembly="5_5_1" Namespace="_5_5_1" TagPrefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Основы ASP.NET</title>
</head>
<body>
    <form id="form1" runat="server">
        <cc1:dynamicpanel runat="server" id="Panel1" onrefreshing="Panel1_Refreshing" 
            style="padding-right: 10px; padding-left: 10px; padding-bottom: 10px; padding-top: 10px" 
            bordercolor="Red" borderwidth="2px">
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="False" Font-Names="Verdana" Font-Size="X-Large" />
            <br /><br />
        </cc1:dynamicpanel>
        <br />
        <cc1:dynamicpanelrefreshlink runat="server" id="link1" panelid="Panel1">
            Обновить данные в панели
        </cc1:dynamicpanelrefreshlink>
    </form>
</body>
</html>
