<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:SqlDataSource ID="getEmployeesSDS" runat="server"
             ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
             SelectCommand="SELECT EmployeeID, LastName, FirstName, BirthDate, City FROM Employees" />

       Выберите тип сортировки: <asp:DropDownList ID="lstSorts" runat="server" 
           Font-Names="Verdana" AutoPostBack="True" OnSelectedIndexChanged="lstSorts_SelectedIndexChanged" Width="309px">
            <asp:ListItem>EmployeeID</asp:ListItem>
            <asp:ListItem>LastName, FirstName</asp:ListItem>
            <asp:ListItem>BirthDate, FirstName, LastName</asp:ListItem>
        </asp:DropDownList><br /><br />

        <asp:GridView ID="gridEmployees" runat="server" DataSourceID="getEmployeesSDS" DataKeyNames="EmployeeID"
            BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px"
            CellPadding="6" GridLines="Horizontal" AutoGenerateColumns="False"
            AllowSorting="true" OnSorting="gridEmployees_Sorting" EnablePersistedSelection="true">
            <Columns>
                <asp:ButtonField DataTextField="EmployeeID" ButtonType="Button" CommandName="Select" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" DataFormatString="{0:dd/MM/yyyy}"
                     SortExpression="BirthDate" />
            </Columns>

            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        </asp:GridView>
    </form>
</body>
</html>
