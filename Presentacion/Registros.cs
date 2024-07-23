using Dominio;
using Negocio;
using Sistema_de_pedidos;
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

            RegistroNegocio nuevo = new RegistroNegocio();
        
            List<Registro> registros = nuevo.Registros();

            dgvRegistros.DataSource = registros;

        }
    }
}
