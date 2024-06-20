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
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo NuevoArticulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                NuevoArticulo.Nombre=tbxNombre.Text; 
                NuevoArticulo.Categoria=cbxCategoria.SelectedItem?.ToString(); 
                NuevoArticulo.Medida=tbxMedida.Text; 
                NuevoArticulo.Perforacion=cbxPerforacion.SelectedItem?.ToString();   
                NuevoArticulo.Color=cbxColor.SelectedItem?.ToString();

                negocio.Agregar(NuevoArticulo);

                MessageBox.Show("Artículo agregado correctamente");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
