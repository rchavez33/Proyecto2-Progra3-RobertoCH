<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="Proyecto2.Capa_Logica.Usuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Styles/StylesUsuariosBotones.css" rel="stylesheet" />
    <link href="../Styles/StylesInicio.css" rel="stylesheet" />
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Usuarios</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <ul>
      <li><a href="#home">Inicio</a></li>
      <li><a class="active" href="Usuarios.aspx">Usuarios</a></li>
      <li><a href="Productos.aspx">Productos</a></li>
      <li><a href="Empleados.aspx">Empleados</a></li>
    </ul>
</div>
        <div>
            <h2>Catalogo de Usuarios</h2>
        </div>
        <div>         
            <br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="183px" Width="317px">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />
            </asp:GridView>
            <br />
            <br />
            <label>ID</label>
            <br />
            <asp:TextBox ID="tid" runat="server"></asp:TextBox>
            <br />
            <label>Nombre</label>
            <br />
            <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
            <br />
            <label>Clave</label>
            <br />
            <asp:TextBox ID="tclave" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="bagregar" class="button button1" runat="server" Text="Agregar" OnClick="bagregar_Click" />
            <asp:Button ID="bborrar" class="button button2" runat="server" Text="Borrar" OnClick="bborrar_Click" />
            <asp:Button ID="bmodificar" class="button button3" runat="server" Text="Modificar" OnClick="bmodificar_Click" />
            <asp:Button ID="bconsultar" class="button button4" runat="server" Text="Consultar" OnClick="bconsultar_Click" />
            <br />
        </div>
    </form>
</body>
</html>
