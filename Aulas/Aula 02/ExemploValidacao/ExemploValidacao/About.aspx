<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ExemploValidacao.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>&nbsp;</p>
    <p>Nome</p>
    <p>
        <asp:TextBox ID="txtNome" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNome" ErrorMessage="Nome é obrigatorio" Display="None"></asp:RequiredFieldValidator>
    </p>
    <p>
        &nbsp;</p>
    <p>
        Idade</p>
    <p>
        <asp:TextBox ID="txtIdade" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtIdade" Display="None" ErrorMessage="Muito velho" MaximumValue="99" MinimumValue="2"></asp:RangeValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtIdade" Display="None" ErrorMessage="Idade é obrigatoria"></asp:RequiredFieldValidator>
    </p>
    <p>&nbsp;</p>
    <p>Email</p>
    <p>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="Email incorreto" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
    </p>
    <p>Confirmacao Email</p>
    <p>
        <asp:TextBox ID="txtConfirmacao" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtEmail" ControlToValidate="txtConfirmacao" CssClass="alert" ErrorMessage="Emails diferentes"></asp:CompareValidator>
    </p>
    <p>&nbsp;</p>
    <p>Telefone</p>
    <p>
        <asp:TextBox ID="txtTelefoneTeste" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtTelefoneTeste" ErrorMessage="Telefone invalido" OnServerValidate="CustomValidator1_ServerValidate" Display="Dynamic"></asp:CustomValidator>
    </p>
    <p>&nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    </p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
    <p>
        &nbsp;</p>
    <p>&nbsp;</p>
</asp:Content>
