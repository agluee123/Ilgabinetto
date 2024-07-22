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
            this.button1 = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
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
            this.BtnAgregarProducto.Location = new System.Drawing.Point(45, 153);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(134, 23);
            this.BtnAgregarProducto.TabIndex = 3;
            this.BtnAgregarProducto.Text = "Agregar Productos";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // gbxCrearPedido
            // 
            this.gbxCrearPedido.Controls.Add(this.button1);
            this.gbxCrearPedido.Controls.Add(this.lblFecha);
            this.gbxCrearPedido.Controls.Add(this.dtpFechaPedido);
            this.gbxCrearPedido.Controls.Add(this.lblCliente);
            this.gbxCrearPedido.Controls.Add(this.BtnAgregarProducto);
            this.gbxCrearPedido.Controls.Add(this.cbxCliente);
            this.gbxCrearPedido.Location = new System.Drawing.Point(12, 26);
            this.gbxCrearPedido.Name = "gbxCrearPedido";
            this.gbxCrearPedido.Size = new System.Drawing.Size(364, 199);
            this.gbxCrearPedido.TabIndex = 4;
            this.gbxCrearPedido.TabStop = false;
            this.gbxCrearPedido.Text = "Crear Nuevo Pedido";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Eliminar Pedido";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dgvListaPedidos.Location = new System.Drawing.Point(440, 26);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.Size = new System.Drawing.Size(632, 481);
            this.dgvListaPedidos.TabIndex = 5;
            this.dgvListaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPedidos_CellClick);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 613);
            this.Controls.Add(this.dgvListaPedidos);
            this.Controls.Add(this.gbxCrearPedido);
            this.Name = "Pedidos";
            this.Text = "Crear Pedido";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.gbxCrearPedido.ResumeLayout(false);
            this.gbxCrearPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.GroupBox gbxCrearPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvListaPedidos;
    }
}