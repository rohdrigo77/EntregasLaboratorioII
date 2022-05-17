
namespace Bar_LES_UTN
{
    partial class AbrirCuenta
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.cmbComidas = new System.Windows.Forms.ComboBox();
            this.lblCantidadComidas = new System.Windows.Forms.Label();
            this.txtCantComidas = new System.Windows.Forms.TextBox();
            this.cmbBebidas = new System.Windows.Forms.ComboBox();
            this.lblCantidadBebidas = new System.Windows.Forms.Label();
            this.txtCantBebidas = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lstPedidos = new System.Windows.Forms.ListBox();
            this.btnAgregarPedido = new System.Windows.Forms.Button();
            this.chkComidas = new System.Windows.Forms.CheckBox();
            this.chkBebidas = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 53);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(88, 45);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(681, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(88, 71);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(681, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(12, 9);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(146, 15);
            this.lblMensaje.TabIndex = 4;
            this.lblMensaje.Text = "Ingresar pedido de cliente:";
            // 
            // cmbComidas
            // 
            this.cmbComidas.FormattingEnabled = true;
            this.cmbComidas.Location = new System.Drawing.Point(88, 100);
            this.cmbComidas.Name = "cmbComidas";
            this.cmbComidas.Size = new System.Drawing.Size(577, 23);
            this.cmbComidas.TabIndex = 6;
            this.cmbComidas.SelectedIndexChanged += new System.EventHandler(this.cmbComidas_SelectedIndexChanged);
            // 
            // lblCantidadComidas
            // 
            this.lblCantidadComidas.AutoSize = true;
            this.lblCantidadComidas.Location = new System.Drawing.Point(667, 108);
            this.lblCantidadComidas.Name = "lblCantidadComidas";
            this.lblCantidadComidas.Size = new System.Drawing.Size(58, 15);
            this.lblCantidadComidas.TabIndex = 8;
            this.lblCantidadComidas.Text = "Cantidad:";
            // 
            // txtCantComidas
            // 
            this.txtCantComidas.Location = new System.Drawing.Point(729, 100);
            this.txtCantComidas.Name = "txtCantComidas";
            this.txtCantComidas.Size = new System.Drawing.Size(40, 23);
            this.txtCantComidas.TabIndex = 9;
            // 
            // cmbBebidas
            // 
            this.cmbBebidas.FormattingEnabled = true;
            this.cmbBebidas.Location = new System.Drawing.Point(88, 129);
            this.cmbBebidas.Name = "cmbBebidas";
            this.cmbBebidas.Size = new System.Drawing.Size(577, 23);
            this.cmbBebidas.TabIndex = 10;
            // 
            // lblCantidadBebidas
            // 
            this.lblCantidadBebidas.AutoSize = true;
            this.lblCantidadBebidas.Location = new System.Drawing.Point(667, 137);
            this.lblCantidadBebidas.Name = "lblCantidadBebidas";
            this.lblCantidadBebidas.Size = new System.Drawing.Size(58, 15);
            this.lblCantidadBebidas.TabIndex = 11;
            this.lblCantidadBebidas.Text = "Cantidad:";
            // 
            // txtCantBebidas
            // 
            this.txtCantBebidas.Location = new System.Drawing.Point(729, 129);
            this.txtCantBebidas.Name = "txtCantBebidas";
            this.txtCantBebidas.Size = new System.Drawing.Size(40, 23);
            this.txtCantBebidas.TabIndex = 12;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(12, 442);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(375, 42);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar Cuenta";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(393, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(378, 42);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lstPedidos
            // 
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.ItemHeight = 15;
            this.lstPedidos.Location = new System.Drawing.Point(12, 201);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(757, 229);
            this.lstPedidos.TabIndex = 15;
            // 
            // btnAgregarPedido
            // 
            this.btnAgregarPedido.Location = new System.Drawing.Point(12, 158);
            this.btnAgregarPedido.Name = "btnAgregarPedido";
            this.btnAgregarPedido.Size = new System.Drawing.Size(757, 37);
            this.btnAgregarPedido.TabIndex = 16;
            this.btnAgregarPedido.Text = "Agregar pedido";
            this.btnAgregarPedido.UseVisualStyleBackColor = true;
            this.btnAgregarPedido.Click += new System.EventHandler(this.btnAgregarPedido_Click);
            // 
            // chkComidas
            // 
            this.chkComidas.AutoSize = true;
            this.chkComidas.Location = new System.Drawing.Point(12, 108);
            this.chkComidas.Name = "chkComidas";
            this.chkComidas.Size = new System.Drawing.Size(76, 19);
            this.chkComidas.TabIndex = 17;
            this.chkComidas.Text = "Comidas:";
            this.chkComidas.UseVisualStyleBackColor = true;
            this.chkComidas.CheckedChanged += new System.EventHandler(this.chkComidas_CheckedChanged);
            // 
            // chkBebidas
            // 
            this.chkBebidas.AutoSize = true;
            this.chkBebidas.Location = new System.Drawing.Point(12, 133);
            this.chkBebidas.Name = "chkBebidas";
            this.chkBebidas.Size = new System.Drawing.Size(70, 19);
            this.chkBebidas.TabIndex = 18;
            this.chkBebidas.Text = "Bebidas:";
            this.chkBebidas.UseVisualStyleBackColor = true;
            this.chkBebidas.CheckedChanged += new System.EventHandler(this.chkBebidas_CheckedChanged);
            // 
            // AbrirCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 496);
            this.Controls.Add(this.chkBebidas);
            this.Controls.Add(this.chkComidas);
            this.Controls.Add(this.btnAgregarPedido);
            this.Controls.Add(this.lstPedidos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtCantBebidas);
            this.Controls.Add(this.lblCantidadBebidas);
            this.Controls.Add(this.cmbBebidas);
            this.Controls.Add(this.txtCantComidas);
            this.Controls.Add(this.lblCantidadComidas);
            this.Controls.Add(this.cmbComidas);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "AbrirCuenta";
            this.Text = "Abrir Cuenta";
            this.Load += new System.EventHandler(this.AbrirCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ComboBox cmbComidas;
        private System.Windows.Forms.Label lblCantidadComidas;
        private System.Windows.Forms.TextBox txtCantComidas;
        private System.Windows.Forms.ComboBox cmbBebidas;
        private System.Windows.Forms.Label lblCantidadBebidas;
        private System.Windows.Forms.TextBox txtCantBebidas;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.Button btnAgregarPedido;
        private System.Windows.Forms.CheckBox chkComidas;
        private System.Windows.Forms.CheckBox chkBebidas;
    }
}