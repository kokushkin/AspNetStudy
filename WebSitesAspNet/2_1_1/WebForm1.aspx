<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2_1_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0" OnActiveViewChanged="MultiView1_ActiveViewChanged">

            <asp:View ID="View1" runat="server">
                <b>Представление #1</b><br />
                <br />
                <asp:Image ID="Image1" runat="server" ImageUrl="~/cookies.jpg" />
                 <asp:Button ID="cmdNext" runat="server" Text="Next >" CommandName="NextView" />
            </asp:View>

            <asp:View ID="View2" runat="server">
                <b>Представление #2</b><br />
                <br />
                Контент страницы.
                <asp:Button ID="cmdPrev" runat="server" Text="< Prev" CommandName="PrevView" />
	            <asp:Button ID="cmdNext2" runat="server" Text="Next >" CommandName="NextView" />
            </asp:View>

            <asp:View ID="View3" runat="server">
                <b>Представление #3</b><br />
                <br />
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <asp:Button ID="Button1" runat="server" Text="< Prev" CommandName="PrevView" />
            </asp:View>

        </asp:MultiView>
    </form>
</body>
</html>
