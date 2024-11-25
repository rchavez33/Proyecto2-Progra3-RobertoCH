<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="Proyecto2.Capa_Vistas.Empleados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/StylesInicio.css" rel="stylesheet" />
    <link href="../Styles/StylesUsuariosBotones.css" rel="stylesheet" />
    <title>Empleados</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
    <ul>
      <li><a href="#home">Inicio</a></li>
      <li><a href="Usuarios.aspx">Usuarios</a></li>
      <li><a href="Productos.aspx">Productos</a></li>
      <li><a class="active" href="Empleados.aspx">Empleados</a></li>
    </ul>
</div>
        <div>


            <br />
            <br />
            
            <asp:GridView ID="GridView1" runat="server" Height="161px" Width="286px" CellPadding="4" ForeColor="#333333" GridLines="None">
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
            <label>ID</label>
            <br />
            <asp:TextBox ID="tid" runat="server"></asp:TextBox>
            <br />
            <label>Nombre</label>
            <br />
            <asp:TextBox ID="tnombre" runat="server"></asp:TextBox>
            <br />
            <label>Apellido Paterno</label>
            <br />
            <asp:TextBox ID="tapellidop" runat="server"></asp:TextBox>
            <br />
            <label>Apellido Materno</label>
            <br />
            <asp:TextBox ID="tapellidom" runat="server"></asp:TextBox>
            <br />
            <label>Correo</label>
            <br />
            <asp:TextBox ID="tcorreo" runat="server"></asp:TextBox>
            <br />
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
