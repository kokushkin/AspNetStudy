<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Summary.aspx.cs" 
    Inherits="TestAspNet45.Pages.Summary" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link rel="stylesheet" href="/Content/Styles.css" />
</head>
<body>
    <h2>Приглашения</h2>

    <h3>Люди которые были приглашены: </h3>
    <table>
        <thead>
            <tr>
                <th>Имя</th>
                <th>Email</th>
                <th>Телефон</th>
            </tr>
        </thead>
        <tbody><%= GetResponses(true) %></tbody>
    </table>
    <h3>Люди которые не придут: </h3>
    <table>
        <thead>
            <tr>
                <th>Имя</th>
                <th>Email</th>
                <th>Телефон</th>
            </tr>
        </thead>
        <tbody><%= GetResponses(false) %></tbody>
    </table>
</body>
</html>