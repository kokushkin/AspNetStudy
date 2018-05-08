<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="_7_3.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ObjectDataSource ID="sourceEmployeesList" runat="server" SelectMethod="GetEmployees"
                TypeName="_6_6_Lib.EmployeeDB" />
            <asp:ListBox ID="lstEmployees" runat="server" DataSourceID="sourceEmployeesList" DataTextField="EmployeeID"
                Width="131px" AutoPostBack="True" Height="171px" />
            <asp:ObjectDataSource ID="sourceEmployee" runat="server" SelectMethod="GetEmployee"
                TypeName="_6_6_Lib.EmployeeDB" OnSelecting="sourceEmployee_Selecting">
                <SelectParameters>
                    <asp:ControlParameter ControlID="lstEmployees" Name="employeeID" PropertyName="SelectedValue" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <asp:DetailsView ID="DetailsView2" runat="server"
                DataSourceID="sourceEmployee" Height="50px" Width="125px" />
        </div>
    </form>
</body>
</html>
