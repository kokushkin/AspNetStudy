<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_1_2.WebForm1" %>

<%@ Register src="TimeDisplay.ascx" tagname="TimeDisplay" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:TimeDisplay ID="TimeDisplay" Format="dddd, dd MMMM yyyy HH:mm:ss tt (GMT z)" runat="server"/>
            <br /><hr /><br />
            <uc1:TimeDisplay ID="TimeDisplay1" runat="server" />
        </div>
    </form>
</body>
</html>
