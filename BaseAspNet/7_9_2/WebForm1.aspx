<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_9_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView" runat="server" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <table border='1'>
                                <tr>
                                    <td>
                                        <img src='ImageFromDB.ashx?ID=<%# DataBinder.Eval(Container.DataItem, "pub_id") %>'
                                            alt="Logo" /></td>
                                </tr>
                            </table>
                            <b>
                                <%# Eval("pub_name") %>
                            </b>
                            <br>
                            <%# Eval("city") %>
					,
					<%# Eval("state") %>
					,
					<%# Eval("country") %>
                            <br>
                            <br>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>

            <asp:SqlDataSource ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:Pubs %>"
                SelectCommand="SELECT * FROM publishers" runat="server" />
        </div>
    </form>
</body>
</html>
