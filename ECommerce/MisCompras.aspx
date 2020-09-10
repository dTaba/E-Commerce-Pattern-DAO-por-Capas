<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisCompras.aspx.cs" Inherits="ECommerce.MisCompras" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:GridView ID="gvCompras" runat="server"></asp:GridView>
    <asp:Label ID="lblerror" runat="server" Text="Aun no ha realizado compras" Visible="False"></asp:Label>
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="scripts" runat="server">
</asp:Content>

