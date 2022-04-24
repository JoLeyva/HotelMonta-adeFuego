<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoTarjeta.aspx.cs" Inherits="waHotelMontaña.ListadoTarjeta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">


    <div class="container">
            <div class="container" style="background-color: black; color:white; padding:8px 0px 8px 0px">
                <h1 class="h1 text-center">Listado de tarjetas</h1>    
            </div><br />
        <asp:TextBox ID="txtConsulta" runat="server" CssClass="form-control"></asp:TextBox><br />
            <div>
                <asp:Button ID="btnConsultar" runat="server" Text="Consultar" OnClick="btnConsultar_Click" CssClass="btn btn-primary" />
                <asp:Button ID="btnRestablecer" runat="server" Text="Restablecer" OnClick="btnRestablecer_Click" CssClass="btn btn-danger" /><br />
            </div><br />

            <br />
              

                <asp:GridView ID="gvTablaTarjeta" runat="server" class="table table-hover" style="background-color:#FFE799 ;"  OnSelectedIndexChanging="gvTablaTarjeta_SelectedIndexChanging" OnRowCommand="gvTablaTarjeta_RowCommand"  >
                    <Columns >
                        <asp:ButtonField ButtonType="Button" Text="Editar"   CommandName="Editar" ControlStyle-CssClass="btn btn-info btn-sm" />  
                        <asp:ButtonField ButtonType="Button" Text="Eliminar"   CommandName="Eliminar" ControlStyle-CssClass="btn btn-danger btn-sm"  />  
                    </Columns>
                 </asp:GridView><br /> 
        &nbsp;<a href="Vista/Tarjetas/Nuevo.aspx" class="btn btn-success">Nuevo</a><br />
        </div>
</asp:Content>

