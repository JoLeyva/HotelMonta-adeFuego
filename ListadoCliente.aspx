<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoCliente.aspx.cs" Inherits="waHotelMontaña.ListadoCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<webopt:bundlereference runat="server" path="~/Content/css" />

    
        <div class="container">
            <div class="container" style="background-color: black; color:white; padding:8px 0px 8px 0px">
                <h1 class="h1 text-center">Listado de clientes</h1>    
            </div>

                <asp:TextBox ID="txtConsulta" runat="server" CssClass="form-control"></asp:TextBox><br />
            <div>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" CssClass="btn btn-primary" />
                <asp:Button ID="btnRestablecer" runat="server" Text="Restablecer" OnClick="btnRestablecer_Click" CssClass="btn btn-danger" /><br />
            </div><br />
                
                <asp:GridView ID="gvTablaCliente" runat="server" class="table table-hover" style="background-color:#FFE799"  >
                   <Columns >
                        <asp:ButtonField ButtonType="Button" Text="Editar"   CommandName="Editar" ControlStyle-CssClass="btn btn-info btn-sm" />  
                        <asp:ButtonField ButtonType="Button" Text="Eliminar"   CommandName="Eliminar" ControlStyle-CssClass="btn btn-danger btn-sm"  />  
                    </Columns>
                 </asp:GridView><br /> 
        &nbsp;<a href="nuevoCliente.aspx" class="btn btn-success">Nuevo</a><br />
        </div>

</asp:Content>
