<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_2_2Parameters.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>" SelectCommand="SELECT DISTINCT [City] FROM [Employees]" />
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="City" DataValueField="City" AutoPostBack ="true"/>

            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>" SelectCommand="SELECT [EmployeeID], [FirstName], [LastName], [Title], [City] FROM [Employees] WHERE ([City] = @City)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="City" PropertyName="SelectedValue"/>
                </SelectParameters>
            </asp:SqlDataSource>
            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" AutoGenerateColumns="False" DataKeyNames="EmployeeID">
                <Columns>
                    <asp:BoundField DataField="EmployeeID" HeaderText="EmployeeID" InsertVisible="False" ReadOnly="True" SortExpression="EmployeeID" />
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName" />
                    <asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName" />
                    <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
