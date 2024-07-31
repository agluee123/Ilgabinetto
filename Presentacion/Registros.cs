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

        public List<int> idsSeleccionados;



        public Registros()
        {
            InitializeComponent();
        }
       

        public Registros(List<int> idsSeleccionados)
        {
            InitializeComponent();
            this.idsSeleccionados = idsSeleccionados;
        }

        private void dgvRegistros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Registros_Load(object sender, EventArgs e)
        {

            /* RegistroNegocio nuevo = new RegistroNegocio();

             List<Registro> registros = nuevo.Registros();

             dgvRegistros.DataSource = registros;*/


            /*

            RegistroNegocio nuevo = new RegistroNegocio();
            List<Registro> registros = nuevo.Registros();

            var listaFiltrada = registros.Where(registro => idsSeleccionados.Contains(registro.IdPedido)).ToList();

            dgvRegistros.DataSource = listaFiltrada;

            */

            RegistroNegocio nuevo = new RegistroNegocio();
            List<Registro> registros = nuevo.Registros();

            if (idsSeleccionados != null && idsSeleccionados.Count > 0)
            {
                var listaFiltrada = registros.Where(registro => idsSeleccionados.Contains(registro.IdPedido)).ToList();
                dgvRegistros.DataSource = listaFiltrada;
            }
            else
            {
                dgvRegistros.DataSource = registros;
            }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
                DateTime fechaInicio = dTPReg1.Value.Date;
                DateTime fechaFin = dTPreg2.Value.Date;
                string tipoPedido = CBXTipoPed.SelectedItem.ToString();

                RegistroNegocio nuevo = new RegistroNegocio();
                List<Registro> registros = nuevo.Registros();

                var listaFiltrada = registros.Where(r => r.Fecha >= fechaInicio && r.Fecha <= fechaFin && r.Tipo == tipoPedido  ).ToList();

                dgvRegistros.DataSource = listaFiltrada;
            

        }
    }
}
