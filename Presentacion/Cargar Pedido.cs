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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el artículo: " + ex.Message);
            }
        }

         
    }
}
