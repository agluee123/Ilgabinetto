namespace Presentacion
{
    partial class Agregar
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblPerforacion = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.tbxMedida = new System.Windows.Forms.TextBox();
            this.cbxPerforacion = new System.Windows.Forms.ComboBox();
            this.cbxColor = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(318, 90);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(318, 137);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Location = new System.Drawing.Point(318, 178);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(42, 13);
            this.lblMedida.TabIndex = 2;
            this.lblMedida.Text = "Medida";
            // 
            // lblPerforacion
            // 
            this.lblPerforacion.AutoSize = true;
            this.lblPerforacion.Location = new System.Drawing.Point(318, 225);
            this.lblPerforacion.Name = "lblPerforacion";
            this.lblPerforacion.Size = new System.Drawing.Size(61, 13);
            this.lblPerforacion.TabIndex = 3;
            this.lblPerforacion.Text = "Perforacion";
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(318, 273);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 4;
            this.lblColor.Text = "Color";
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(399, 90);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(100, 20);
            this.tbxNombre.TabIndex = 5;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Mueble",
            "Mesada"});
            this.cbxCategoria.Location = new System.Drawing.Point(399, 134);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(121, 21);
            this.cbxCategoria.TabIndex = 6;
            // 
            // tbxMedida
            // 
            this.tbxMedida.Location = new System.Drawing.Point(399, 175);
            this.tbxMedida.Name = "tbxMedida";
            this.tbxMedida.Size = new System.Drawing.Size(100, 20);
            this.tbxMedida.TabIndex = 7;
            // 
            // cbxPerforacion
            // 
            this.cbxPerforacion.FormattingEnabled = true;
            this.cbxPerforacion.Items.AddRange(new object[] {
            "Tres agujeros",
            "Monocomando",
            "No corresponde"});
            this.cbxPerforacion.Location = new System.Drawing.Point(399, 225);
            this.cbxPerforacion.Name = "cbxPerforacion";
            this.cbxPerforacion.Size = new System.Drawing.Size(121, 21);
            this.cbxPerforacion.TabIndex = 8;
            // 
            // cbxColor
            // 
            this.cbxColor.FormattingEnabled = true;
            this.cbxColor.Items.AddRange(new object[] {
            "Blanco",
            "Wengue"});
            this.cbxColor.Location = new System.Drawing.Point(399, 270);
            this.cbxColor.Name = "cbxColor";
            this.cbxColor.Size = new System.Drawing.Size(121, 21);
            this.cbxColor.TabIndex = 9;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(391, 324);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 23);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbxColor);
            this.Controls.Add(this.cbxPerforacion);
            this.Controls.Add(this.tbxMedida);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.tbxNombre);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.lblPerforacion);
            this.Controls.Add(this.lblMedida);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblNombre);
            this.Name = "Agregar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblPerforacion;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.TextBox tbxMedida;
        private System.Windows.Forms.ComboBox cbxPerforacion;
        private System.Windows.Forms.ComboBox cbxColor;
        private System.Windows.Forms.Button btnAgregar;
    }
}