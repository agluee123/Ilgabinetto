using Dominio;
using System;
using System.Collections.Generic;
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

            }
			catch (Exception ex)
			{

				throw ex;
			}

        }
    }
}
