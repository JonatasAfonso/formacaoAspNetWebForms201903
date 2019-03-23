<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CadeMeuMedico.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Cade meu médico</h1>

            <hr />
            <asp:SiteMapPath ID="SiteMapPath1" runat="server"></asp:SiteMapPath>
            <hr />

            <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
            </asp:Menu>
            <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />

        </div>
    </form>

    <hr />
    WebSiteDeveloperCompany 2019

</body>
</html>
