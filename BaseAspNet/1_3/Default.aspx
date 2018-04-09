<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 87px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position: absolute; left: 100px; top: 50px; width: 200px; border: 1px solid red; background-color: #008080;">
            <asp:Label ID="Label1" runat="server" Text="LABLE" ForeColor="#FF5050"></asp:Label><br /><br />
            <asp:Button ID="Button1" runat="server" Text="Button"/> <br />
            <asp:Calendar ID="Calendar1" runat="server" BackColor="#FFFFCC" BorderColor="#FFCC66" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="#663399" Height="200px" ShowGridLines="True" Width="220px">
                <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
                <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
                <OtherMonthDayStyle ForeColor="#CC9966" />
                <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
                <SelectorStyle BackColor="#FFCC66" />
                <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
                <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
            </asp:Calendar> <br />

            <asp:Table ID="Table1" runat="server" Height="42px" Width="65px"></asp:Table> <br />
            <table style="width: 100%;">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
