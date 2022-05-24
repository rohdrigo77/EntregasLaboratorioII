namespace Bar_LES_UTN
{
    partial class AgregarProducto
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.grpProducto = new System.Windows.Forms.GroupBox();
            this.lblInstrucciones = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpComida = new System.Windows.Forms.GroupBox();
            this.btnAgregarIngrediente = new System.Windows.Forms.Button();
            this.cmbIngredientes = new System.Windows.Forms.ComboBox();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.chkComida = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbFormato = new System.Windows.Forms.ComboBox();
            this.cmbAlcohol = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.lblAlcohol = new System.Windows.Forms.Label();
            this.chkBebida = new System.Windows.Forms.CheckBox();
            this.rTxtIngredientes = new System.Windows.Forms.RichTextBox();
            this.grpProducto.SuspendLayout();
            this.grpComida.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(2, 64);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(58, 15);
            this.lblCantidad.TabIndex = 1;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(17, 97);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(43, 15);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(66, 22);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 23);
            this.txtNombre.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(66, 56);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(128, 23);
            this.txtCantidad.TabIndex = 4;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(66, 89);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 23);
            this.txtPrecio.TabIndex = 5;
            // 
            // grpProducto
            // 
            this.grpProducto.Controls.Add(this.txtNombre);
            this.grpProducto.Controls.Add(this.txtPrecio);
            this.grpProducto.Controls.Add(this.lblNombre);
            this.grpProducto.Controls.Add(this.lblPrecio);
            this.grpProducto.Controls.Add(this.txtCantidad);
            this.grpProducto.Controls.Add(this.lblCantidad);
            this.grpProducto.ForeColor = System.Drawing.Color.Lime;
            this.grpProducto.Location = new System.Drawing.Point(12, 41);
            this.grpProducto.Name = "grpProducto";
            this.grpProducto.Size = new System.Drawing.Size(213, 125);
            this.grpProducto.TabIndex = 6;
            this.grpProducto.TabStop = false;
            this.grpProducto.Text = "Producto";
            // 
            // lblInstrucciones
            // 
            this.lblInstrucciones.AutoSize = true;
            this.lblInstrucciones.Location = new System.Drawing.Point(12, 9);
            this.lblInstrucciones.Name = "lblInstrucciones";
            this.lblInstrucciones.Size = new System.Drawing.Size(200, 15);
            this.lblInstrucciones.TabIndex = 7;
            this.lblInstrucciones.Text = "Ingrese datos de producto a agregar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(6, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(219, 33);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(231, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(225, 33);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // grpComida
            // 
            this.grpComida.Controls.Add(this.btnAgregarIngrediente);
            this.grpComida.Controls.Add(this.cmbIngredientes);
            this.grpComida.Controls.Add(this.lblIngredientes);
            this.grpComida.Controls.Add(this.chkComida);
            this.grpComida.Location = new System.Drawing.Point(231, 41);
            this.grpComida.Name = "grpComida";
            this.grpComida.Size = new System.Drawing.Size(214, 125);
            this.grpComida.TabIndex = 10;
            this.grpComida.TabStop = false;
            // 
            // btnAgregarIngrediente
            // 
            this.btnAgregarIngrediente.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarIngrediente.Location = new System.Drawing.Point(6, 64);
            this.btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            this.btnAgregarIngrediente.Size = new System.Drawing.Size(201, 48);
            this.btnAgregarIngrediente.TabIndex = 8;
            this.btnAgregarIngrediente.Text = "Agregar Ingrediente";
            this.btnAgregarIngrediente.UseVisualStyleBackColor = true;
            this.btnAgregarIngrediente.Click += new System.EventHandler(this.btnAgregarIngrediente_Click);
            // 
            // cmbIngredientes
            // 
            this.cmbIngredientes.FormattingEnabled = true;
            this.cmbIngredientes.Location = new System.Drawing.Point(87, 30);
            this.cmbIngredientes.Name = "cmbIngredientes";
            this.cmbIngredientes.Size = new System.Drawing.Size(120, 23);
            this.cmbIngredientes.TabIndex = 7;
            this.cmbIngredientes.SelectedIndexChanged += new System.EventHandler(this.cmbIngredientes_SelectedIndexChanged);
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Location = new System.Drawing.Point(6, 38);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(75, 15);
            this.lblIngredientes.TabIndex = 6;
            this.lblIngredientes.Text = "Ingredientes:";
            // 
            // chkComida
            // 
            this.chkComida.AutoSize = true;
            this.chkComida.Location = new System.Drawing.Point(6, 0);
            this.chkComida.Name = "chkComida";
            this.chkComida.Size = new System.Drawing.Size(68, 19);
            this.chkComida.TabIndex = 0;
            this.chkComida.Text = "Comida";
            this.chkComida.UseVisualStyleBackColor = true;
            this.chkComida.CheckedChanged += new System.EventHandler(this.chkComida_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbFormato);
            this.groupBox1.Controls.Add(this.cmbAlcohol);
            this.groupBox1.Controls.Add(this.lblFormato);
            this.groupBox1.Controls.Add(this.lblAlcohol);
            this.groupBox1.Controls.Add(this.chkBebida);
            this.groupBox1.Location = new System.Drawing.Point(12, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 103);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // cmbFormato
            // 
            this.cmbFormato.FormattingEnabled = true;
            this.cmbFormato.Location = new System.Drawing.Point(67, 53);
            this.cmbFormato.Name = "cmbFormato";
            this.cmbFormato.Size = new System.Drawing.Size(127, 23);
            this.cmbFormato.TabIndex = 9;
            this.cmbFormato.SelectedIndexChanged += new System.EventHandler(this.cmbFormato_SelectedIndexChanged);
            // 
            // cmbAlcohol
            // 
            this.cmbAlcohol.FormattingEnabled = true;
            this.cmbAlcohol.Location = new System.Drawing.Point(87, 20);
            this.cmbAlcohol.Name = "cmbAlcohol";
            this.cmbAlcohol.Size = new System.Drawing.Size(107, 23);
            this.cmbAlcohol.TabIndex = 8;
            this.cmbAlcohol.SelectedIndexChanged += new System.EventHandler(this.cmbAlcohol_SelectedIndexChanged);
            // 
            // lblFormato
            // 
            this.lblFormato.AutoSize = true;
            this.lblFormato.Location = new System.Drawing.Point(6, 61);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(55, 15);
            this.lblFormato.TabIndex = 7;
            this.lblFormato.Text = "Formato:";
            // 
            // lblAlcohol
            // 
            this.lblAlcohol.AutoSize = true;
            this.lblAlcohol.Location = new System.Drawing.Point(6, 28);
            this.lblAlcohol.Name = "lblAlcohol";
            this.lblAlcohol.Size = new System.Drawing.Size(80, 15);
            this.lblAlcohol.TabIndex = 6;
            this.lblAlcohol.Text = "Tiene alcohol:";
            // 
            // chkBebida
            // 
            this.chkBebida.AutoSize = true;
            this.chkBebida.Location = new System.Drawing.Point(6, 0);
            this.chkBebida.Name = "chkBebida";
            this.chkBebida.Size = new System.Drawing.Size(62, 19);
            this.chkBebida.TabIndex = 0;
            this.chkBebida.Text = "Bebida";
            this.chkBebida.UseVisualStyleBackColor = true;
            this.chkBebida.CheckedChanged += new System.EventHandler(this.chkBebida_CheckedChanged);
            // 
            // rTxtIngredientes
            // 
            this.rTxtIngredientes.Location = new System.Drawing.Point(231, 179);
            this.rTxtIngredientes.Name = "rTxtIngredientes";
            this.rTxtIngredientes.Size = new System.Drawing.Size(214, 96);
            this.rTxtIngredientes.TabIndex = 12;
            this.rTxtIngredientes.Text = "";
            this.rTxtIngredientes.TextChanged += new System.EventHandler(this.rTxtIngredientes_TextChanged);
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(459, 329);
            this.Controls.Add(this.rTxtIngredientes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpComida);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblInstrucciones);
            this.Controls.Add(this.grpProducto);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "AgregarProducto";
            this.Text = "Bar LES UTN - Jorge Rodrigo Bogado 2D - Agregar Producto";
            this.grpProducto.ResumeLayout(false);
            this.grpProducto.PerformLayout();
            this.grpComida.ResumeLayout(false);
            this.grpComida.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox grpProducto;
        private System.Windows.Forms.Label lblInstrucciones;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox grpComida;
        private System.Windows.Forms.CheckBox chkComida;
        private System.Windows.Forms.ComboBox cmbIngredientes;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAlcohol;
        private System.Windows.Forms.CheckBox chkBebida;
        private System.Windows.Forms.Button btnAgregarIngrediente;
        private System.Windows.Forms.ComboBox cmbFormato;
        private System.Windows.Forms.ComboBox cmbAlcohol;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.RichTextBox rTxtIngredientes;
    }
}