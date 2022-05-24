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
        bool comidaPedida = false;
        bool bebidaPedida = false;
        StringBuilder pedidosHastaAhora = new StringBuilder();
        Dictionary<int, int> pedidosHasta = new Dictionary<int, int>();

/// <summary>
/// Constructor privado formulario AbrirCuenta
/// </summary>

        private AbrirCuenta()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Constructor de AbrirCuenta con parámetros
        /// </summary>
        /// <param name="nroMesa"></param>
        /// <param name="barActual"></param>
        public AbrirCuenta(int nroMesa, Bar barActual) : this()
        {
            mesaCuenta = barActual.Mesas[nroMesa-1];
            bar = barActual;
            cmbBebidas.DataSource = Enum.GetValues(typeof(EBebidas));
            cmbComidas.DataSource = Enum.GetValues(typeof(EComidas));
            cmbTamano.DataSource = Enum.GetValues(typeof(EVersionBebida));
            pedidosHastaAhora.Append("***PEDIDO***");
            rTxtPedidos.Text = pedidosHastaAhora.ToString();

            if (mesaCuenta.EsBarra)
            {
                chkComidas.Enabled = false;
            }

            cmbComidas.Enabled = false;
            cmbBebidas.Enabled = false;
            cmbTamano.Enabled = false;
            lblCantidadComidas.Enabled = false;
            lblCantidadBebidas.Enabled = false;
            txtCantBebidas.Enabled = false;
            txtCantComidas.Enabled = false;
        }

        /// <summary>
        /// Manejador de boton para agregar el pedido y nombre de cliente a la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombreCliente;
            int index; 
            DialogResult resultado;
            StringBuilder pedidoAux;

            nombreCliente = txtNombre.Text.Trim() + " " + txtApellido.Text.Trim();
            nombreCliente = AcomodarNombre(nombreCliente);

            try
            {
                if (nombreVerificado)
                {

                    pedidoAux = new StringBuilder();
                    pedidoAux.AppendLine("Cliente: " + nombreCliente);
                    pedidoAux.AppendLine(pedidosHastaAhora.ToString());
                    pedidosHastaAhora = pedidoAux;

                    resultado = MessageBox.Show(pedidosHastaAhora.ToString(), "Confirmar Pedido", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

                    if (resultado == DialogResult.Yes)
                    {
                        if (mesaCuenta.Cliente is null)
                        {
                            mesaCuenta.Cliente = new Cliente(mesaCuenta.NumeroMesa,nombreCliente,new Cuenta());
                            mesaCuenta.MesaOcupada = true;
                            MessageBox.Show("Cliente cargado exitosamente!", "Cuenta Cargada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }

                        if (comidaPedida || bebidaPedida)
                        {

                            foreach (KeyValuePair<int, int> pedidoIdCantidad in pedidosHasta)
                            {

                                index = Producto.ObtenerProductoPorId(bar.Inventario, pedidoIdCantidad.Key);

                                if (index >= 0)
                                {
                                    mesaCuenta.Cliente.Cuenta.PedidosList.Add(bar.Inventario[index]);
                                    mesaCuenta.Cliente.Cuenta.PedidosDic.Add(index, pedidoIdCantidad.Value);
                                }

                            }


                        }                  

                    }
                    else
                    {
                        if (resultado == DialogResult.No)
                        {
                            mesaCuenta.Cliente.Nombre = "";
                            mesaCuenta.Cliente.Cuenta.PedidosList.Clear();
                            mesaCuenta.Cliente.Cuenta.PedidosDic.Clear();
                        }
                        else
                        {
                            this.Close();
                        }

                    }
                }
                else
                {
                    throw new NombreApellidoInvalidosExcepcion("Datos ingresados inválidos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           


        }

        /// <summary>
        /// Manejador de boton cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Metodo para poner mayusculas en iniciales y eliminar espacios indeseados en nombre y apellidos ingresados por el usuario
        /// </summary>
        /// <param name="nombreAAcomodar"></param>
        /// <returns></returns>
        public string AcomodarNombre(string nombreAAcomodar)
        {
            string nombreAcomodado = nombreAAcomodar;
            int indexEspacio = -1;

            if (Regex.IsMatch(nombreAcomodado, @"[\w\s\w]"))              
            {
                nombreVerificado = true;
                
                for (int i = 0; i < nombreAcomodado.Length; i++)
                {
                    if (nombreAcomodado[i].Equals(' '))
                    {
                        indexEspacio = i;
                    }
                }

                nombreAcomodado = char.ToUpper(nombreAAcomodar[0]) + nombreAAcomodar.Substring(1, indexEspacio) + char.ToUpper(nombreAAcomodar[indexEspacio + 1]) + nombreAAcomodar.Substring(indexEspacio + 2);
            }
            else
            {
                if (MessageBox.Show("Nombre o Apellido ingresados no válidos, ingrese letras solamente.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
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

        /// <summary>
        /// Manejador cmbComidas que asigna texto segun la bebida seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbComidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBebidas.Text = Enum.GetName(typeof(EBebidas), cmbBebidas.SelectedIndex);
        }

        /// <summary>
        /// Manejador boton AgregarPedido para agregar los pedidos y mostrarlos, luego asignarlos a la cuenta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            Producto comida = new Comida();
            Producto bebida = new Bebida();

            int idProducto = 0;

            try
            {
                pedidosHasta.Clear();
                pedidosHastaAhora.Clear();

                if (!mesaCuenta.EsBarra)
                {
                    if (chkComidas.Checked)
                    {
                        
                        switch(cmbComidas.SelectedIndex)
                        {
                            case 0:
                                idProducto = 15;
                                break;
                            case 1:
                                idProducto = 16;
                                break;
                            default:
                                idProducto = 17;
                                break;
                        }

                        if (idProducto > 0)
                        {
                            comida = bar.Inventario[Producto.ObtenerProductoPorId(bar.Inventario, idProducto)];

                            if (int.TryParse(txtCantComidas.Text, out int cantComidas))
                            {
                                if (cantComidas > 0)
                                {
                                    if (bar.ProductosRestados(comida, cantComidas))
                                    {

                                        this.pedidosHasta.Add(comida.IdProducto, cantComidas);
                                        pedidosHastaAhora.AppendLine(comida.Nombre + "---------X" + cantComidas);

                                        if (comidaPedida == false)
                                        {
                                            idProducto = 0;
                                            comidaPedida = true;
                                        }

                                    }
                                }
                                else
                                {
                                    throw new CeroCantidadExcepcion("Ingrese cantidad válida.");
                                }


                            }
                        }
                        else
                        {
                            throw new SinStockExcepcion("No hay stock de la comida seleccionada. Elija otra comida y/o avise al Administrador.");
                        }

                        

                        

                    }
                }

                if (chkBebidas.Checked)
                {

                    switch (cmbBebidas.SelectedIndex)
                    {
                        case 0:
                            if ((EVersionBebida)cmbTamano.SelectedItem == EVersionBebida.BotellaDosLitros)
                            {
                                idProducto = 11;

                            }
                            else
                            {
                                if ((EVersionBebida)cmbTamano.SelectedItem == EVersionBebida.BotellaLitro)
                                {
                                    idProducto=12;
                                    bebida = bar.Inventario[1];
                                }

                            }                          
                            break;
                        case 1:
                            if ((EVersionBebida)cmbTamano.SelectedItem == EVersionBebida.LataGrande)
                            {
                                idProducto = 13;
                            }
                            break;
                        default:
                            if ((EVersionBebida)cmbTamano.SelectedItem == EVersionBebida.BotellaLitro)
                            {
                                idProducto = 14;
                            }
                            break;
                    }
 
                    if (idProducto > 0)
                    {

                        bebida = bar.Inventario[Producto.ObtenerProductoPorId(bar.Inventario,idProducto)];


                        if (int.TryParse(txtCantBebidas.Text, out int cantBebidas))
                        {
                            if (cantBebidas > 0)
                            {

                                if (bar.ProductosRestados(bebida, cantBebidas))
                                {

                                    this.pedidosHasta.Add(bebida.IdProducto, cantBebidas);
                                    pedidosHastaAhora.AppendLine(bebida.Nombre + "----" + cmbTamano.Text + "-----X" + cantBebidas);
                                
                                    if (bebidaPedida == false)
                                    {
                                        bebidaPedida = true;
                                        idProducto = 0;
                                    }

                                }
                                else
                                {
                                    throw new CeroCantidadExcepcion("Ingrese cantidad correcta.");
                                }
                            }
                        }
                    }
                    else
                    {
                        throw new SinStockExcepcion("No hay stock de la bebida en el tamaño seleccionado. Elija otro tamaño y/o avise al Administrador.");
                    }

                    rTxtPedidos.Text = pedidosHastaAhora.ToString();

                }      

            }           
            catch (SinStockExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Sin Stock", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SobreventaExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Sobreventa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CeroCantidadExcepcion ex)
            {
                MessageBox.Show(ex.Message, "Cantidad inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// Manejador chkComidas que activa o desactiva las etiquetas del formulario pertenecientes a "comidas" segun si esta chequeado o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkComidas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComidas.Checked == true)
            {
                cmbComidas.Enabled = true;
                lblCantidadComidas.Enabled = true;
                txtCantComidas.Enabled = true;
            }
            else
            {
                cmbComidas.Enabled = false;
                lblCantidadComidas.Enabled = false;
                txtCantComidas.Enabled = false;
            }
           
        }

        /// <summary>
        /// Manejador chkBebidas que activa o desactiva las etiquetas del formulario pertenecientes a "bebidas" segun si esta chequeado o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkBebidas_CheckedChanged(object sender, EventArgs e)
        {
           

            if (chkBebidas.Checked == true)
            {
                cmbBebidas.Enabled = true;
                lblCantidadBebidas.Enabled = true;
                txtCantBebidas.Enabled = true;
                cmbTamano.Enabled = true;
            }
            else
            {
                cmbBebidas.Enabled = false;
                lblCantidadBebidas.Enabled = false;
                txtCantBebidas.Enabled = false;
                cmbTamano.Enabled = false;
            }
        }

        /// <summary>
        /// Manejador cmbBebidas que puebla el .Text del cmb con la bebida relacionada con el indice clickeado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbBebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBebidas.Text = Enum.GetName(typeof(EBebidas), cmbBebidas.SelectedIndex);
        }

        /// <summary>
        /// Manejador cmbTamano que puebla el .Text del cmb con la version de bebida relacionada con el indice clickeado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbTamano_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTamano.Text = Enum.GetName(typeof(EVersionBebida), cmbTamano.SelectedIndex);

        }
    }
}
