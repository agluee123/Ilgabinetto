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
    public partial class Cargar_Pedido : Form
    {
        private List <Articulo> articulos;
        private List <ArticuloPedido> pedidos;  
        public int PedidoId { get; set; }
        

        public Cargar_Pedido(int pedidoId)
        {
            InitializeComponent();
            PedidoId = pedidoId;
        }

        private void Cargar_Pedido_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio=new ArticuloNegocio();
            List<Articulo> articulos=negocio.listar();
            cbxArticulo.DataSource=articulos;
            cbxArticulo.DisplayMember = "Nombre";
            cbxArticulo.ValueMember = "IdArticulo";
            CargarDatos();
            CambiarOrdenColumnas();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloPedido nuevo = new ArticuloPedido
                {
                    PedidoId = PedidoId,
                    ArticuloId = ((Articulo)cbxArticulo.SelectedItem).IdArticulo,
                    Cantidad = Convert.ToInt32(nmCantidad.Value),
                    Observacion = tbxObservacion.Text
                };

                ArticuloPedidoNegocio negocio = new ArticuloPedidoNegocio();
                negocio.agregar(nuevo);

                MessageBox.Show("Artículo agregado al pedido.");
                CargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el artículo: " + ex.Message);
            }
        }

        private void CargarDatos()
        {

            try
            {
                ArticuloPedidoNegocio negocio = new ArticuloPedidoNegocio();
                pedidos = negocio.listar();
                var pedidosFiltrados = pedidos.Where(p => p.PedidoId == PedidoId).ToList();

                dgvPedido.DataSource = pedidosFiltrados;
                dgvPedido.Columns["IdArticulosPedido"].Visible = false;
                dgvPedido.Columns["PedidoId"].Visible = false;
                dgvPedido.Columns["ArticuloId"].Visible = false;

                dgvPedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Si quieres que la última columna ocupe el espacio restante
                dgvPedido.Columns[dgvPedido.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void CambiarOrdenColumnas()
        {
            
            dgvPedido.Columns["Cantidad"].DisplayIndex = 0; // Primera columna
            dgvPedido.Columns["NombreArticulo"].DisplayIndex = 1; // Segunda columna
            dgvPedido.Columns["Observacion"].DisplayIndex = 2; // Tercera columna
                                                                  
        }


    }
}
