<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server"
            TypeName="_6_6_Lib.EmployeeDB" SelectMethod="GetEmployees" />
        <asp:ListBox ID="ListBox1" runat="server" DataSourceID="ObjectDataSource1"
            DataTextField="EmployeeID" Width="60"></asp:ListBox>
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1"/>
    </form>
</body>
</html>
