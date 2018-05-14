<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_7_init.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridEmployees" runat="server" DataSourceID="getProductsSDS" DataKeyNames="ProductID"
            AllowPaging="true" PageSize="5" AutoGenerateColumns="false">

                <Columns>
                    <asp:BoundField HeaderText="ID" DataField="ProductID" />
                    <asp:BoundField HeaderText="Название" DataField="ProductName" />
                    <asp:BoundField HeaderText="Цена" DataField="UnitPrice" DataFormatString="{0:c}" />
                    <asp:BoundField HeaderText="Кол-во на складе" DataField="UnitsInStock"
                        ItemStyle-HorizontalAlign="Right" />
                </Columns>
            </asp:GridView>
        
<asp:SqlDataSource ID="getProductsSDS" runat="server"
	ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
	SelectCommand="SELECT ProductID, ProductName, UnitPrice, UnitsInStock FROM Products" />
        </div>
    </form>
</body>
</html>
