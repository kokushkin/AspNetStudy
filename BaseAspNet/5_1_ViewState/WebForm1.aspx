<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_5_1_ViewState.WebForm1"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
<form id="form1" runat="server">    
<div>
   <table>
      <tr>
         <td>Имя:</td>
         <td><asp:TextBox runat="server" Width="200px" ID="Name" EnableViewState="false"/></td>
      </tr>
      <tr>
         <td>ID:</td>
         <td><asp:TextBox runat="server" Width="200px" ID="EmpID" EnableViewState="false"/></td>
      </tr>
      <tr>
         <td>Возраст:</td>
         <td><asp:TextBox runat="server" Width="200px" ID="Age" EnableViewState="false"/></td>
      </tr>
      <tr>
         <td>E-mail:</td>
         <td><asp:TextBox runat="server" Width="200px" ID="Email" EnableViewState="false"/></td>
      </tr>
      <tr>
         <td>Пароль:</td>
         <td><asp:TextBox TextMode="Password" runat="server" Width="200px" ID="Password" /></td>
      </tr>
   </table>
   <br /><asp:Button runat="server" Text="Save" ID="cmdSave" OnClick="cmdSave_Click" />
    <asp:Button ID="cmdRestore" runat="server" Text="Restore" OnClick="cmdRestore_Click"></asp:Button><br />
</div></form>
</body>
</html>
