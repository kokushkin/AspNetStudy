<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_2_3Update.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ProviderName="System.Data.SqlClient"
	ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
	SelectCommand="SELECT EmployeeID, FirstName, LastName, Title, City FROM Employees"
	UpdateCommand="UPDATE Employees SET FirstName=@FirstName, LastName=@LastName, Title=@Title,
		City=@City FROM Employees WHERE EmployeeID=@EmployeeID" />

            <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource2" AutoGenerateEditButton="true"></asp:GridView>
        </div>
        
    </form>
</body>
</html>
