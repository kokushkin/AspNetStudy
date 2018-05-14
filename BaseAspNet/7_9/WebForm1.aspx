<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_9.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridMaster" runat="server" DataSourceID="getCategories" DataKeyNames="CategoryID"
                OnRowDataBound="gridMaster_RowDataBound">

                <Columns>
                    <asp:TemplateField HeaderText="Категория">
                        <ItemStyle VerticalAlign="Top" Width="20%" />
                        <ItemTemplate>
                            <br />
                            <b><%# Eval("CategoryName") %></b>
                            <br />
                            <br />
                            <%# Eval("Description") %>
                            <br />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Товары">
                        <ItemStyle VerticalAlign="Top" />
                        <ItemTemplate>
                            <asp:GridView ID="gridChild" runat="server" AutoGenerateColumns="false" Width="100%">
                                <Columns>
                                    <asp:BoundField DataField="ProductName" HeaderText="Название" ItemStyle-Width="80%" />
                                    <asp:BoundField DataField="UnitPrice" HeaderText="Цена" DataFormatString="{0:C}" />
                                </Columns>
                            </asp:GridView>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>

            <asp:SqlDataSource ID="getCategories" runat="server"
                ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
                SelectCommand="SELECT * FROM Categories" />
            <asp:SqlDataSource ID="getProductsSDS" runat="server"
                ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
                SelectCommand="SELECT * FROM Products WHERE CategoryID=@CategoryID">
                <SelectParameters>
                    <asp:Parameter Name="CategoryID" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
