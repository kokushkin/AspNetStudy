<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_7_8_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="gridEmployees" runat="server" DataSourceID="getEmployeesSDS" AutoGenerateEditButton="true" AutoGenerateColumns="false" DataKeyNames="EmployeeID" OnRowUpdating="gridEmployees_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="None">

                <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
                <Columns>
                    <asp:TemplateField HeaderText="Сотрудники компании Northwind">
                        <ItemTemplate>
                            <b>
                                <%# Eval("EmployeeID") %> - 
                            <%# Eval("TitleOfCourtesy") %> <%# Eval("FirstName") %>
                                <%# Eval("LastName") %>
                            </b>
                            <hr />
                            <small><i>
                                <%# Eval("Address") %><br />
                                <%# Eval("City") %>, <%# Eval("Country") %>,
                            <%# Eval("PostalCode") %><br />
                                <%# Eval("HomePhone") %></i>
                                <br />
                                <br />
                                <%# Eval("Notes") %>
                        </ItemTemplate>
                        <EditItemTemplate>
                            <b>
                                <%# Eval("EmployeeID") %> - 
                            <asp:DropDownList runat="server" ID="EditTitle"
                            SelectedIndex='<%# GetSelectedTitle(Eval("TitleOfCourtesy")) %>'
                            Font-Names="Verdana" Font-Size="XX-Small"
                            DataSource='<%# TitlesOfCourtesy %>' />
                            <%# Eval("TitleOfCourtesy") %> <%# Eval("FirstName") %>
                                <%# Eval("LastName") %>
                            </b>
                            <hr />
                            <small><i>
                                <%# Eval("Address") %><br />
                                <%# Eval("City") %>, <%# Eval("Country") %>,
                            <%# Eval("PostalCode") %><br />
                                <%# Eval("HomePhone") %></i>
                                <br />
                                <br />
                                <asp:TextBox Text='<%# Bind("Notes") %>' runat="server" ID="textBox"
                                    Font-Names="Verdana" Font-Size="XX-Small" Height="40px"
                                    TextMode="MultiLine" Width="413px" />
                        </EditItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <EditRowStyle BackColor="#7C6F57"></EditRowStyle>

                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></FooterStyle>

                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White"></HeaderStyle>

                <PagerStyle HorizontalAlign="Center" BackColor="#666666" ForeColor="White"></PagerStyle>

                <RowStyle BackColor="#E3EAEB"></RowStyle>

                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333"></SelectedRowStyle>

                <SortedAscendingCellStyle BackColor="#F8FAFA"></SortedAscendingCellStyle>

                <SortedAscendingHeaderStyle BackColor="#246B61"></SortedAscendingHeaderStyle>

                <SortedDescendingCellStyle BackColor="#D4DFE1"></SortedDescendingCellStyle>

                <SortedDescendingHeaderStyle BackColor="#15524A"></SortedDescendingHeaderStyle>
            </asp:GridView>
        
<asp:SqlDataSource ID="getEmployeesSDS" runat="server"
            ConnectionString="<%$ ConnectionStrings:NorthwndConnectionString %>"
            SelectCommand="SELECT * FROM Employees"
            UpdateCommand="UPDATE Employees SET Notes=@Notes, TitleOfCourtesy=@TitleOfCourtesy WHERE EmployeeID=@EmployeeID" />
        </div>
    </form>
</body>
</html>
