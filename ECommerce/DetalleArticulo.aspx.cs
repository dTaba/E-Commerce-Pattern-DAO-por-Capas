using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ECommerce.Service;
using System.Web.UI.HtmlControls;


namespace ECommerce
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

            var div = new HtmlGenericControl("div");
            div.Attributes.Add("class", "col-md-4");


            var divCard = new HtmlGenericControl("div");
            divCard.Attributes.Add("class", "card mb-4 box-shadow");
            int articuloid = (int)Session["idarticulo"];
            
            var divBody = new HtmlGenericControl("div");
            divBody.Attributes.Add("class", "card-body");
            var bt = new ImageButton();
            bt.CssClass = "img-fluid";
            string path = Server.MapPath("~/Articulos/");
            if (System.IO.File.Exists(path + "/id" + articuloid + ".png"))
            {
                bt.ImageUrl = "../Articulos/id" + articuloid + ".png";

            }
            else
            {
                bt.ImageUrl = "../Articulos/nophoto.png";
            }
            divBody.Controls.Add(bt);
            divCard.Controls.Add(divBody);
            div.Controls.Add(divCard);

            dvArticulos.Controls.Add(div);

            ArticuloDTO articuloseleccionado = ws.getArticuloDTO(articuloid);

            lblProducto.Text = articuloseleccionado.Nombre;
            lblDescripcion.Text = articuloseleccionado.Descripcion;
            lblPrecioCompra.Text = articuloseleccionado.PrecioCompra.ToString();
            lblPrecioVenta.Text = articuloseleccionado.PrecioVenta.ToString();
            lblStock.Text = articuloseleccionado.Stock.ToString();
        }
    }
}