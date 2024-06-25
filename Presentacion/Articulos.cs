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
    public partial class Articulos : Form
    {
        private List<Articulo> lista;
        public Articulos()
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
                CargarDatos();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void CargarDatos()
        {
           
            try
            {
                lista = new ArticuloNegocio().listar();

                dgvArticulos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Articulos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                tbxNombre.Text = seleccionado.Nombre;
                cbxCategoria.SelectedItem = seleccionado.Categoria;
                tbxMedida.Text = seleccionado.Medida;
                cbxPerforacion.SelectedItem = seleccionado.Perforacion;
                cbxColor.SelectedItem = seleccionado.Color; 

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminar();

        }

        private void eliminar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                DialogResult respuesta = MessageBox.Show("¿De verdad querés eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta == DialogResult.Yes)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.EliminarArticulo(seleccionado);
                    CargarDatos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = tbxFiltro.Text.ToUpper(); // Convertir el filtro a mayúsculas una vez

            if (filtro.Length >= 3)
            {
                listaFiltrada = lista.FindAll(x =>
                    x.Nombre.ToUpper().Contains(filtro) || // Filtrar por nombre que contiene el filtro
                    x.Categoria.ToUpper().Contains(filtro) // Filtrar por categoría que contiene el filtro
                );
            }
            else
            {
                listaFiltrada = lista; // Mostrar la lista completa si el filtro es corto
            }

            // Actualizar el DataSource del DataGridView con la lista filtrada
            dgvArticulos.DataSource = null; // Limpiar el DataSource previo si lo hubiera
            dgvArticulos.DataSource = listaFiltrada; // Asignar la lista filtrada como DataSource del DataGridView


        }

        private void modificar()
        {
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                seleccionado.Nombre = tbxNombre.Text;
                seleccionado.Categoria = cbxCategoria.SelectedItem?.ToString();
                seleccionado.Medida = tbxMedida.Text;
                seleccionado.Perforacion = cbxPerforacion.SelectedItem?.ToString();
                seleccionado.Color = cbxColor.SelectedItem?.ToString();

                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.Modificar(seleccionado);

                // Mostrar mensaje de éxito
                MessageBox.Show("Artículo modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarDatos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar artículo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModiicar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbxNombre.Clear();
            cbxCategoria.SelectedItem = null;
            tbxMedida.Clear();
            cbxPerforacion.SelectedItem=null;
            cbxColor.SelectedItem = null;   
        }
    }
}
