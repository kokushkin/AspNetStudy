<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_5_9_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function pageLoad() {
            var pageManager = Sys.WebForms.PageRequestManager.getInstance();
            pageManager.add_endRequest(endRequest);
        }
        function endRequest(sender, args) {
            // Обработка ошибки
            if (args.get_error() != null) {
                $get("lblError").innerHTML = args.get_error().message;

                // Подавить вывод ошибки в консоль
                args.set_errorHandled(true);
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
           
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">                
                <ContentTemplate>                    
                    <asp:Label ID="Label1" runat="server" />
                    <br />
                    <asp:Button ID="Button1" runat="server" Text="Обновить" OnClick="Button1_Click" />
                </ContentTemplate>
                    <Triggers>
                         <asp:AsyncPostBackTrigger ControlID="Timer1" EventName="Tick" />
                    </Triggers>
            </asp:UpdatePanel>
            <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Unnamed_Tick"></asp:Timer>
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label ID="Label2" runat="server" />
                    <br />
                    <asp:Button ID="Button2" runat="server" Text="Обновить" OnClick="Button1_Click" />
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <asp:Label ID="Label3" runat="server" />
                    <br />
                    <asp:Button ID="Button3" runat="server" Text="Обновить" OnClick="Button1_Click" />
                </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Button4" EventName="Click" />
                    </Triggers>
            </asp:UpdatePanel>
            <asp:Button ID="Button4" runat="server" Text="Обновить" OnClick="Button1_Click"/>
        </div>
    </form>
</body>
</html>
