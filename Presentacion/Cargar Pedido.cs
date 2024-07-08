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
        public Cargar_Pedido()
        {
            InitializeComponent();
        }

        private void Cargar_Pedido_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio=new ArticuloNegocio();
            List<Articulo> articulos=negocio.listar();
            cbxArticulo.DataSource=articulos;
        }

        //aguante boca 
    }
}
