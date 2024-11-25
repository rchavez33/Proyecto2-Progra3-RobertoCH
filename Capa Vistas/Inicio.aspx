<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Proyecto2.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Styles/StylesInicio.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <ul>
              <li><a class="active" href="#home">Inicio</a></li>
              <li><a href="Usuarios.aspx">Usuarios</a></li>
              <li><a href="Productos.aspx">Productos</a></li>
              <li><a href="Empleados.aspx">Empleados</a></li>
            </ul>
        </div>
        <br />
        <div>
            <h2>
                <asp:Label ID="lmensaje" runat="server" Text="Label"></asp:Label>
            </h2>
        </div>
    </form>
</body>
</html>
