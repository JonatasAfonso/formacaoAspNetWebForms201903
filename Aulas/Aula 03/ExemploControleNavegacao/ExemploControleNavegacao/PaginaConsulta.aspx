<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaginaConsulta.aspx.cs" Inherits="ExemploControleNavegacao.PaginaConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            &nbsp;</p>
        <p>
            Nome:
            <asp:TextBox ID="txtNome" runat="server" Width="423px"></asp:TextBox>
        </p>
        <p>
            Endereço:
            <asp:TextBox ID="txtEndereco" runat="server" Width="397px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnBuscaQueryString" runat="server" OnClick="btnBuscaQueryString_Click" Text="Buscar por query string" />
        </p>
    </form>
</body>
</html>
