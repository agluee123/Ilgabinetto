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
        private List<Cliente> clientes; 
        public Pedidos()
        {
            InitializeComponent();
        }



        private void Pedidos_Load(object sender, EventArgs e)
        {
            try
            {
                PedidoNegocio negocio = new PedidoNegocio();
                //cbxArticulo.DataSource = negocio.listarNombre(); // Comentado porque no está relacionado con cbxCliente
                ClienteNegocio clienteNegocio = new ClienteNegocio();
                List<Cliente> clientes = clienteNegocio.listar(); // Obtener la lista de clientes desde el negocio

                // Si la lista de clientes está vacía, muestra un mensaje o realiza alguna acción adecuada
                if (clientes == null || clientes.Count == 0)
                {
                    MessageBox.Show("No se encontraron clientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Obtener el texto del filtro (no es necesario convertir a minúsculas aquí)
                string filtro = cbxCliente.Text;

                // Filtrar los clientes que coinciden con el filtro (insensible a mayúsculas y minúsculas)
                List<Cliente> clientesFiltrados = clientes
                                                    .Where(c => c.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0)
                                                    .ToList();

                // Establecer el DataSource de la ComboBox con la lista filtrada
                cbxCliente.DataSource = null; // Limpiar el DataSource para evitar conflictos
                cbxCliente.DataSource = clientesFiltrados; // Establecer el DataSource con la lista filtrada
                cbxCliente.DisplayMember = "Nombre"; // Especificar la propiedad que quieres mostrar en la ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






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

                    Cargar_Pedido agregar= new Cargar_Pedido();
                    agregar.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un cliente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }

        }



    }
}