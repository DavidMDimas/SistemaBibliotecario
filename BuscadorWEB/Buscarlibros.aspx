<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Buscarlibros.aspx.cs" Inherits="BuscadorWEB.Buscarlibros" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="dataListado" runat="server" OnSelectedIndexChanged="dataListado_SelectedIndexChanged">
        </asp:GridView>
    </form>
</body>
</html>
