<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_6_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Введите ID заказчика: 
            <br />
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <asp:Button ID="cmdGetRecords"
                runat="server" Text="Получить данные" OnClick="cmdGetRecords_Click"></asp:Button>
            <br />
            <br />
            <asp:GridView ID="GridView1"
                runat="server" Width="392px" Height="123px" Font-Names="Verdana" Font-Size="X-Small">
            </asp:GridView>
        </div>
    </form>
</body>
</html>
