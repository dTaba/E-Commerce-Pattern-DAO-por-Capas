using ECommerce.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace ECommerce
{
    public partial class Carrito : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Session["carrito"] != null)
            {
                gvArticulosSeleccionados.Visible = true;
                gvArticulosSeleccionados.DataSource = ((List<ArticuloDTO>)Session["carrito"]);
                gvArticulosSeleccionados.DataBind();
                btVaciarCarrito.Visible = true;
                
            }
            else
            {
                gvArticulosSeleccionados.Visible = false;
                lblError.Text = "No hay nada agregado en el carrito ";
                btComprar.Visible = false;
            }
        }

        protected void btVaciarCarrito_Click(object sender, EventArgs e)
        {
            Session.Remove("carrito");
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
            //lblError.Text = "No hay nada agregado en el carrito ";
        }

        protected void gvArticulosSeleccionados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            List<ArticuloDTO> listaarticulos = ((List<ArticuloDTO>)Session["carrito"]);
            int indice = Convert.ToInt32(e.CommandArgument);

            listaarticulos.RemoveAt(indice);
            Session.Remove("carrito");
            Session.Add("carrito", listaarticulos);
            int cantidaddearticulos = listaarticulos.Count();
            if (cantidaddearticulos == 0)
            {
                this.Session["carrito"] = null;
            }
            Page.Response.Redirect(Page.Request.Url.ToString(), true);
                
        }

        protected void btComprar_Click(object sender, EventArgs e)
        {
            ClienteDTO cliente = new ClienteDTO();
            cliente = ((ClienteDTO)Session["cliente"]);
            int clienteid = cliente.Id;
            //var lista = Session["carrito"] as List<ArticuloDTO>;
            List<ArticuloDTO> lista = ((List<ArticuloDTO>)Session["carrito"]);

            foreach (var dto in lista)
            {
                ws.actualizarStock(dto);
            }

            ws.nuevaVenta(clienteid, lista.ToArray());

            Response.Redirect("MisCompras.aspx");
        }

    }
}