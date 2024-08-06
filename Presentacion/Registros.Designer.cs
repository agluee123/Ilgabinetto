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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimirVendidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(308, 71);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(559, 447);
            this.dgvRegistros.TabIndex = 0;
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
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(82, 125);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(106, 25);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir Pedido";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimirVendidos
            // 
            this.btnImprimirVendidos.Location = new System.Drawing.Point(50, 280);
            this.btnImprimirVendidos.Name = "btnImprimirVendidos";
            this.btnImprimirVendidos.Size = new System.Drawing.Size(170, 25);
            this.btnImprimirVendidos.TabIndex = 7;
            this.btnImprimirVendidos.Text = "Imprimir Produccion";
            this.btnImprimirVendidos.UseVisualStyleBackColor = true;
            this.btnImprimirVendidos.Click += new System.EventHandler(this.btnImprimirVendidos_Click);
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 655);
            this.Controls.Add(this.btnImprimirVendidos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvRegistros);
            this.Name = "Registros";
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimirVendidos;
    }
}