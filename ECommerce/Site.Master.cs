using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //--
            if (this.Page.Session["cliente"] == null)
                Response.Redirect("~/Login.aspx");

            ClienteDTO cliente = (ClienteDTO)this.Page.Session["cliente"];
            lbUser.Text = "Cliente: " + cliente.Usuario;
        }

        protected void btCarrito_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("Carrito.aspx");
        }
    }
}