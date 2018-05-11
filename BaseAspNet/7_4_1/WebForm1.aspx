<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_4_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Основы ASP.NET</title>
    <style>
        .Header th, .Row td {
            padding: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="getEmployeesSDS" runat="server"
             ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
             SelectCommand="SELECT EmployeeID, FirstName, LastName, BirthDate, Title, City, Notes
                FROM Employees" />

        <asp:GridView ID="GridView1" runat="server"
            DataSourceID="getEmployeesSDS" DataKeyNames="EmployeeID" AutoGenerateColumns="False"
            Font-Names="Trebuchet MS" Font-Size="Small" ForeColor="#333333" GridLines="None"
            RowStyle-CssClass="Row">

            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <HeaderStyle BackColor="#28a4fb" Font-Bold="True" ForeColor="White" CssClass="Header" />
            <AlternatingRowStyle BackColor="White" />

            <Columns>
                <asp:BoundField DataField="EmployeeID" HeaderText="ID" InsertVisible="False"
                    ReadOnly="True">
                    <ItemStyle Font-Bold="True" BorderWidth="1" />
                </asp:BoundField>
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" DataFormatString="{0:MM/dd/yyyy}">
                    <ItemStyle BackColor="LightSteelBlue" />
                </asp:BoundField>
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="Notes" HeaderText="Notes">
                    <ItemStyle Wrap="True" Width="400" />
                </asp:BoundField>
            </Columns>

        </asp:GridView>
        </div>
    </form>
</body>
</html>
