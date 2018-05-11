<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <asp:SqlDataSource ID="getEmployeesSDS" runat="server"
             ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
             SelectCommand="SELECT EmployeeID, LastName, FirstName, City FROM Employees" />

        <!-- Извлекает данные из трех связанных таблиц:
             Employees -> EmployeeTerritories (ключ EmployeeID)
             EmployeeTerritories -> Territories (ключ TerritoryID )
         -->
        <asp:SqlDataSource ID="sourceRegionsSDS" runat="server"
            ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
            SelectCommand="SELECT Employees.EmployeeID, Territories.TerritoryID, 
                Territories.TerritoryDescription FROM Employees 
                INNER JOIN EmployeeTerritories 
                ON Employees.EmployeeID = EmployeeTerritories.EmployeeID 
                INNER JOIN Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID 
                WHERE (Employees.EmployeeID = @EmployeeID)">
            <SelectParameters>
                <asp:ControlParameter ControlID="gridEmployees" Name="EmployeeID" 
                    PropertyName="SelectedDataKey.Values['EmployeeID']" />
            </SelectParameters>
        </asp:SqlDataSource>

        <!-- Таблица сотрудников - "главная" -->
        <asp:GridView ID="gridEmployees" runat="server" DataSourceID="getEmployeesSDS" DataKeyNames="EmployeeID"
            BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px"
            CellPadding="6" GridLines="Horizontal" AutoGenerateColumns="False" OnSelectedIndexChanged="gridEmployees_SelectedIndexChanged">
            <Columns>
                <asp:ButtonField DataTextField="EmployeeID" ButtonType="Button" CommandName="Select" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
            </Columns>

            <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
            <RowStyle BackColor="White" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
        </asp:GridView>

        <br />

        <asp:Label ID="lblRegionCaption" runat="server" Text="Label"></asp:Label>

        <br /><br />
        <!-- Регионы, за которые отвечает выбранный сотрудник ("детальная") -->
        <asp:GridView ID="gridRegions" runat="server" DataSourceID="sourceRegionsSDS" />
    </form>
</body>
</html>
