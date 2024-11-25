<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Proyecto2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="../Styles/StylesLogin.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>

    <div class="container">

        <div class="screen">

            <div class="screen__content">

                <form id="form1" runat="server" class="login">

                    <div class="login__field">

                        <i class="login__icon fas fa-user"></i>
                        <asp:TextBox ID="tusuario" class="login__input" placeholder="Usuario" required="required" runat="server"></asp:TextBox>
                        
                    </div>

                    <br />

                    <div class="login__field">
                        <i class="login__icon fas fa-lock"></i>
                        
                        <asp:TextBox ID="tclave" runat="server" TextMode="Password" class="login__input" placeholder="Contraseña" required="required"></asp:TextBox>                      
                    </div>

                    <br />

                    <i class="button__icon fas fa-chevron-right"></i>
                    <asp:Button ID="bingresar" class="button login__submit" runat="server" Text="Ingresar" OnClick="bingresar_Click" />

                    <br />

                    <asp:Label ID="lmensaje" runat="server" Text="" Font-Size="X-Large" ForeColor="Blue"></asp:Label>

                    <br />

                </form>

            </div>

                <div class="screen__background">
                    <span class="screen__background__shape screen__background__shape4"></span>
                    <span class="screen__background__shape screen__background__shape3"></span>
                    <span class="screen__background__shape screen__background__shape2"></span>
                    <span class="screen__background__shape screen__background__shape1"></span>
                </div>

        </div>

    </div>



</body>
</html>
