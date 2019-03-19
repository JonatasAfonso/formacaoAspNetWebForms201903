<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEbAppExemplo02.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Meu medico
        </div>


    <a href="Medicos.aspx">Medicos.aspx</a>

        <%
                Button1.Text = "meu codigo funciona";
        %>

        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" Text="Button" />


    
    </form>


    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
