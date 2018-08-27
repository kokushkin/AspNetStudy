<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Products.ascx.cs" Inherits="DynamicData_EntityTemplates_Products" %>

<tr class="td">
    <td class="DDLightHeader">
        <asp:Label ID="Label1" runat="server" Text="Продукт" />
    </td>
    <td>
        <asp:DynamicControl ID="DynamicControll" runat="server" DataField="ProductName" />
    </td>
</tr>
<tr class="td">
    <td class="DDLightHeader">
        <asp:Label ID="Label2" runat="server" Text="Цена за штуку" />
    </td>
    <td>
        <asp:DynamicControl ID="DynamicControl2" runat="server" DataField="UnitPrice" />
    </td>
</tr>
<tr class="td">
    <td class="DDLightHeader">
        <asp:Label ID="Label3" runat="server" Text="Скидка?" />
    </td>
    <td>
        <asp:DynamicControl ID="DynamicControl3" runat="server" DataField="Discontinued" />
    </td>
</tr>
<tr class="td">
    <td class="DDLightHeader">
        <asp:Label ID="Label4" runat="server" Text="На складе, шт" />
    </td>
    <td>
        <asp:DynamicControl ID="DynamicControl4" runat="server" DataField="UnitsInStock" />
    </td>
</tr>
