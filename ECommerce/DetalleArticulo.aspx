<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetalleArticulo.aspx.cs" Inherits="ECommerce.DetalleArticulo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
                <br />
            <div class="row">
                <div class="col-md-4">
                </div>
                <div class="col-md-4 text-center">
                        <asp:Label ID="Label1" runat="server" Text="Nombre del producto:"></asp:Label>
    <asp:Label ID="lblProducto" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Descripcion del producto:"></asp:Label>
    <asp:Label ID="lblDescripcion" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Precio Venta:"></asp:Label>
    <asp:Label ID="lblPrecioVenta" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label7" runat="server" Text="Precio Compra:"></asp:Label>
    <asp:Label ID="lblPrecioCompra" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Stock:"></asp:Label>
    <asp:Label ID="lblStock" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
                    <br />
                    <br />
                </div>
                <div class="col-md-4">
                </div>
            </div>
           <div class="album py-3 bg-transparent">
        <div class="container">
            <div class="row" runat="server" id="dvArticulos">
            </div>
        </div>
    </div>
    <br />

</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">


</asp:Content>
