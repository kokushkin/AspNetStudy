<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_5_9_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server" />
            <script>
                var prm = Sys.WebForms.PageRequestManager.getInstance();
                prm.add_initializeRequest(InitializeRequest);

                function InitializeRequest(sender, args) {
                    if (prm.get_isInAsyncPostBack()) {
                        args.set_cancel(true);
                    }
                }

                function AbortPostBack() {
                    if (prm.get_isInAsyncPostBack()) {
                        prm.abortPostBack();
                    }
                }
            </script>

            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <div style="background-color: #FFFFE0; padding: 20px">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" />
                        <br />
                        <br />
                        <asp:Button ID="cmdRefreshTime" runat="server" 
                            Text="Запустить процесс обновления страницы"
                            OnClick="cmdRefreshTime_Click" />
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>

            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <br /><br />
                    <div style="font-size: x-small">
                        Соединение с сервером ...
                        <img src="ajax-loader.gif" alt="Загрузка" style="vertical-align:middle" />
                        <input id="Button1" onclick="AbortPostBack()" 
                            type="button" value="Отменить задачу" />
                    </div>
                </ProgressTemplate>
            </asp:UpdateProgress>
        </div>
</form>
</body>
</html>
