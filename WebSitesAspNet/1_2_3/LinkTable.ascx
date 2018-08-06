<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LinkTable.ascx.cs" Inherits="_1_2_2.LinkTable" %>

<table style="width:100%" cellpadding="2" border="1">
    <tr>
        <td>
            <p style="margin: 8px">
                <asp:Label ID="lblTitle" Font-Size="Small"
                    Font-Names="Verdana" Font-Bold="True" ForeColor="#C00000"
                    runat="server">[Вставьте заголовок]</asp:Label>
            </p>
        </td>
    </tr>
    <tr>
        <td>
            <asp:GridView ID="gridLinkList" runat="server" AutoGenerateColumns="false"
                ShowHeader="false" GridLines="None" OnRowCommand="gridLinkList_RowCommand">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <img height="23" src="exclaim.png" alt="Menu Item" style="vertical-align: middle" />
                            <asp:LinkButton runat="server" ID="link" Font-Names="Verdana" Font-Size="XX-Small"
                                ForeColor="#0000cd"
                                NavigateUrl='<%# DataBinder.Eval(Container.DataItem, "Url") %>'
                                CommandName="LinkClick"
                                Text='<%# DataBinder.Eval(Container.DataItem, "Text") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </td>
    </tr>
</table>