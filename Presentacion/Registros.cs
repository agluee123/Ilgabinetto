using Dominio;
using Negocio;
using Sistema_de_pedidos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;




using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using PdfSharp.Pdf;

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            generarPDF();
        }


        private void generarPDF()
        {
            
          
            Document document = new Document();
            Section section = document.AddSection();

           
            MigraDoc.DocumentObjectModel.Font titleFont = new MigraDoc.DocumentObjectModel.Font("Arial", 14);
            MigraDoc.DocumentObjectModel.Font infoFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);
            MigraDoc.DocumentObjectModel.Font headerFont = new MigraDoc.DocumentObjectModel.Font("Arial", 12);
            MigraDoc.DocumentObjectModel.Font textFont = new MigraDoc.DocumentObjectModel.Font("Arial", 10);

            
            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.Alignment = ParagraphAlignment.Center;
            paragraph.AddFormattedText("IL GABINETTO", titleFont);
            paragraph.AddLineBreak();
            paragraph.AddFormattedText("Teléfono: (123) 456-7890\nFecha: " + DateTime.Now.ToString("dd/MM/yyyy"), infoFont);

            
            var registros = dgvRegistros.Rows.Cast<DataGridViewRow>()
                                .Where(row => !row.IsNewRow)
                                .Select(row => new Registro
                                {
                                    IdPedido = (int)row.Cells["idPedido"].Value,
                                    NombreCliente = (string)row.Cells["NombreCliente"].Value,
                                    Fecha = (DateTime)row.Cells["fecha"].Value,
                                    Cantidad = (int)row.Cells["cantidad"].Value,
                                    NombreArticulo = (string)row.Cells["nombreArticulo"].Value,
                                 
                                    Perforacion = (string)row.Cells["perforacion"].Value,
                                    Tipo = (string)row.Cells["Tipo"].Value,
                                    Observacion = row.Cells["observacion"].Value != DBNull.Value ? (string)row.Cells["observacion"].Value : string.Empty
                                })
                                .OrderBy(r => r.NombreCliente)
                                .ThenBy(r => r.IdPedido)
                                .ToList();

            
            var registrosAgrupados = registros.GroupBy(r => new { r.NombreCliente, r.IdPedido });

            foreach (var grupo in registrosAgrupados)
            {
                var primerRegistro = grupo.First();

                
                Paragraph pedidoSummary = section.AddParagraph();
                pedidoSummary.Format.Alignment = ParagraphAlignment.Left;
                pedidoSummary.Format.SpaceBefore = "5mm";
                pedidoSummary.Format.SpaceAfter = "5mm";
                pedidoSummary.AddFormattedText($"{primerRegistro.NombreCliente} - {primerRegistro.Fecha.ToString("dd/MM/yyyy")} - Pedido: {primerRegistro.IdPedido}", headerFont);
                pedidoSummary.AddLineBreak();

                
                Paragraph pedidoBox = section.AddParagraph();
                pedidoBox.Format.Borders.Width = 0.75;
                pedidoBox.Format.Borders.Color = Colors.Black;
                pedidoBox.Format.SpaceBefore = "2mm";
                pedidoBox.Format.SpaceAfter = "5mm";

                
                foreach (var registro in grupo)
                {
                    string line = $"{registro.Cantidad} {registro.NombreArticulo}";

                    
                    if (!string.IsNullOrWhiteSpace(registro.Perforacion) && registro.Perforacion != "No corresponde")
                    {
                        line += $" {registro.Perforacion}";
                    }
                    if (!string.IsNullOrWhiteSpace(registro.Observacion))
                    {
                        line += $" {registro.Observacion}";
                    }
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        pedidoBox.AddFormattedText(line + "\n", textFont);
                    }
                }
            }

            
            string timestamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string pdfPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"Pedidos_{timestamp}.pdf");

      
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(true)
            {
                Document = document
            };
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(pdfPath);

            // Informar al usuario que el PDF ha sido generado
            MessageBox.Show("PDF generado exitosamente en el escritorio.");

        }


    }
    

}
