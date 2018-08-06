<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_1_5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label" CssClass="heading1" />
            <div class="blockText" id="paragraph" runat="server">
	            <p>Этот контейнер использует стиль .blockText</p>
            </div>
        </div>
    </form>
</body>
</html>
