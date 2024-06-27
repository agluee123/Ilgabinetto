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
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.gbxCrearPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(144, 57);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(182, 21);
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
            this.BtnAgregarProducto.Location = new System.Drawing.Point(120, 115);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(134, 23);
            this.BtnAgregarProducto.TabIndex = 3;
            this.BtnAgregarProducto.Text = "Agregar Productos";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // gbxCrearPedido
            // 
            this.gbxCrearPedido.Controls.Add(this.dtpFechaPedido);
            this.gbxCrearPedido.Controls.Add(this.lblCliente);
            this.gbxCrearPedido.Controls.Add(this.BtnAgregarProducto);
            this.gbxCrearPedido.Controls.Add(this.cbxCliente);
            this.gbxCrearPedido.Location = new System.Drawing.Point(116, 67);
            this.gbxCrearPedido.Name = "gbxCrearPedido";
            this.gbxCrearPedido.Size = new System.Drawing.Size(453, 178);
            this.gbxCrearPedido.TabIndex = 4;
            this.gbxCrearPedido.TabStop = false;
            this.gbxCrearPedido.Text = "Crear Pedido";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(126, 89);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaPedido.TabIndex = 4;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 337);
            this.Controls.Add(this.gbxCrearPedido);
            this.Name = "Pedidos";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.gbxCrearPedido.ResumeLayout(false);
            this.gbxCrearPedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.GroupBox gbxCrearPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
    }
}