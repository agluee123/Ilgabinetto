namespace Presentacion
{
    partial class Registros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxFecha = new System.Windows.Forms.GroupBox();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dTPreg2 = new System.Windows.Forms.DateTimePicker();
            this.dTPReg1 = new System.Windows.Forms.DateTimePicker();
            this.lblTipodePedido = new System.Windows.Forms.Label();
            this.CBXTipoPed = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gbxBuscarPedido = new System.Windows.Forms.GroupBox();
            this.btnImprimir2 = new System.Windows.Forms.Button();
            this.gbxCantidades = new System.Windows.Forms.GroupBox();
            this.btnBuscarVendidos = new System.Windows.Forms.Button();
            this.btnImprimirVendidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.gbxFecha.SuspendLayout();
            this.gbxBuscarPedido.SuspendLayout();
            this.gbxCantidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(308, 71);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(559, 447);
            this.dgvRegistros.TabIndex = 0;
            this.dgvRegistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellContentClick);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(305, 39);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(29, 13);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Filtro";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(360, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(507, 20);
            this.textBox1.TabIndex = 2;
            // 
            // gbxFecha
            // 
            this.gbxFecha.Controls.Add(this.lblHasta);
            this.gbxFecha.Controls.Add(this.lblDesde);
            this.gbxFecha.Controls.Add(this.dTPreg2);
            this.gbxFecha.Controls.Add(this.dTPReg1);
            this.gbxFecha.Location = new System.Drawing.Point(12, 48);
            this.gbxFecha.Name = "gbxFecha";
            this.gbxFecha.Size = new System.Drawing.Size(248, 130);
            this.gbxFecha.TabIndex = 3;
            this.gbxFecha.TabStop = false;
            this.gbxFecha.Text = "Ingresar Fecha";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(18, 67);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(15, 23);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            // 
            // dTPreg2
            // 
            this.dTPreg2.Location = new System.Drawing.Point(15, 85);
            this.dTPreg2.Name = "dTPreg2";
            this.dTPreg2.Size = new System.Drawing.Size(216, 20);
            this.dTPreg2.TabIndex = 1;
            // 
            // dTPReg1
            // 
            this.dTPReg1.Location = new System.Drawing.Point(15, 40);
            this.dTPReg1.Name = "dTPReg1";
            this.dTPReg1.Size = new System.Drawing.Size(216, 20);
            this.dTPReg1.TabIndex = 0;
            // 
            // lblTipodePedido
            // 
            this.lblTipodePedido.AutoSize = true;
            this.lblTipodePedido.Location = new System.Drawing.Point(12, 23);
            this.lblTipodePedido.Name = "lblTipodePedido";
            this.lblTipodePedido.Size = new System.Drawing.Size(81, 13);
            this.lblTipodePedido.TabIndex = 4;
            this.lblTipodePedido.Text = "Tipo de pedido:";
            // 
            // CBXTipoPed
            // 
            this.CBXTipoPed.FormattingEnabled = true;
            this.CBXTipoPed.Items.AddRange(new object[] {
            "Viaje",
            "Semanal"});
            this.CBXTipoPed.Location = new System.Drawing.Point(15, 39);
            this.CBXTipoPed.Name = "CBXTipoPed";
            this.CBXTipoPed.Size = new System.Drawing.Size(216, 21);
            this.CBXTipoPed.TabIndex = 5;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(15, 66);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 25);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(127, 66);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(106, 25);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir Pedido";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // gbxBuscarPedido
            // 
            this.gbxBuscarPedido.Controls.Add(this.btnImprimir2);
            this.gbxBuscarPedido.Controls.Add(this.CBXTipoPed);
            this.gbxBuscarPedido.Controls.Add(this.lblTipodePedido);
            this.gbxBuscarPedido.Controls.Add(this.btnBuscar);
            this.gbxBuscarPedido.Controls.Add(this.btnImprimir);
            this.gbxBuscarPedido.Location = new System.Drawing.Point(12, 213);
            this.gbxBuscarPedido.Name = "gbxBuscarPedido";
            this.gbxBuscarPedido.Size = new System.Drawing.Size(248, 131);
            this.gbxBuscarPedido.TabIndex = 9;
            this.gbxBuscarPedido.TabStop = false;
            this.gbxBuscarPedido.Text = "Buscar Pedidos";
            // 
            // btnImprimir2
            // 
            this.btnImprimir2.Location = new System.Drawing.Point(70, 97);
            this.btnImprimir2.Name = "btnImprimir2";
            this.btnImprimir2.Size = new System.Drawing.Size(119, 25);
            this.btnImprimir2.TabIndex = 11;
            this.btnImprimir2.Text = "Imprimir Produccion";
            this.btnImprimir2.UseVisualStyleBackColor = true;
            // 
            // gbxCantidades
            // 
            this.gbxCantidades.Controls.Add(this.btnBuscarVendidos);
            this.gbxCantidades.Controls.Add(this.btnImprimirVendidos);
            this.gbxCantidades.Location = new System.Drawing.Point(12, 350);
            this.gbxCantidades.Name = "gbxCantidades";
            this.gbxCantidades.Size = new System.Drawing.Size(248, 131);
            this.gbxCantidades.TabIndex = 10;
            this.gbxCantidades.TabStop = false;
            this.gbxCantidades.Text = "Buscar Cantidad Vendida";
            // 
            // btnBuscarVendidos
            // 
            this.btnBuscarVendidos.Location = new System.Drawing.Point(6, 54);
            this.btnBuscarVendidos.Name = "btnBuscarVendidos";
            this.btnBuscarVendidos.Size = new System.Drawing.Size(106, 25);
            this.btnBuscarVendidos.TabIndex = 6;
            this.btnBuscarVendidos.Text = "Buscar";
            this.btnBuscarVendidos.UseVisualStyleBackColor = true;
            // 
            // btnImprimirVendidos
            // 
            this.btnImprimirVendidos.Location = new System.Drawing.Point(127, 54);
            this.btnImprimirVendidos.Name = "btnImprimirVendidos";
            this.btnImprimirVendidos.Size = new System.Drawing.Size(106, 25);
            this.btnImprimirVendidos.TabIndex = 7;
            this.btnImprimirVendidos.Text = "Imprimir";
            this.btnImprimirVendidos.UseVisualStyleBackColor = true;
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 655);
            this.Controls.Add(this.gbxCantidades);
            this.Controls.Add(this.gbxBuscarPedido);
            this.Controls.Add(this.gbxFecha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvRegistros);
            this.Name = "Registros";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.gbxFecha.ResumeLayout(false);
            this.gbxFecha.PerformLayout();
            this.gbxBuscarPedido.ResumeLayout(false);
            this.gbxBuscarPedido.PerformLayout();
            this.gbxCantidades.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbxFecha;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dTPreg2;
        private System.Windows.Forms.DateTimePicker dTPReg1;
        private System.Windows.Forms.ComboBox CBXTipoPed;
        private System.Windows.Forms.Label lblTipodePedido;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox gbxBuscarPedido;
        private System.Windows.Forms.GroupBox gbxCantidades;
        private System.Windows.Forms.Button btnBuscarVendidos;
        private System.Windows.Forms.Button btnImprimirVendidos;
        private System.Windows.Forms.Button btnImprimir2;
    }
}