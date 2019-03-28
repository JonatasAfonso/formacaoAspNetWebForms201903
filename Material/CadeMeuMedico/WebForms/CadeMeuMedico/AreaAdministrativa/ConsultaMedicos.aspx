<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConsultaMedicos.aspx.cs" Inherits="CadeMeuMedico.AreaAdministrativa.ConsultaMedicos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Buscar medico por nome<br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <hr />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
    </form>
</body>
</html>
