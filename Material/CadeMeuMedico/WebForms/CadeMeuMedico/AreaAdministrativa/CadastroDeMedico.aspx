<%@ Page Title="" Language="C#" MasterPageFile="~/AreaAdministrativa/MasterAdm.Master" AutoEventWireup="true" CodeBehind="CadastroDeMedico.aspx.cs" Inherits="CadeMeuMedico.AreaAdministrativa.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }

        .auto-style2 {
            height: 23px;
            width: 137px;
        }

        .auto-style3 {
            width: 137px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    


    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>

            <table style="width: 100%;">
        <tr>
            <td class="auto-style2"></td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td class="auto-style3">Nome do Médico</td>
            <td>
                <asp:TextBox ID="txtNomeMedico" runat="server" Width="367px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNomeMedico" ErrorMessage="Nome é obrigatorio"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">NIF</td>
            <td>
                <asp:TextBox ID="txtNif" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtNif" ErrorMessage="NIF Inválido" ValidationExpression="([0-9]{2}[\.]?[0-9]{3}[\.]?[0-9]{3}[\/]?[0-9]{4}[-]?[0-9]{2})|([0-9]{3}[\.]?[0-9]{3}[\.]?[0-9]{3}[-]?[0-9]{1})"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Cedula Profissional</td>
            <td>
                <asp:TextBox ID="txtCedula" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCedula" ErrorMessage="Documento obrigatorio"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Especialidade</td>
            <td>
                <asp:DropDownList ID="ddlEspecialidades" runat="server" Height="16px" OnSelectedIndexChanged="ddlEspecialidades_SelectedIndexChanged" Width="192px" AutoPostBack="True"></asp:DropDownList>
            </td>
        </tr>
    </table>


            <asp:Label ID="lblEspecialidade" runat="server" Text="Label"></asp:Label>
        </ContentTemplate>
    </asp:UpdatePanel>
    <br />
    <br />
    <br />


    <br />
    <br />


    <asp:Button ID="btnGravar" runat="server" Text="Gravar" OnClick="btnGravar_Click" />
    <br />
    <br />
    <br />
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
</asp:Content>
