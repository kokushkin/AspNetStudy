<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1_1.Default" %>

<%@ Register src="Banner.ascx" tagname="Banner" tagprefix="mycontrol" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <mycontrol:Banner ID="Banner1" runat="server" />
        <br />
        <asp:Label ID="Label1" runat="server"><b>Page Content</b></asp:Label> 
    </form>
</body>
</html>
