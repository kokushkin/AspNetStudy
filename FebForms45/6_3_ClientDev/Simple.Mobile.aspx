<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Simple.Mobile.aspx.cs" 
    Inherits="ClientDev.Simple_Mobile" MasterPageFile="~/Site.Mobile.Master" %>

<asp:Content ContentPlaceHolderID="ContentPlaceHolder1" ID="Content1" runat="server">
    <div>
        <span class="message">Это страница Simple.Mobile.aspx</span>
    </div>
    <div>Это <%= Request.Browser.IsMobileDevice ? "" : "не" %> мобильное устройство</div>
    <div>
        <button>Кнопка 1</button>
        <button>Кнопка 2</button>
    </div>
</asp:Content>
