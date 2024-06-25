namespace Presentacion
{
    partial class Dashboard
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArticulos
            // 
            this.btnArticulos.Location = new System.Drawing.Point(331, 21);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(129, 83);
            this.btnArticulos.TabIndex = 0;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = true;
            this.btnArticulos.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(331, 128);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(129, 83);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.Location = new System.Drawing.Point(331, 242);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(129, 83);
            this.btnPedidos.TabIndex = 2;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = true;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnArticulos);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPedidos;
    }
}

