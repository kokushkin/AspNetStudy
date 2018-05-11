<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_4_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="getEmployeesSDS" runat="server"
             ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
             SelectCommand="SELECT EmployeeID, FirstName, LastName, BirthDate, Title, City, Notes
                FROM Employees" />

<asp:GridView ID="GridView1" runat="server"
            DataSourceID="getEmployeesSDS" AutoGenerateColumns="False" DataKeyNames="EmployeeID" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound="GridView1_RowDataBound">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="EmployeeID" HeaderText="Id" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" />
                <asp:BoundField DataField="Title" HeaderText="Title" />
                <asp:BoundField DataField="City" HeaderText="City" />
            </Columns>
            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />
</asp:GridView>
        </div>
    </form>
</body>
</html>
