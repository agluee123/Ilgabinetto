using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public DateTime Fecha { get; set; }
        
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
    }
}
