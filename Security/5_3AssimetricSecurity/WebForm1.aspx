<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_5_3AssimetricSecurity.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <asp:Panel ID="MainPanel" runat="server" BorderStyle="Solid" BorderWidth="1px">
                <table border="0" style="width:100%">
                    <tr>
                        <td style="width: 252px; height: 45px; text-align: left">Шаг 1:<br />
                            Сгенерировать ключ шифрования</td>
                        <td style="height: 45px">
                            <asp:LinkButton ID="GenerateKeyCommand" runat="server" OnClick="GenerateKeyCommand_Click">Сгенерировать ключ</asp:LinkButton><br />
                            <asp:TextBox ID="PublicKeyText" runat="server" Rows="5" TextMode="MultiLine"
                                Columns="40" Width="600px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 252px; height: 24px; text-align: left">Шаг 2:<br />
                            Исходная строка</td>
                        <td style="height: 24px">
                            <asp:TextBox ID="ClearDataText" runat="server" Rows="5" TextMode="MultiLine" 
                                Width="98%" Columns="40"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 252px; text-align: left">Step 3:<br />
                            Зашифрованная строка</td>
                        <td>
                            <asp:TextBox ID="EncryptedDataText" runat="server" Rows="5" TextMode="MultiLine"
                                Width="98%" Columns="40"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td style="width: 252px"></td>
                        <td>
                            <asp:LinkButton ID="EncryptCommand" runat="server" OnClick="EncryptCommand_Click">Зашифровать</asp:LinkButton>
                             
                            <asp:LinkButton ID="DecryptCommand" runat="server" 
                                OnClick="DecryptCommand_Click">Расшифровать</asp:LinkButton>
                             
                            <asp:LinkButton ID="ClearCommand" runat="server" 
                                OnClick="ClearCommand_Click">Очистить</asp:LinkButton>
                        </td>
                    </tr>
                </table>
            </asp:Panel>

        </div>
    </form>
</body>
</html>
