
namespace Bar_LES_UTN
{
    partial class Stock
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
            this.btnRellenarStock = new System.Windows.Forms.Button();
            this.btnOrdenarStock = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRellenarStock
            // 
            this.btnRellenarStock.Location = new System.Drawing.Point(13, 13);
            this.btnRellenarStock.Name = "btnRellenarStock";
            this.btnRellenarStock.Size = new System.Drawing.Size(254, 23);
            this.btnRellenarStock.TabIndex = 0;
            this.btnRellenarStock.Text = "Rellenar Stock";
            this.btnRellenarStock.UseVisualStyleBackColor = true;
            // 
            // btnOrdenarStock
            // 
            this.btnOrdenarStock.Location = new System.Drawing.Point(13, 43);
            this.btnOrdenarStock.Name = "btnOrdenarStock";
            this.btnOrdenarStock.Size = new System.Drawing.Size(254, 23);
            this.btnOrdenarStock.TabIndex = 1;
            this.btnOrdenarStock.Text = "Ordenar según existencias";
            this.btnOrdenarStock.UseVisualStyleBackColor = true;
            this.btnOrdenarStock.Click += new System.EventHandler(this.btnOrdenarStock_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(13, 73);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(254, 23);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Agregar nuevo producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1052, 607);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.btnOrdenarStock);
            this.Controls.Add(this.btnRellenarStock);
            this.Name = "Stock";
            this.Text = "Bar LES UTN - Jorge Rodrigo Bogado 2D - Stock";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRellenarStock;
        private System.Windows.Forms.Button btnOrdenarStock;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}