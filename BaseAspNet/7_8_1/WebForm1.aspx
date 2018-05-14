<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_8_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridEmployees" runat="server" DataSourceID="getProductsSDS" OnRowCommand="gridEmployees_RowCommand">

                <Columns>
                    <asp:TemplateField HeaderText="Наличие">
                        <ItemTemplate>
                            <asp:ImageButton ID="ImageButton1" runat="server"
                                ImageUrl="<%# GetStatusPicture(Container.DataItem) %>"
                                CommandName="StatusClick"
                                CommandArgument='<%# Eval("ProductName") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField HeaderText="ID" DataField="ProductID" />
                    <asp:BoundField HeaderText="Название" DataField="ProductName" />
                    <asp:BoundField HeaderText="Цена" DataField="UnitPrice" DataFormatString="{0:c}" />
                    <asp:BoundField HeaderText="Кол-во на складе" DataField="UnitsInStock"
                        ItemStyle-HorizontalAlign="Right" />
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="getProductsSDS" runat="server"
                ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
                SelectCommand="SELECT * FROM Products" />

            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
