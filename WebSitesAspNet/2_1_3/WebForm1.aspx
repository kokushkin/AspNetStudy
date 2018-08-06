<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2_1_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Основы ASP.NET</title>
    <style>
        .navigationButton {
            padding: 6px;
            border: 2px solid #29acf7;
            background: white;
            border-radius: 6px;
        }
        .navigationButton:hover {
            background: #29acf7;
            color:white;
            cursor:pointer;
        }
        .sideBar {
            margin-top:20px;
        }
        .navigation {
            padding-top: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Wizard ID="Wizard1" runat="server" Width="448px"
            BackColor="#EFF3FB" BorderColor="#B5C7DE" BorderWidth="1px" Font-Names="Verdana"
            CellPadding="5" ActiveStepIndex="0" Font-Size="Small" OnFinishButtonClick="Wizard1_FinishButtonClick">
            <HeaderTemplate>
                <h3 style="color: green"><%= Wizard1.ActiveStep.Title %></h3>
            </HeaderTemplate>
            <SideBarTemplate>
                <div class="sideBar">
                    <asp:DataList runat="server" ID="SideBarList">
                        <ItemTemplate>
                            <asp:Button runat="server" ID="SideBarButton" />
                        </ItemTemplate>
                        <SelectedItemStyle Font-Bold="True" />
                    </asp:DataList>
                </div>
            </SideBarTemplate>
            <NavigationStyle CssClass="navigation" />
            <StartNavigationTemplate>
                <asp:Button runat="server" Text="Далее" CommandName="MoveNext" CssClass="navigationButton" />
            </StartNavigationTemplate>
            <StepNavigationTemplate>
                <asp:Button runat="server" Text="Назад" CommandName="MovePrevious" CssClass="navigationButton" />
                <asp:Button runat="server" Text="Далее" CommandName="MoveNext" CssClass="navigationButton" />
            </StepNavigationTemplate>
            <FinishNavigationTemplate>
                <asp:Button runat="server" Text="Назад" CommandName="MovePrevious" CssClass="navigationButton" />
                <asp:Button runat="server" Text="Добавить заказ"
                    CommandName="MoveComplete" CssClass="navigationButton" />
            </FinishNavigationTemplate>
            <WizardSteps>
                <asp:WizardStep ID="WizardStep1" runat="server" Title="Персональные данные">
                    <h3>Язык программирования</h3>
                    Выберите используемый язык программирования:
                  <asp:DropDownList ID="lstLanguage" runat="server">
                      <asp:ListItem>C#</asp:ListItem>
                      <asp:ListItem>VB</asp:ListItem>
                      <asp:ListItem>J#</asp:ListItem>
                      <asp:ListItem>Java</asp:ListItem>
                      <asp:ListItem>C++</asp:ListItem>
                      <asp:ListItem>C</asp:ListItem>
                  </asp:DropDownList>
                    <br />
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep2" runat="server" Title="Компания">
                    <h3>Данные о компании</h3>
                    Количество сотрудников:
                    <asp:TextBox ID="txtEmpCount" runat="server"></asp:TextBox><br />
                    Количество городов:     
                    <asp:TextBox ID="txtLocCount" runat="server"></asp:TextBox>
                </asp:WizardStep>
                <asp:WizardStep ID="WizardStep3" runat="server" Title="Программы">
                    Необходимые лицензии:
                  <asp:CheckBoxList ID="lstTools" runat="server">
                      <asp:ListItem>Visual Studio 2008</asp:ListItem>
                      <asp:ListItem>Office 2012</asp:ListItem>
                      <asp:ListItem>Windows Server 2008</asp:ListItem>
                      <asp:ListItem>SQL Server 2008</asp:ListItem>
                  </asp:CheckBoxList>
                </asp:WizardStep>
                <asp:WizardStep ID="Complete" runat="server" Title="Итог " StepType="Complete">
                    <asp:Label ID="lblSummary" runat="server"></asp:Label>
                    <br />
                    <br />
                    Спасибо что заполнили эту анкету.<br />
                    Ваши продукты будут доставлены в ближайшее время.
                    <br />
                    <br />
                </asp:WizardStep>
            </WizardSteps>
            <SideBarStyle VerticalAlign="Top" />
        </asp:Wizard>
    </form>
</body>
</html>
