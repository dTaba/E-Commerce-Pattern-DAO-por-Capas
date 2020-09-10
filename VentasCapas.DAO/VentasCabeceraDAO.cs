using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VentasCapas.DTO;

namespace VentasCapas.DAO
{
    public class VentasCabeceraDAO
    {
        public static void Create(int idclientes)
        {
            int id = DAOHelper.GetNextId("VentasCabecera");
            string sqlNuevaVentaCabecera = "insert into VentasCabecera values(" + id + " ,'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "' ," + idclientes + ", " + "1" + " ,'ninguna')"; 
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DAOHelper.connectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlNuevaVentaCabecera, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static DataSet verMisCompras(int idcliente)
        {

            try
            {

                string SQL_DataGrilla = "SELECT Fecha,Observaciones,IdArticulo,PrecioUnitario,Cantidad FROM VentasCabecera inner join VentasDetalle on VentasCabecera.Id=VentasDetalle.IdVentaCabecera where IdCliente= " + idcliente;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = DAOHelper.connectionString;
                con.Open();
                SqlDataAdapter dataAdapt = new SqlDataAdapter(SQL_DataGrilla, con);

                DataSet dataset = new DataSet();
                dataAdapt.Fill(dataset);

                return dataset;


            }
            catch (SqlException ex)
            {
                throw;
            }


        }

    }
}
