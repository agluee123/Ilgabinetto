using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        

        private void Pedidos_Load(object sender, EventArgs e)
        {
           
            PedidoNegocio negocio = new PedidoNegocio();
            cbxArticulo.DataSource = negocio.listarNombre();
            ClienteNegocio cliente = new ClienteNegocio();
            cbxCliente.DataSource = cliente.listar(); 


        }
    }
}