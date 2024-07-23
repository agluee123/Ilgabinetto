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
        public string Tipo { get; set; }

        public int Cantidad { get; set; }
        public string NombreArticulo { get; set; }
        public string Color { get; set; }
        public string Perforacion { get; set; }
       
        public string Observacion { get; set; }

    }
}
