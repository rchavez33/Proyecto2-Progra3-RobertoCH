<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Productos.aspx.cs" Inherits="Proyecto2.Capa_Vistas.Productos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="../Styles/StylesInicio.css" rel="stylesheet" />
    <link href="../Styles/StylesUsuariosBotones.css" rel="stylesheet" />
    <title>Productos</title>
</head>
<body>
    <form id="form1" runat="server">
                <div>
                    <ul>
                      <li><a href="#home">Inicio</a></li>
                      <li><a href="Usuarios.aspx">Usuarios</a></li>
                      <li><a class="active" href="Productos.aspx">Productos</a></li>
                      <li><a href="Empleados.aspx">Empleados</a></li>
                    </ul>
                </div>
        <div>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="212px" Width="286px">
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
            <label>Codigo</label>
            <br />
            <asp:TextBox ID="tcodigo" runat="server"></asp:TextBox>
            <br />
            <label>Producto</label>
            <br />
            <asp:TextBox ID="tproducto" runat="server"></asp:TextBox>
            <br />
            <label>Precio</label>
            <br />
            <asp:TextBox ID="tprecio" runat="server"></asp:TextBox>
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
