<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1_3_2.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Основы ASP.NET</title>
    <style>
        .container {
            border:1px ridge;
            padding:10px;  
            font-size:x-small;
            margin:10px;
            background:#aaa;
            width:300px;
        }
    </style>
</head>
<body>    
    <form id="form1" runat="server">
        <div id="div1" runat="server" class="container">
            <asp:DropDownList ID="lstControls1" runat="server" Width="215px" AutoPostBack="True">
                <asp:ListItem Value="(None)">(None)</asp:ListItem>
                <asp:ListItem Value="Banner.ascx">Banner</asp:ListItem>
                <asp:ListItem Value="LinkTable.ascx">LinkTable</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:PlaceHolder ID="PlaceHolder1" runat="server" />
            <br />
            <br />
            <asp:Label ID="PanelLabel1" runat="server" Font-Italic="True" EnableViewState="False" />
        </div>
    </form>
</body>
</html>
