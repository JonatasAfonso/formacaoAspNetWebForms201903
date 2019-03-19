<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="Aula01Exemplo01.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.
        
        </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>
        <asp:TextBox ID="txtNome" runat="server" Width="541px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnEnviar" runat="server" Text="Button" OnClick="Button1_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>

    <hr>
    <p>Meu conteudo</p>
</asp:Content>
