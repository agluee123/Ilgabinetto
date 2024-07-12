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


        //public void CrearPedido(Pedido nuevo)
        //{
        //    AccesoDatos datos = new AccesoDatos();

        //    try
        //    {
        //        datos.setearConsulta("insert into Pedidos (fecha, cliente_id) values ( @fecha , @cliente_id )");
        //        datos.setearParametro("@fecha", nuevo.Fecha);
        //        datos.setearParametro("@cliente_id", nuevo.ClienteId);


        //         datos.ejecutarAccion();

                


        //    }
        //    catch (Exception ex)
        //    {

        //        throw ex;

        //    }

        //    finally { 

        //        datos.cerrarConexion();
            
        //    }

        //}


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





    }
}
