<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="ExemploAjax.About" %>



<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>



<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <p>&nbsp;</p>
    <p></p>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:TextBox ID="TextBox1" runat="server" Width="269px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <br />
        </ContentTemplate>
    </asp:UpdatePanel>


  



    <p>&nbsp;</p>
    <p></p>
    <br />
<asp:TextBox ID="TextBox2" runat="server" Height="400px" Width="600px"></asp:TextBox>
<ajaxToolkit:HtmlEditorExtender ID="TextBox2_HtmlEditorExtender" runat="server" BehaviorID="TextBox2_HtmlEditorExtender" TargetControlID="TextBox2">
</ajaxToolkit:HtmlEditorExtender>
<br />
<br />
    <br />
    <br />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    <br />


</asp:Content>



