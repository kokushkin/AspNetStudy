<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_3_4_BulletedList.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
            Bullet styles:<br />
            <br />
            <asp:BulletedList BulletStyle="Numbered" DisplayMode="LinkButton" ID="BulletedList1"
                OnClick="BulletedList1_Click" runat="server">
            </asp:BulletedList>
        </div>
    </form>
</body>
</html>
