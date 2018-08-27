<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_5_9_3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">
    <div>
        <asp:scriptmanager id="ScriptManager1" runat="server"
            enablehistory="True"
            onnavigate="ScriptManager1_Navigate" />

        <asp:updatepanel id="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Wizard ID="Wizard1" runat="server" BackColor="#EFF3FB"
                        BorderColor="#B5C7DE" BorderWidth="1px" Font-Names="Verdana"
                        Font-Size="0.9em" ActiveStepIndex="0" CellPadding="10" Height="146px"
                        OnActiveStepChanged="Wizard1_ActiveStepChanged" Width="412px">
                        <StepStyle Font-Size="0.8em" ForeColor="#333333" Width="200px" />
                        <WizardSteps>
                            <asp:WizardStep ID="WizardStep1" runat="server" Title="Шаг 1">
                                Страница для шага 1.
                            </asp:WizardStep>
                            <asp:WizardStep ID="WizardStep2" runat="server" Title="Шаг 2">
                                Страница для шага 2.
                            </asp:WizardStep>
                            <asp:WizardStep ID="WizardStep3" runat="server" Title="Шаг 3">
                                Страница для шага 3.
                            </asp:WizardStep>
                        </WizardSteps>
                        <SideBarButtonStyle BackColor="#507CD1" Font-Names="Verdana"
                            ForeColor="White" />
                        <NavigationButtonStyle BackColor="White" BorderColor="#507CD1"
                            BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em"
                            ForeColor="#284E98" />
                        <SideBarStyle BackColor="#507CD1" Font-Size="0.9em" VerticalAlign="Top" />
                        <HeaderStyle BackColor="#284E98" BorderColor="#EFF3FB" BorderStyle="Solid"
                            BorderWidth="2px" Font-Bold="True" Font-Size="0.9em" ForeColor="White"
                            HorizontalAlign="Center" />
                    </asp:Wizard>
                </ContentTemplate>
            </asp:updatepanel>
    </div>
</form>
</body>
</html>
