﻿namespace Presentacion
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.gbxCrearPedido = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnReg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.gbxFecha = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dTPreg2 = new System.Windows.Forms.DateTimePicker();
            this.dTPReg1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEst = new System.Windows.Forms.Button();
            this.cbxSelEstado = new System.Windows.Forms.ComboBox();
            this.cbxSelTipo = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbxCrearPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            this.gbxFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(131, 22);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(200, 21);
            this.cbxCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(26, 25);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(91, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Seleccion cliente:";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(20, 132);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(134, 23);
            this.BtnAgregarProducto.TabIndex = 3;
            this.BtnAgregarProducto.Text = "Agregar Productos";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // gbxCrearPedido
            // 
            this.gbxCrearPedido.Controls.Add(this.lblTipo);
            this.gbxCrearPedido.Controls.Add(this.cbxTipo);
            this.gbxCrearPedido.Controls.Add(this.btnEliminarPedido);
            this.gbxCrearPedido.Controls.Add(this.lblFecha);
            this.gbxCrearPedido.Controls.Add(this.dtpFechaPedido);
            this.gbxCrearPedido.Controls.Add(this.lblCliente);
            this.gbxCrearPedido.Controls.Add(this.BtnAgregarProducto);
            this.gbxCrearPedido.Controls.Add(this.cbxCliente);
            this.gbxCrearPedido.Location = new System.Drawing.Point(24, 76);
            this.gbxCrearPedido.Name = "gbxCrearPedido";
            this.gbxCrearPedido.Size = new System.Drawing.Size(364, 168);
            this.gbxCrearPedido.TabIndex = 4;
            this.gbxCrearPedido.TabStop = false;
            this.gbxCrearPedido.Text = "Crear Nuevo Pedido";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(29, 94);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo de Pedido:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Viaje",
            "Semanal",
            "Transporte"});
            this.cbxTipo.Location = new System.Drawing.Point(131, 86);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(200, 21);
            this.cbxTipo.TabIndex = 7;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Location = new System.Drawing.Point(215, 132);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(134, 23);
            this.btnEliminarPedido.TabIndex = 6;
            this.btnEliminarPedido.Text = "Eliminar Pedido";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(29, 54);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(131, 54);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPedido.TabIndex = 4;
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
            this.dgvListaPedidos.Location = new System.Drawing.Point(440, 76);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.ReadOnly = true;
            this.dgvListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPedidos.Size = new System.Drawing.Size(659, 518);
            this.dgvListaPedidos.TabIndex = 5;
            this.dgvListaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPedidos_CellClick);
            this.dgvListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPedidos_CellContentClick);
            this.dgvListaPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaPedidos_CellFormatting);
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "Seleccionar";
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.ReadOnly = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(254, 532);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(134, 23);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Imprimir";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(516, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(531, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(440, 44);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(43, 13);
            this.lblFiltro.TabIndex = 9;
            this.lblFiltro.Text = "Buscar:";
            // 
            // gbxFecha
            // 
            this.gbxFecha.Controls.Add(this.btnBuscar);
            this.gbxFecha.Controls.Add(this.lblHasta);
            this.gbxFecha.Controls.Add(this.lblDesde);
            this.gbxFecha.Controls.Add(this.dTPreg2);
            this.gbxFecha.Controls.Add(this.dTPReg1);
            this.gbxFecha.Location = new System.Drawing.Point(24, 265);
            this.gbxFecha.Name = "gbxFecha";
            this.gbxFecha.Size = new System.Drawing.Size(364, 144);
            this.gbxFecha.TabIndex = 10;
            this.gbxFecha.TabStop = false;
            this.gbxFecha.Text = "Buscar Por Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(110, 111);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(137, 25);
            this.btnBuscar.TabIndex = 11;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.dTPreg2.Size = new System.Drawing.Size(329, 20);
            this.dTPreg2.TabIndex = 1;
            // 
            // dTPReg1
            // 
            this.dTPReg1.Location = new System.Drawing.Point(15, 40);
            this.dTPReg1.Name = "dTPReg1";
            this.dTPReg1.Size = new System.Drawing.Size(329, 20);
            this.dTPReg1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarEst);
            this.groupBox1.Controls.Add(this.cbxSelEstado);
            this.groupBox1.Controls.Add(this.cbxSelTipo);
            this.groupBox1.Location = new System.Drawing.Point(24, 429);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 87);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por Estado";
            // 
            // btnBuscarEst
            // 
            this.btnBuscarEst.Location = new System.Drawing.Point(110, 58);
            this.btnBuscarEst.Name = "btnBuscarEst";
            this.btnBuscarEst.Size = new System.Drawing.Size(137, 23);
            this.btnBuscarEst.TabIndex = 2;
            this.btnBuscarEst.Text = "Buscar";
            this.btnBuscarEst.UseVisualStyleBackColor = true;
            this.btnBuscarEst.Click += new System.EventHandler(this.btnBuscarEst_Click);
            // 
            // cbxSelEstado
            // 
            this.cbxSelEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelEstado.FormattingEnabled = true;
            this.cbxSelEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Entregado"});
            this.cbxSelEstado.Location = new System.Drawing.Point(210, 31);
            this.cbxSelEstado.Name = "cbxSelEstado";
            this.cbxSelEstado.Size = new System.Drawing.Size(121, 21);
            this.cbxSelEstado.TabIndex = 1;
            // 
            // cbxSelTipo
            // 
            this.cbxSelTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelTipo.FormattingEnabled = true;
            this.cbxSelTipo.Items.AddRange(new object[] {
            "Semanal",
            "Viaje",
            "Transporte"});
            this.cbxSelTipo.Location = new System.Drawing.Point(24, 31);
            this.cbxSelTipo.Name = "cbxSelTipo";
            this.cbxSelTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxSelTipo.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(24, 532);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(134, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "Limpiar Busqueda";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1149, 634);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxFecha);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.dgvListaPedidos);
            this.Controls.Add(this.gbxCrearPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Pedido";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.gbxCrearPedido.ResumeLayout(false);
            this.gbxCrearPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            this.gbxFecha.ResumeLayout(false);
            this.gbxFecha.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.GroupBox gbxCrearPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.DataGridView dgvListaPedidos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox gbxFecha;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dTPreg2;
        private System.Windows.Forms.DateTimePicker dTPReg1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEst;
        private System.Windows.Forms.ComboBox cbxSelEstado;
        private System.Windows.Forms.ComboBox cbxSelTipo;
        private System.Windows.Forms.Button btnLimpiar;
    }
}