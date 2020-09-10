using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ECommerce.Service;

namespace ECommerce
{
    public partial class MisCompras : System.Web.UI.Page
    {
        Service.ServiceSoapClient ws = new ServiceSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteDTO cliente = (ClienteDTO)Session["cliente"];
            int idcliente= cliente.Id;
            DataSet ds = ws.verMisCompras(idcliente);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblerror.Visible = true;
            }
            else 
            {
                lblerror.Visible = false;
                gvCompras.DataSource = ds;
                gvCompras.DataBind();
            }
  
        }
    }
}