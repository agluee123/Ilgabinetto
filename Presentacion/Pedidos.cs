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
        private List<Pedido> pedidos;
        private List<Pedido> VerPedido;
        public Pedidos()
        {
            InitializeComponent();
            //dgvListaPedidos.CellClick += new DataGridViewCellEventHandler(dgvListaPedidos_CellClick);
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
                ListarPedido();

                AgregarBoton();
                ModificarColumnas();    
                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al filtrar clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void BtnAgregarProducto_Click(object sender, EventArgs e)
        {
            PedidoNegocio negocio = new PedidoNegocio();

            try
            {
                if (cbxCliente.SelectedItem != null)
                {
                    Cliente seleccionado = (Cliente)cbxCliente.SelectedItem;
                    Pedido pedido = new Pedido
                    {
                        Fecha = dtpFechaPedido.Value,
                        ClienteId = seleccionado.IdCliente,
                        Tipo = cbxTipo.SelectedItem?.ToString()
                };

                    int pedidoId = negocio.InsertarPedido(pedido);

                    Cargar_Pedido agregar = new Cargar_Pedido(pedidoId);
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
            ListarPedido();

        }

        private void ListarPedido()
        {
            PedidoNegocio nuevo= new PedidoNegocio();
            List<Pedido> pedidos = nuevo.ListarPedidos();
            dgvListaPedidos.DataSource = pedidos;


        }

        private void AgregarBoton()
        {
            DataGridViewButtonColumn VerPedido= new DataGridViewButtonColumn();
            VerPedido.Name = "Ver Pedido";
            VerPedido.Text = "Ver Pedido";
            VerPedido.UseColumnTextForButtonValue = true;
            VerPedido.HeaderText = "Acciones";     dgvListaPedidos.Columns.Add(VerPedido); 
        }

        private void dgvListaPedidos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvListaPedidos.Columns["Ver Pedido"].Index && e.RowIndex >= 0)
            {
                try
                {
                    int pedidoId = (int)dgvListaPedidos.Rows[e.RowIndex].Cells["IdPedido"].Value;

                    Cargar_Pedido form = new Cargar_Pedido(pedidoId);
                    form.ShowDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error al cargar los detalles del pedido: " + ex.Message);
                }
            }



        }

        private void ModificarColumnas()
        {
            dgvListaPedidos.Columns["idPedido"].Visible = false;
            dgvListaPedidos.Columns["ClienteId"].Visible = false;


            dgvListaPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Si quieres que la última columna ocupe el espacio restante
            dgvListaPedidos.Columns[dgvListaPedidos.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListaPedidos.ReadOnly = true;

        }

        private void btnEliminarPedido_Click(object sender, EventArgs e)
        {

            if (dgvListaPedidos.CurrentRow == null)
            {
                MessageBox.Show("No hay ningún pedido seleccionado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Pedido seleccionado = dgvListaPedidos.CurrentRow.DataBoundItem as Pedido;

            if (seleccionado == null)
            {
                MessageBox.Show("El pedido seleccionado no es válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                PedidoNegocio negocio = new PedidoNegocio();
                negocio.EliminarPedido(seleccionado);

                // Eliminación exitosa
                MessageBox.Show("Pedido eliminado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                negocio.ListarPedidos();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ListarPedido();
        }



    }
}