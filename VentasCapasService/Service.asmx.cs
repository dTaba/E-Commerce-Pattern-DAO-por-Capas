using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using VentasCapas.DAO;
using VentasCapas.DTO;
using System.Data;
using System.Data.SqlClient;

namespace VentasCapasService
{
    /// <summary>
    /// Summary description for Service
    /// </summary>
    [WebService(Namespace = "http://ventasservice.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    [System.Web.Script.Services.ScriptService]
    public class Service : System.Web.Services.WebService
    {
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<ArticuloDTO> GetArticulos(string filtro)
        {
            var articulos = VentasCapas.DAO.ArticuloDAO.ReadAll("where nombre like " + "'%" + filtro + "%'");
                if (filtro !="")
                
                    if (articulos.Count > 0)
                        return articulos;
                    else
                        return null;
                else
                    return ArticuloDAO.ReadAll("");
        }

        [WebMethod]
        public ClienteDTO Login(string usuario, string contraseña)
        {
           var cliente = VentasCapas.DAO.ClienteDAO.ReadAll("where usuario =" + "'" + usuario + "'" + "and " + "contraseña =" + "'" + contraseña + "'");
           if (cliente.Count > 0)
            return cliente[0];

           return null;
        }

        [WebMethod]
        public List<ArticuloDTO> Filtrar(string filtro)
        {
            var articulos = VentasCapas.DAO.ArticuloDAO.ReadAll("where nombre like " + "'%" + filtro + "%'");
            if (articulos.Count > 0)
                return articulos;

            return null;

        }

        [WebMethod]

        public ClienteDTO Registro(string nombre, string direccion, string telefono, string email, string usuario, string contrasena) 
        {
            ClienteDTO newcliente = new ClienteDTO();
            newcliente.Nombre = nombre;
            newcliente.Direccion = direccion;
            newcliente.Telefono = telefono;
            newcliente.Email = email;
            newcliente.Usuario = usuario;
            newcliente.Contraseña = contrasena;

            try
            {
                ClienteDAO clientedao = new ClienteDAO();
                clientedao.Create(newcliente);
            }
            catch (Exception)
            {
                
                throw;
                
            }
            return null;
        }
        [WebMethod]

        public ArticuloDTO getArticuloDTO(int id)
        {
            //ArticuloDAO articulodao = new ArticuloDAO();
            var lista = ArticuloDAO.ReadAll("WHERE ID = " + id);
            return lista[0];

        }
        [WebMethod]

        public List<ClienteDTO> traerDatosUsuario(int usuario)
        {
            var lista = VentasCapas.DAO.ClienteDAO.ReadAll("where Id=" + "'" + usuario + "'");
            return lista;
        }
        [WebMethod]
        public void actualizarCliente(ClienteDTO cliente)
        {
            ClienteDAO dao =new ClienteDAO();
            dao.Update(cliente);
        }
        [WebMethod]
        public void nuevaVenta(int idcliente, List<ArticuloDTO> articuloscomprados)
        {

            VentasCapas.DAO.VentasCabeceraDAO.Create(idcliente);
            VentasCapas.DAO.VentasDetalleDAO.Create(articuloscomprados);
        }
        [WebMethod]
        public DataSet verMisCompras(int idcliente)
        {
            return VentasCapas.DAO.VentasCabeceraDAO.verMisCompras(idcliente);        
        }
        [WebMethod]
        public void actualizarStock(ArticuloDTO articulo)
        {
            VentasCapas.DAO.ArticuloDAO.Update(articulo);
        }
    } 
}
