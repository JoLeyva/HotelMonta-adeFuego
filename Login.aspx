<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="waHotelMontaña.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous" />

<webopt:bundlereference runat="server" path="~/Content/css" />
    <title>Iniciar Sesión</title>
</head>
<body style="min-height: 100vh; padding:0px; background-image: url(imagen/fondologin.png); background-repeat: no-repeat; background-size:cover; background-position: center; background-attachment:fixed;">
<form id="form1" runat="server" autocomplete="off">

    <div class="container d-flex align-items-center" style="min-height:100vh;">

        <div class="container" style="background-color:#fff9e6; width:45%; padding:20px; border-radius:30px;">
            <div class="row">
                <img src="imagen/LogoMontfuego.png" class="img-fluid d-block mx-auto" alt="" style="width:80%;"/>
            </div>

            <div class="row mx-auto" style="width:50%; padding-top:20px;">
                <div class="mb-4">
                    <asp:Label ID="Label1" runat="server" Text="Usuario:" CssClass="form-label" style="font-size:20px; color:#22482E;"></asp:Label><br />
                    <asp:TextBox ID="txtNombreUsu" runat="server" CssClass="form-control" placeholder="Ingresar nombre de usuario"></asp:TextBox>
                </div>
                <div class="mb-4">
                    <asp:Label ID="Label2" runat="server" Text="Contraseña:" CssClass="form-label" style="font-size:20px; color:#22482E;"></asp:Label><br />
                    <asp:TextBox ID="txtContraUsu" runat="server" CssClass="form-control" TextMode="Password" placeholder="Ingresar contraseña"></asp:TextBox>
                </div>
                <div class="d-grid mx-auto">
                <asp:Button ID="btnIngresar" runat="server" Text="Ingresar" CssClass="btn" style="font-size:20px; background-color:#22482E; color:#ededed;" OnClick="btnIngresar_Click" /><br />
                <asp:Label ID="lblRespuesta" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </div>
</form>           
</body>
</html>
