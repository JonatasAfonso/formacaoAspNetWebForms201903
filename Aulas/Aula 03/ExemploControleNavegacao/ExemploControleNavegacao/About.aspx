<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ExemploControleNavegacao.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>


    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="lblContadorClicks" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    Nome carregado:
    <asp:Label ID="lblNomeCarregado" runat="server" Text="Label"></asp:Label>
    <br />
    Endereço carregado:
    <asp:Label ID="lblEnderecoCarregado" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
    <br />
    <br />
    <br />
    <a href="PaginaConsulta.aspx">PaginaConsulta.aspx</a>


</asp:Content>
