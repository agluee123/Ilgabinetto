using Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ArticuloPedidoNegocio
    {
        public void agregar(ArticuloPedido nuevo)
        {
			AccesoDatos datos= new AccesoDatos();	
			try
			{
				datos.setearConsulta("insert into ArticulosPedidos (pedido_id ,articulo_id ,cantidad, observacion) values (@pedido_id,@articulo_id,@cantidad,@observacion)");
				datos.setearParametro("@pedido_id", nuevo.PedidoId);
                datos.setearParametro("@articulo_id", nuevo.ArticuloId);
                datos.setearParametro("@cantidad", nuevo.Cantidad);
                datos.setearParametro("@observacion", nuevo.Observacion);

                datos.ejecutarAccion();

            }
			catch (Exception ex)
			{
                datos.cerrarConexion();
				throw ex;
			}

        }

        public List <ArticuloPedido> listar()
        {
            List <ArticuloPedido> lista=new List<ArticuloPedido>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString= "server=.\\SQLEXPRESS; database=ILGABINETTO; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "select * from ArticulosPedidos";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    ArticuloPedido aux=new ArticuloPedido();
                    aux.IdArticulosPedido=(int)lector["id_articulosPedido"];
                    aux.PedidoId = (int)lector["pedido_id"];
                    aux.ArticuloId = (int)lector["articulo_id"];
                    aux.Cantidad = (int)lector["cantidad"];
                    aux.Observacion = (string)lector["observacion"];

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
    }
}
