<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2_5_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TreeView ID="TreeView1" runat="server" OnSelectedNodeChanged="TreeView1_SelectedNodeChanged" OnTreeNodePopulate="TreeView1_TreeNodePopulate" ImageSet="News" NodeIndent="10">
                <HoverNodeStyle Font-Underline="True"></HoverNodeStyle>
<%--                <LevelStyles>
                    <asp:TreeNodeStyle ChildNodesPadding="10" Font-Bold="true" Font-Size="20px"
                        ForeColor="LimeGreen" />
                    <asp:TreeNodeStyle ChildNodesPadding="5" Font-Bold="true" Font-Size="16px" />
                </LevelStyles>--%>
                <NodeStyle HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" Font-Names="Arial" Font-Size="10pt" ForeColor="Black"></NodeStyle>

                <ParentNodeStyle Font-Bold="False"></ParentNodeStyle>

                <SelectedNodeStyle HorizontalPadding="0px" VerticalPadding="0px" Font-Underline="True"></SelectedNodeStyle>
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
