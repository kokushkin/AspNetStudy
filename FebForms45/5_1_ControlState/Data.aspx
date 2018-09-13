<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="ControlState.Data" %>
<%@ Register TagPrefix="CC" Assembly="5_1_ControlState" Namespace="ControlState.Controls" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <input id="max" value="5" runat="server" />
            <CC:OperationSelector id="opSelector" runat="server" />
            <button type="submit">Выполнить</button>
        </div>
        <div>
            <asp:Repeater SelectMethod="GetData" ItemType="System.String" 
                    runat="server" ViewStateMode="Disabled">
                <ItemTemplate>
                    <p><%# Item %></p>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
