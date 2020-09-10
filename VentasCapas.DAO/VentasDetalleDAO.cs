using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VentasCapas.DTO;

namespace VentasCapas.DAO
{
    public class VentasDetalleDAO
    {
            public static void Create(List<ArticuloDTO> articulos)
            {
                int idventascabecera = (DAOHelper.GetNextId("VentasCabecera")-1);


                using (SqlConnection con = new SqlConnection(DAOHelper.connectionString))
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    foreach (var dto in articulos)
                    {
                        int id = (DAOHelper.GetNextId("VentasDetalle"));
                        string sqlNuevaVentaDetalle = "insert into VentasDetalle (id, idventacabecera,idarticulo,preciounitario,cantidad) values(" + id + " ," + idventascabecera + " ," + dto.Id + " ," + dto.PrecioVenta.ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + 1 +")";

                        using (SqlCommand cmd = new SqlCommand(sqlNuevaVentaDetalle, con))
                        {
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                    }

                }
            }
        }
}
