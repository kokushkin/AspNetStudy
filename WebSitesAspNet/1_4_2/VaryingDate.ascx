<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="VaryingDate.ascx.cs" Inherits="_1_4_2.VaryingDate" %>

<%@ OutputCache Duration="30" VaryByControl="lstMode" %>

<asp:DropDownList ID="lstMode" runat="server" Width="187px">
    <asp:ListItem>Large</asp:ListItem>
    <asp:ListItem>Small</asp:ListItem>
    <asp:ListItem>Medium</asp:ListItem>
</asp:DropDownList> <br />
<asp:Button ID="Button1" Text="Задать высоту текста" runat="server" />
<br />
<br />

Генерируемое содержимое:<br />
<asp:Label ID="TimeMsg" runat="server" />

<%--Этот ввод учитывается только раз в Duration сек--%>
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<asp:Label ID="Label1" runat="server"></asp:Label>
