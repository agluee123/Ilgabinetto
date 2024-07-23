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
    public partial class Registros : Form
    {
        public Registros()
        {
            InitializeComponent();
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Registros_Load(object sender, EventArgs e)
        {

            PedidoNegocio nuevo = new PedidoNegocio();
            List<Pedido> pedidos = nuevo.Registros();

            dgvRegistros.DataSource = pedidos;

        }
    }
}
