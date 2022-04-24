<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="nuevoCliente.aspx.cs" Inherits="waHotelMontaña.nuevoCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <h2 class="fw-bold">Nuevo Cliente</h2>
        <div class="mb-4">
            <asp:Label ID="Label1" runat="server" Text="Nombres:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtNombreCli" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtNombreCli" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000">*Campo obligatorio</asp:RequiredFieldValidator>
        </div>

        <div class="mb-4">
            <asp:Label ID="Label2" runat="server" Text="Apellidos:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtApellidoCli" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtApellidoCli" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000">*Campo obligatorio</asp:RequiredFieldValidator>
        </div>

        <div class="mb-4">
            <asp:Label ID="Label3" runat="server" Text="Telefono:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtTelefonoCli" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtTelefonoCli" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000">*Campo obligatorio</asp:RequiredFieldValidator>
        </div>

        <div class="mb-4">
            <asp:Label ID="Label4" runat="server" Text="E-mail:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtCorreoCli" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtCorreoCli" ErrorMessage="RegularExpressionValidator" ForeColor="#0099FF" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">Ingrese el formato de e-mail</asp:RegularExpressionValidator>
        </div>


        <div class="mb-4">
            <asp:Label ID="Label5" runat="server" Text="DNI:" CssClass="form-label"></asp:Label>
            <asp:TextBox ID="txtDniCli" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtDniCli" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000">*Campo obligatorio</asp:RequiredFieldValidator>
        </div>
        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click" /><br />
        <asp:Label ID="lblReporte" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
