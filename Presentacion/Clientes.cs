﻿using Dominio;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Cliente NuevoCliente = new Cliente();
            ClienteNegocio negocio = new ClienteNegocio();
            try
            {
                NuevoCliente.Nombre = tbxNombre.Text;
                NuevoCliente.Direccion = tbxDireccion.Text;
                NuevoCliente.Cuit = tbxCuit.Text;   
                NuevoCliente.Localidad =tbxLocalidad.Text;  
                NuevoCliente.Telefono = tbxTelefono.Text;   

                negocio.Agregar(NuevoCliente);

                MessageBox.Show("Cliente agregado exitosamente");
                CargarDatos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarDatos()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                lista = new ClienteNegocio().listar();

                dgvClientes.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
