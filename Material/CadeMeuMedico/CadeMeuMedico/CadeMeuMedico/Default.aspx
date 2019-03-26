<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CadeMeuMedico.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Menu ID="Menu1" runat="server" DataSourceID="SiteMapDataSource1">
            </asp:Menu>
 <%--  --%>
            <h1>Cade meu médico</h1>
        </div>
    </form>

    <hr />
    WebSiteDeveloperCompany 2019
     <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />

</body>
</html>
