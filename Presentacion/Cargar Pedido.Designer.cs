namespace Presentacion
{
    partial class Cargar_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cargar_Pedido));
            this.gbxPedido = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxObservacion = new System.Windows.Forms.TextBox();
            this.lblObservacion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nmCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblArticulo = new System.Windows.Forms.Label();
            this.cbxArticulo = new System.Windows.Forms.ComboBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.CbxEstado = new System.Windows.Forms.ComboBox();
            this.GbxEstado = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbxPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.GbxEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxPedido
            // 
            this.gbxPedido.Controls.Add(this.btnEliminar);
            this.gbxPedido.Controls.Add(this.btnAgregar);
            this.gbxPedido.Controls.Add(this.tbxObservacion);
            this.gbxPedido.Controls.Add(this.lblObservacion);
            this.gbxPedido.Controls.Add(this.lblCantidad);
            this.gbxPedido.Controls.Add(this.nmCantidad);
            this.gbxPedido.Controls.Add(this.lblArticulo);
            this.gbxPedido.Controls.Add(this.cbxArticulo);
            this.gbxPedido.Location = new System.Drawing.Point(53, 12);
            this.gbxPedido.Name = "gbxPedido";
            this.gbxPedido.Size = new System.Drawing.Size(362, 154);
            this.gbxPedido.TabIndex = 0;
            this.gbxPedido.TabStop = false;
            this.gbxPedido.Text = "Agregar al pedido";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(187, 125);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(16, 125);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(137, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxObservacion
            // 
            this.tbxObservacion.Location = new System.Drawing.Point(44, 73);
            this.tbxObservacion.Name = "tbxObservacion";
            this.tbxObservacion.Size = new System.Drawing.Size(230, 20);
            this.tbxObservacion.TabIndex = 4;
            // 
            // lblObservacion
            // 
            this.lblObservacion.AutoSize = true;
            this.lblObservacion.Location = new System.Drawing.Point(41, 57);
            this.lblObservacion.Name = "lblObservacion";
            this.lblObservacion.Size = new System.Drawing.Size(70, 13);
            this.lblObservacion.TabIndex = 3;
            this.lblObservacion.Text = "Observacion:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(299, 18);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // nmCantidad
            // 
            this.nmCantidad.Location = new System.Drawing.Point(302, 34);
            this.nmCantidad.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nmCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCantidad.Name = "nmCantidad";
            this.nmCantidad.Size = new System.Drawing.Size(53, 20);
            this.nmCantidad.TabIndex = 2;
            this.nmCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblArticulo
            // 
            this.lblArticulo.AutoSize = true;
            this.lblArticulo.Location = new System.Drawing.Point(41, 19);
            this.lblArticulo.Name = "lblArticulo";
            this.lblArticulo.Size = new System.Drawing.Size(112, 13);
            this.lblArticulo.TabIndex = 1;
            this.lblArticulo.Text = "Seleccione el Articulo:";
            // 
            // cbxArticulo
            // 
            this.cbxArticulo.FormattingEnabled = true;
            this.cbxArticulo.Location = new System.Drawing.Point(44, 34);
            this.cbxArticulo.Name = "cbxArticulo";
            this.cbxArticulo.Size = new System.Drawing.Size(230, 21);
            this.cbxArticulo.TabIndex = 0;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(89, 62);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(137, 23);
            this.BtnModificar.TabIndex = 7;
            this.BtnModificar.Text = "Modificar Estado";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(32, 19);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(98, 13);
            this.lblEstado.TabIndex = 6;
            this.lblEstado.Text = "Estado Del Pedido:";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(41, 172);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.ReadOnly = true;
            this.dgvPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPedido.Size = new System.Drawing.Size(713, 450);
            this.dgvPedido.TabIndex = 2;
            // 
            // CbxEstado
            // 
            this.CbxEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEstado.FormattingEnabled = true;
            this.CbxEstado.Items.AddRange(new object[] {
            "Entregado",
            "Pendiente"});
            this.CbxEstado.Location = new System.Drawing.Point(35, 35);
            this.CbxEstado.Name = "CbxEstado";
            this.CbxEstado.Size = new System.Drawing.Size(230, 21);
            this.CbxEstado.TabIndex = 5;
            // 
            // GbxEstado
            // 
            this.GbxEstado.Controls.Add(this.BtnModificar);
            this.GbxEstado.Controls.Add(this.lblEstado);
            this.GbxEstado.Controls.Add(this.CbxEstado);
            this.GbxEstado.Location = new System.Drawing.Point(421, 12);
            this.GbxEstado.Name = "GbxEstado";
            this.GbxEstado.Size = new System.Drawing.Size(333, 106);
            this.GbxEstado.TabIndex = 8;
            this.GbxEstado.TabStop = false;
            this.GbxEstado.Text = "Estado";
            // 
            // Cargar_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 634);
            this.Controls.Add(this.GbxEstado);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.gbxPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Cargar_Pedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar al pedido";
            this.Load += new System.EventHandler(this.Cargar_Pedido_Load);
            this.gbxPedido.ResumeLayout(false);
            this.gbxPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.GbxEstado.ResumeLayout(false);
            this.GbxEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxPedido;
        private System.Windows.Forms.Label lblArticulo;
        private System.Windows.Forms.ComboBox cbxArticulo;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nmCantidad;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxObservacion;
        private System.Windows.Forms.Label lblObservacion;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.ComboBox CbxEstado;
        private System.Windows.Forms.GroupBox GbxEstado;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}