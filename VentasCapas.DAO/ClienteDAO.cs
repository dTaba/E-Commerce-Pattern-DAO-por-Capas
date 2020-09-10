using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using VentasCapas.DTO;

namespace VentasCapas.DAO
{
    public class ClienteDAO
    {
        public static List<ClienteDTO> ReadAll(string where)
        {
            DataTable dt = new DataTable();

            //Leo los registros de la DB.
            using (SqlDataAdapter da = new SqlDataAdapter(
                "SELECT * FROM Clientes " + where,
                DAOHelper.connectionString))
            {
                da.Fill(dt);
            }

            ClienteDTO dto;
            List<ClienteDTO> lista = new List<ClienteDTO>();

            //Itero entre los registros para armar la Lista de DTO.
            foreach (DataRow dr in dt.Rows)
            {
                dto = new ClienteDTO();

                if (!dr.IsNull("Id")) dto.Id = (int)dr["Id"];
                if (!dr.IsNull("Nombre")) dto.Nombre = (string)dr["Nombre"];
                if (!dr.IsNull("Direccion")) dto.Direccion = (string)dr["Direccion"];
                if (!dr.IsNull("Telefono")) dto.Telefono = (string)dr["Telefono"];
                if (!dr.IsNull("Email")) dto.Email = (string)dr["Email"];
                if (!dr.IsNull("Usuario")) dto.Usuario = (string)dr["Usuario"];
                if (!dr.IsNull("Contraseña")) dto.Contraseña = (string)dr["Contraseña"];

                lista.Add(dto);
            }
            return lista;
        }
        public void Create(ClienteDTO cliente)
        {
            int id = DAOHelper.GetNextId("Clientes");
            string sqlNuevoUsuario = "insert into Clientes values(" + id + " ,'" + cliente.Nombre + "' ," + " '" + cliente.Direccion + "' " + " ,'" + cliente.Telefono + "' " + " ,'" + cliente.Email + "' ," + " '" + cliente.Usuario + "' ," + " '" + cliente.Contraseña + "' " + ")";
            
            SqlConnection con = new SqlConnection();
            con.ConnectionString = DAOHelper.connectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlNuevoUsuario, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void Update(ClienteDTO cliente)
        {
            string sqlUpdate = "update Clientes set Nombre=" + "'" + cliente.Nombre + "', Direccion=" + "'" + cliente.Direccion + "', Telefono=" + "'" + cliente.Telefono + "', email=" + "'" + cliente.Email + "', usuario=" + "'" + cliente.Usuario + "', Contraseña=" + "'" + cliente.Contraseña + "'" + " where id=" + cliente.Id + " ";

            SqlConnection con = new SqlConnection();
            con.ConnectionString = DAOHelper.connectionString;
            con.Open();
            SqlCommand cmd = new SqlCommand(sqlUpdate, con);
            cmd.ExecuteNonQuery();
            con.Close();    
  
        }
            
    }
}
