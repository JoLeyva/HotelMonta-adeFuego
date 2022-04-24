<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="waHotelMontaña.Vista.Tarjetas.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

        <div class="container">
        <h2 class="fw-bold">Editar Tarjeta</h2>
        <div class="mb-4">
            <asp:Label ID="Label1" runat="server" Text="Cliente:" CssClass="form-label"></asp:Label>
            <asp:DropDownList ID="cbCliente" runat="server" CssClass="form-control">
            </asp:DropDownList>
    
        </div>

        <div class="mb-4">
            <asp:Label ID="Label2" runat="server" Text="Nro Tarjeta:" CssClass="form-label"></asp:Label>
            <asp:TextBox TextMode="Number"  ID="txtNumeroTarjeta" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtNumeroTarjeta" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000">*Campo obligatorio</asp:RequiredFieldValidator>
        </div>

        <div class="mb-4">
            <asp:Label ID="Label3" runat="server" Text="Fecha Vencimiento:" CssClass="form-label"></asp:Label>
            <asp:TextBox TextMode="Date"  ID="txtFechaVenc" runat="server" CssClass="form-control"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtFechaVenc" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000">*Campo obligatorio</asp:RequiredFieldValidator>
        </div>

        <div class="mb-4">
            <asp:Label ID="Label4" runat="server" Text="Codigo Seguridad:" CssClass="form-label"></asp:Label>
            <asp:TextBox TextMode="Number" ID="txtCodigoSeguridad" runat="server" CssClass="form-control" MaxLength="3"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtCodigoSeguridad" ErrorMessage="RequiredFieldValidator" ForeColor="#CC0000">*Campo obligatorio</asp:RequiredFieldValidator>
       
         </div>


        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-success" OnClick="btnGuardar_Click"/><br />
        <asp:Label ID="lblReporte" runat="server" Text=""></asp:Label>
    </div>
</asp:Content>
