<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_2_1_1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head> 
        <title>Опрос</title> 
    </head> 
    <body> 
        <form method="post" action="WebForm1.aspx"> 
            <div> 
                Введите ваше имя:  
                <input type="text" name="FirstName" /><br /> 
                Введите фамилию:  
                <input type="text" name="LastName" />
                <br /><br />
                На чем программируете:
                <br />   
                <input type="checkbox" name="CS" />C#
                <br />    
                <input type="checkbox" name="VB" />VB .NET 
                <br /><br /> 
                <input type="submit" value="Отправить" id="OK" /> 
            </div> 
        </form> 
    </body> 
</html>
