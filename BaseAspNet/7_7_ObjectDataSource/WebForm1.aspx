<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_7_ObjectDataSource.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridEmployees" runat="server" DataSourceID="getEmployeesODS"
                AllowPaging="true" PageSize="5" AutoGenerateColumns="true">
                <PagerSettings Mode="NextPrevious" PreviousPageText="<< Назад"
                    NextPageText="Вперед >>" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#444" HorizontalAlign="Center" />
            </asp:GridView>

            <asp:ObjectDataSource ID="getEmployeesODS" runat="server"
                TypeName="_6_6_Lib.EmployeeDB" SelectMethod="GetEmployees"
                EnablePaging="true" SelectCountMethod="CountEmployees">
            </asp:ObjectDataSource>

        </div>
    </form>
</body>
</html>
