<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="ECommerce.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
    <link href="Resources/StyleSheet1.css" rel="stylesheet" />
</head>
<body style='background-image:url("Img/fondo.jpg")'>
    <div class = "container well contenedor">
        <div class="row">
            <div class="col-xs-12">
                <h2>Registro</h2>
            </div>
        </div>
        <form runat="server" class="form-horizontal">
            <div class="form-group">
                <asp:Label ID="lblNombre" runat="server" Text="Nombre:" CssClass="control-label col-sm-2"></asp:Label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txNombre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            
            <div class="form-group">
                <asp:Label ID="lblDireccion" runat="server" Text="Direccion:" CssClass="control-label col-sm-2"></asp:Label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txDireccion" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

             <div class="form-group">
                <asp:Label ID="Telefono" runat="server" Text="Telefono:" CssClass="control-label col-sm-2"></asp:Label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txTelefono" runat="server" CssClass="form-control" MaxLength="11" TextMode="Number"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblEmail" runat="server" Text="Email:" CssClass="control-label col-sm-2"></asp:Label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblUsuario" runat="server" Text="Usuario:" CssClass="control-label col-sm-2"></asp:Label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txUsuario" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

            <div class="form-group">
                <asp:Label ID="lblContrasena" runat="server" Text="Contraseña:" CssClass="control-label col-sm-2"></asp:Label>
            </div>
            <div class="col-sm-10">
                <asp:TextBox ID="txContrasena" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
            <br />

            <div class="form-group">
                <asp:Button ID="btRegistrar" runat="server" Text="Registrarse" cssclass="form-control btn btn-primary" OnClick="btRegistrar_Click"/>
            </div>



            </form>
            </div>
    </body>
</html>