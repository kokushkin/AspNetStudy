<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2_5_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TreeView ID="TreeView1" runat="server">
                <Nodes>
                    <asp:TreeNode Text="Products">
                        <asp:TreeNode Text="Hardware" />
                        <asp:TreeNode Text="Software" />
                    </asp:TreeNode>
                    <asp:TreeNode Text="Services" />
                </Nodes>
            </asp:TreeView>
        </div>
    </form>
</body>
</html>
