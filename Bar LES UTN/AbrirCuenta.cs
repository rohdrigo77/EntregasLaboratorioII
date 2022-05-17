using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesBar;
using System.Text.RegularExpressions;
using Excepciones;


namespace Bar_LES_UTN
{
    public partial class AbrirCuenta : Form
    {
        Bar bar;
        Mesa mesaCuenta;
        bool nombreVerificado = false;
        bool pedidoRealizado = false;
        StringBuilder pedidosHastaAhora = new StringBuilder();

        private AbrirCuenta()
        {
            InitializeComponent();
        }

        public AbrirCuenta(Mesa mesaSeleccionada, Bar barActual) : this()
        {
            mesaCuenta = mesaSeleccionada;
            bar = barActual;
        }

        private void AbrirCuenta_Load(object sender, EventArgs e)
        {
            cmbComidas.DataSource = bar.Comidas;
            cmbBebidas.DataSource = bar.Bebidas;
            pedidosHastaAhora.Clear();
            pedidosHastaAhora.Append("***PEDIDO***");
            lstPedidos.DataSource = pedidosHastaAhora;
            
            if (mesaCuenta.EsBarra)
            {
                chkComidas.Enabled = false;  
            }

            cmbComidas.Enabled = false;
            cmbBebidas.Enabled = false;
            lblCantidadComidas.Enabled = false;
            lblCantidadBebidas.Enabled = false;
            txtCantBebidas.Enabled = false;
            txtCantComidas.Enabled = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreCliente;

            nombreCliente = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim();

            nombreCliente = AcomodarNombre(nombreCliente, nombreVerificado);

            if (nombreVerificado && pedidoRealizado)
            {

            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        public string AcomodarNombre(string nombreAAcomodar, bool cuentaAgregada)
        {
            string nombreAcomodado = nombreAAcomodar;

            if (Regex.IsMatch(nombreAcomodado, "[^a-zA-Z0-9\x20]"))
            {
                for (int i = 0; i < nombreAAcomodar.Length; i++)
                {
                    if (i == 0 || nombreAAcomodar[i - 1].Equals(' '))
                    {
                        char.ToUpper(nombreAAcomodar[i]);
                    }
                    else if (!nombreAAcomodar[i].Equals(' '))
                    {
                        char.ToLower(nombreAAcomodar[i]);
                    }
                }
            }
            else
            {
                if(MessageBox.Show("Nombre o Apellido ingresados no válidos, ingrese letras solamente.", "Error", MessageBoxButtons.OKCancel,MessageBoxIcon.Error) == DialogResult.OK)
                {
                    txtNombre.Text = "";
                    txtApellido.Text = "";
                }
                else
                {
                    this.Close();
                }
            }
            

            return nombreAcomodado;
        }

        private void cmbComidas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {        

                if(!mesaCuenta.EsBarra)
                {
                    if (chkComidas.Checked)

                        if (int.TryParse(txtCantComidas.Text, out int cantComidas))
                        {
                            try
                            {
                                if (bar.ProductosRestados((Comida)cmbComidas.SelectedItem, cantComidas))
                                {

                                    mesaCuenta.Cliente.Cuenta.Pedidos.Add((Comida)cmbComidas.SelectedValue);
                                    mesaCuenta.Cliente.Cuenta.Pedidos.Last<Producto>().Existencias = cantComidas;
                                    pedidosHastaAhora.AppendLine(((Comida)cmbComidas.SelectedValue).Nombre + "---------X" + cantComidas);

                                }
                            }
                            catch (SinStockExcepcion ex)
                            {
                                MessageBox.Show(ex.Message, "Sin Stock",MessageBoxButtons.OK,MessageBoxIcon.Exclamation); 
                            }
                            catch (SobreventaExcepcion ex)
                            {
                                MessageBox.Show(ex.Message, "Sobreventa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                }

                if (chkBebidas.Checked)
                {
                    if (int.TryParse(txtCantBebidas.Text, out int cantBebidas))
                    {

                        if (bar.ProductosRestados((Bebida)cmbBebidas.SelectedItem, cantBebidas))
                        {

                            mesaCuenta.Cliente.Cuenta.Pedidos.Add((Bebida)cmbBebidas.SelectedValue);
                            mesaCuenta.Cliente.Cuenta.Pedidos.Last<Producto>().Existencias = cantBebidas;
                            pedidosHastaAhora.AppendLine(((Bebida)cmbBebidas.SelectedValue).Nombre + "---------X" + cantBebidas);

                        }
                    }
                }

        }

        private void chkComidas_CheckedChanged(object sender, EventArgs e)
        {
            cmbComidas.Enabled = true;
            lblCantidadComidas.Enabled = true;
            txtCantComidas.Enabled = true;
        }

        private void chkBebidas_CheckedChanged(object sender, EventArgs e)
        {
            cmbBebidas.Enabled = true;
            lblCantidadBebidas.Enabled = true;
            txtCantBebidas.Enabled = true;
        }
    }
}
