﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_5_2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server">    
        <title>CrossPage1</title>
    </head>
    <body>    
        <form id="form1" runat="server">        
            <div>            
                Введите данные:            
                <asp:TextBox runat="server" ID="txtFirstName"></asp:TextBox>              
                <asp:TextBox runat="server" ID="txtLastName"></asp:TextBox>            
                <asp:Button runat="server" ID="cmdSubmit" PostBackUrl="WebForm2.aspx" Text="Отправить" />
            </div>    
        </form>
    </body>
</html>
