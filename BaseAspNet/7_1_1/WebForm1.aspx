<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_1_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image runat="server" ImageUrl='<%# FilePath %>' ID="Image1" />
            <br />
            <asp:Label runat="server" Text='<%# FilePath %>' ID="Label1" />
            <br />
            <asp:TextBox runat="server" Text='<%# GetFilePath() %>' ID="Textbox1" />
            <br />
            <asp:HyperLink runat="server" NavigateUrl='<%# LogoPath.Value %>'
                Font-Bold="True" Text="Показать изображение" ID="Hyperlink1" />
            <br />
            <input type="hidden" runat="server" id="LogoPath" value="myimg.jpg" name="LogoPath" />
            <b><%# FilePath %></b>
            <br />
            <img src="<%# GetFilePath() %>" alt="<%# GetFilePath() %>" />
        </div>
    </form>
</body>
</html>
