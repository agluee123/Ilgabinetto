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

        private void cbxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            
        }

        private void CargarNombresArticulosEnComboBox()
        {
            PedidoNegocio negocio= new PedidoNegocio(); 
            try
            {
                List<string> listaNombresArticulos = negocio.listarNombre();

                // Configurar el ComboBox para mostrar solo los nombres de los artículos
                cbxArticulo.DataSource = listaNombresArticulos;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los nombres de los artículos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}