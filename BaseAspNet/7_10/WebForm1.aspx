<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListView ID="listEmployees" runat="server" DataSourceID="getEmployeesSDS" GroupItemCount="3">
                <LayoutTemplate>
                    <table border="1">
                        <tr id="groupPlaceholder" runat="server"></tr>
                    </table>
                </LayoutTemplate>
                <GroupTemplate>
                    <tr>
                        <td runat="server" id="itemPlaceholder" />
                    </tr>
                </GroupTemplate>
                <ItemTemplate>
                    <td>
                        <b>
                            <%# Eval("EmployeeID") %>- 
	<%# Eval("TitleOfCourtesy") %> <%# Eval("FirstName") %> <%# Eval("LastName") %></b><hr />
                        <small><i>
                            <%# Eval("Address") %><br />
                            <%# Eval("City") %>, <%# Eval("Country") %>,
	<%# Eval("PostalCode") %><br />
                            <%# Eval("HomePhone") %></i><br />
                            <br />
                            <%# Eval("Notes") %><br />
                            <br />
                        </small>
                    </td>
                </ItemTemplate>
            </asp:ListView>

            <asp:SqlDataSource ID="getEmployeesSDS" runat="server"
                ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
                SelectCommand="SELECT * FROM Employees" />
        </div>
    </form>
</body>
</html>
