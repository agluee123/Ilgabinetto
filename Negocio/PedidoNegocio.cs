using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class PedidoNegocio
    {
        public List<Articulo> listarNombre()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select id_articulo,nombre from articulo";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)lector["id_articulo"];

                    aux.Nombre = (string)lector["nombre"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       
        public int InsertarPedido(Pedido nuevo)
        {
            int pedidoId = 0;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                // Configurar la consulta SQL para insertar un pedido y obtener el ID generado automáticamente
                datos.setearConsulta("insert into Pedidos (fecha, cliente_id) output inserted.id_pedido values (@Fecha, @ClienteId)");
                datos.setearParametro("@Fecha", nuevo.Fecha);
                datos.setearParametro("@ClienteId", nuevo.ClienteId);

                datos.abrirConexion();  
                // Ejecutar la consulta y obtener el ID del pedido
                pedidoId = (int)datos.ejecutarAccionEscalar();

                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return pedidoId;
        }

        public  List<Pedido> ListarPedidos()
        {
            List<Pedido> lista = new List<Pedido>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;

                comando.CommandText = "select  Pedidos.id_pedido ,  clientes.nombre as Nombre_Cliente, Pedidos.fecha as fecha_Del_Pedido from Pedidos join Clientes on Clientes.id_cliente = Pedidos.cliente_id;";
                comando.Connection = conexion;

                conexion.Open();
                lector= comando.ExecuteReader();

                while (lector.Read())
                {
                    Pedido aux = new Pedido
                    {
                        IdPedido = (int)lector["id_pedido"],
                        NombreCliente = (string)lector["Nombre_Cliente"],
                        Fecha = (DateTime)lector["Fecha_Del_Pedido"]
                    };

                    lista.Add(aux);

                }

                conexion.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }




        public void EliminarPedido(Pedido eliminar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearConsulta("DELETE FROM PEDIDOS WHERE id_pedido = @Id");
                datos.setearParametro("@Id", eliminar.IdPedido);
                datos.ejecutarAccion();
            }

            catch (Exception ex)
            {

                Console.WriteLine("Error al eliminar el pedido: " + ex.Message);

            }
            finally
            {
                datos.cerrarConexion();
            }

        }




    }
}
