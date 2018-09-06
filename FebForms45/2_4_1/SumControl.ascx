<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SumControl.ascx.cs" Inherits="ErrorHandling.SumControl" %>

<div class="panel">
    <label>1е число:</label>
    <input name="first" value="10"/>
</div>
<div class="panel">
    <label>2е число:</label>
    <input name="second" value="31"/>
</div>
<asp:PlaceHolder ID="resultPlaceholder" runat="server" Visible="false">
    <div class="panel">
        Сумма чисел: <span id="result" runat="server"></span>
    </div>
</asp:PlaceHolder>
