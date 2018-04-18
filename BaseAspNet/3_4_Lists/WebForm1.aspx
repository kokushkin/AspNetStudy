<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_3_4_Lists.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox runat="server" ID="Listbox1" SelectionMode="Multiple" Rows="5">
                <asp:ListItem Selected="True">Option1</asp:ListItem>
                <asp:ListItem>Option2</asp:ListItem>
            </asp:ListBox>
            <br />
            <br />
            <asp:DropDownList runat="server" ID="DropdownList1">
                <asp:ListItem Selected="True">Option 1</asp:ListItem>
                <asp:ListItem>Option 2</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:CheckBoxList runat="server" ID="CheckboxList1" RepeatColumns="3">
                <asp:ListItem Selected="true">Option 1</asp:ListItem>
                <asp:ListItem>Option 2</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:RadioButtonList runat="server" ID="RadiobuttonList1"
                RepeatDirection="Horizontal" RepeatColumns="2">
                <asp:ListItem Selected="true">Option 1</asp:ListItem>
                <asp:ListItem>Option 2</asp:ListItem>
            </asp:RadioButtonList>

            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
