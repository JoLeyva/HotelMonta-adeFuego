<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="waHotelMontaña._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Software Hotel Montaña de Fuego</h1>
        <p>
            <asp:Label ID="lblUsuario" runat="server" Text=""></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnCerrarSesion" runat="server" CssClass="btn btn-danger" Text="Cerrar Sesion" OnClick="btnCerrarSesion_Click" />
        </p>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Listado de Clientes</h2>
            <p>
                Información sobre todos los clientes que han sido ingresados al sistema.
            </p>
            <p>
                <a class="btn btn-primary" href="ListadoCliente">Ir a Listado Clientes &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Listado de Tarjetas</h2>
            <p>
                Información sobre las tarjetas usadas por nuestros clientes.
            </p>
            <p>
                <a class="btn btn-primary" href="ListadoTarjeta">Ir a Listado Tarjeta &raquo;</a>
            </p>
        </div>
    </div>

</asp:Content>
