using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ECommerce.Service;

namespace ECommerce
{
    public partial class Registro : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btRegistrar_Click(object sender, EventArgs e)
        {
                ws.Registro(txNombre.Text, txDireccion.Text, txTelefono.Text, txEmail.Text, txUsuario.Text, txContrasena.Text);
                Response.Redirect("MisDatos.aspx");
        }
    }
}