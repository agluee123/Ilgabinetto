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
            //cbxArticulo.DataSource = negocio.listarNombre();
            ClienteNegocio cliente = new ClienteNegocio();
            cbxCliente.DataSource = cliente.listar();

          

        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            PedidoNegocio negocio = new PedidoNegocio();

            Pedido pedido = new Pedido();

            try
            {

                if (cbxCliente.SelectedItem != null)
                {
                    Cliente seleccionado = (Cliente)cbxCliente.SelectedItem;
                    pedido.Fecha = dtpFechaPedido.Value;
                    pedido.ClienteId = seleccionado.IdCliente;

                    negocio.CrearPedido(pedido);

                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente.");
                }

                MessageBox.Show("pedido cargado");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ocurrió un error: " + ex.Message);
            
            }
        }

       
    }
}