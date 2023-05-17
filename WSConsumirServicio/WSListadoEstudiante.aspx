<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WSListadoEstudiante.aspx.cs" Inherits="WSConsumirServicio.WSListadoEstudiante" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Listado de Estudiantes
                Udc
                <asp:TextBox ID="TextBox1" runat="server" Width="383px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Buscar" />
            </h1>
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
