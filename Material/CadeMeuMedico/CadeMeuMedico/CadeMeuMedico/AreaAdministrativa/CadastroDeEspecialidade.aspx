<%@ Page Title="" Language="C#" MasterPageFile="~/AreaAdministrativa/MasterAdm.Master" AutoEventWireup="true" CodeBehind="CadastroDeEspecialidade.aspx.cs" Inherits="CadeMeuMedico.AreaAdministrativa.WebForm2" %><%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    .auto-style2 {
        width: 100%;
    }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table class="auto-style2">
            <tr>
                <td class="auto-style1">Nome:</td>
                <td class="auto-style1">
        <asp:TextBox ID="txtNome" runat="server" Width="294px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Descrição:</td>
                <td>
                    <asp:TextBox ID="txtDescricao" runat="server" Height="374px" Width="429px"></asp:TextBox>
                    <ajaxToolkit:HtmlEditorExtender ID="txtDescricao_HtmlEditorExtender" runat="server" BehaviorID="TextBox1_HtmlEditorExtender" TargetControlID="txtDescricao">
                    </ajaxToolkit:HtmlEditorExtender>
                </td>
            </tr>
        </table>
    </p>
    <p>
        <asp:Button ID="btnGravar" runat="server" OnClick="btnGravar_Click" Text="Gravar" />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
</p>
</asp:Content>
