<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="ECommerce.Carrito" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvArticulosSeleccionados" runat="server" OnRowCommand="gvArticulosSeleccionados_RowCommand">
        <Columns>
            <asp:ButtonField Text="Sacar del carrito" />
        </Columns>
    </asp:GridView>
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    <asp:Button ID="btVaciarCarrito" runat="server" Text="Vaciar carrito" Visible="False" OnClick="btVaciarCarrito_Click" />
    <asp:Button ID="btComprar" runat="server" Text="Confirmar Compra" OnClick="btComprar_Click" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>
