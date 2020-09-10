using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class MisDatos : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (this.Page.Session["cliente"] != null)
                {

                    ClienteDTO cliente = (ClienteDTO)this.Page.Session["cliente"];

                    var lista = ws.traerDatosUsuario(cliente.Id);


                    ClienteDTO clientedeseado = lista[0];

                    txtUsuario.Text = clientedeseado.Usuario;
                    lblId.Text = clientedeseado.Id.ToString();
                    txtNombre.Text = clientedeseado.Nombre;
                    txtDireccion.Text = clientedeseado.Direccion;
                    txtContraseña.Text = clientedeseado.Contraseña;
                    txtTelefono.Text = clientedeseado.Telefono;
                    txtEmail.Text = clientedeseado.Email;
                
                }

            }

        }

        protected void btActualizar_Click(object sender, EventArgs e)
        {
            ClienteDTO actualizacioncliente = new ClienteDTO();

            actualizacioncliente.Id = Int32.Parse(lblId.Text);
            actualizacioncliente.Nombre = txtNombre.Text;
            actualizacioncliente.Direccion = txtDireccion.Text;
            actualizacioncliente.Telefono = txtTelefono.Text;
            actualizacioncliente.Email = txtEmail.Text;
            actualizacioncliente.Usuario = txtUsuario.Text;
            actualizacioncliente.Contraseña = txtContraseña.Text;

            ws.actualizarCliente(actualizacioncliente);
            Session.Remove("cliente");
            Session.Add("cliente", actualizacioncliente);
            Response.Redirect("Homepage.aspx");
        }
    }
}