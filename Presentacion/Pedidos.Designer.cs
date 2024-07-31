namespace Presentacion
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
            this.gbxCrearPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(126, 57);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(200, 21);
            this.cbxCliente.TabIndex = 0;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(21, 60);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(91, 13);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Seleccion cliente:";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(39, 187);
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
            this.gbxCrearPedido.Location = new System.Drawing.Point(12, 26);
            this.gbxCrearPedido.Name = "gbxCrearPedido";
            this.gbxCrearPedido.Size = new System.Drawing.Size(364, 243);
            this.gbxCrearPedido.TabIndex = 4;
            this.gbxCrearPedido.TabStop = false;
            this.gbxCrearPedido.Text = "Crear Nuevo Pedido";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(24, 129);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(82, 13);
            this.lblTipo.TabIndex = 8;
            this.lblTipo.Text = "Tipo de Pedido:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Viaje",
            "Semanal"});
            this.cbxTipo.Location = new System.Drawing.Point(126, 121);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(200, 21);
            this.cbxTipo.TabIndex = 7;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Location = new System.Drawing.Point(210, 187);
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
            this.lblFecha.Location = new System.Drawing.Point(24, 89);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(126, 89);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPedido.TabIndex = 4;
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
            this.dgvListaPedidos.Location = new System.Drawing.Point(440, 26);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.ReadOnly = true;
            this.dgvListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPedidos.Size = new System.Drawing.Size(632, 481);
            this.dgvListaPedidos.TabIndex = 5;
            this.dgvListaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPedidos_CellClick);
            this.dgvListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPedidos_CellContentClick);
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "Seleccionar";
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.ReadOnly = true;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(138, 324);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(134, 23);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Imprimir";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(440, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1098, 613);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.dgvListaPedidos);
            this.Controls.Add(this.gbxCrearPedido);
            this.Name = "Pedidos";
            this.Text = "Crear Pedido";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.gbxCrearPedido.ResumeLayout(false);
            this.gbxCrearPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
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
    }
}