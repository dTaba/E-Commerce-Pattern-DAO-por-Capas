<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisDatos.aspx.cs" Inherits="ECommerce.MisDatos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <link href="Resources/StyleSheet1.css" rel="stylesheet" />
    <div class="container">

        <br />
        <div class="row">
            <div class="col-md-12 text-center">
                <asp:Label ID="Label1" runat="server" Text="Mis Datos" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Numero de cliente" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <asp:Label ID="lblId" runat="server" Text="" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Nombre" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control"></asp:TextBox>
                 <br />
                <asp:Label ID="Label4" runat="server" Text="Direccion" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                 <br />
                <asp:Label ID="Label5" runat="server" Text="Telefono" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                 <br />
                <asp:Label ID="Label6" runat="server" Text="Email" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                 <br />
                <asp:Label ID="Label7" runat="server" Text="Usuario" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control"></asp:TextBox>
                 <br />
                <asp:Label ID="Label8" runat="server" Text="Contraseña" CssClass="control-label col-sm-2"></asp:Label>
                <br />
                <asp:TextBox ID="txtContraseña" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="btActualizar" runat="server" Text="Actualizar Datos" cssclass="form-control btn btn-primary" OnClick="btActualizar_Click"/>

            </div>
        </div>
    </div>
</asp:Content>