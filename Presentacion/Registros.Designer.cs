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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimirVendidos = new System.Windows.Forms.Button();
            this.GbxImpresion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.GbxImpresion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(41, 172);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(713, 450);
            this.dgvRegistros.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(68, 49);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(133, 25);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir Semanal";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimirVendidos
            // 
            this.btnImprimirVendidos.Location = new System.Drawing.Point(313, 49);
            this.btnImprimirVendidos.Name = "btnImprimirVendidos";
            this.btnImprimirVendidos.Size = new System.Drawing.Size(170, 25);
            this.btnImprimirVendidos.TabIndex = 7;
            this.btnImprimirVendidos.Text = "Imprimir Viaje";
            this.btnImprimirVendidos.UseVisualStyleBackColor = true;
            this.btnImprimirVendidos.Click += new System.EventHandler(this.btnImprimirVendidos_Click);
            // 
            // GbxImpresion
            // 
            this.GbxImpresion.Controls.Add(this.btnImprimir);
            this.GbxImpresion.Controls.Add(this.btnImprimirVendidos);
            this.GbxImpresion.Location = new System.Drawing.Point(108, 12);
            this.GbxImpresion.Name = "GbxImpresion";
            this.GbxImpresion.Size = new System.Drawing.Size(587, 119);
            this.GbxImpresion.TabIndex = 8;
            this.GbxImpresion.TabStop = false;
            this.GbxImpresion.Text = "Imprimir";
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 634);
            this.Controls.Add(this.GbxImpresion);
            this.Controls.Add(this.dgvRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.GbxImpresion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimirVendidos;
        private System.Windows.Forms.GroupBox GbxImpresion;
    }
}