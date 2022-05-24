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

namespace Bar_LES_UTN
{
    public partial class AgregarProducto : Form
    {
        List<Producto> stock;
        StringBuilder ingredientesTotales;

        /// <summary>
        /// Constructor de AgregarProducto que recibe una lista de productos que sería el inventario del bar
        /// </summary>
        /// <param name="inventario"></param>
        public AgregarProducto(List<Producto> inventario)
        {
            InitializeComponent();
            stock = inventario;
            ingredientesTotales = new StringBuilder();
            cmbIngredientes.DataSource = Enum.GetValues(typeof(EIngredientes));
            cmbFormato.DataSource = Enum.GetValues(typeof(EVersionBebida));
        }

        /// <summary>
        /// Manejador de cmbAlcohol para indicar si la bebida tiene alcohol o no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbAlcohol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFormato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        { }/*
            Producto comida = new Comida();
            Producto bebida = new Bebida();        

            try
            {
                
                ingredientesTotales.Clear();

                if (chkComida.Checked)
                {

                    cmbIngredientes.Enabled = true;

                   
                        comida.Nombre = 

                        if (int.TryParse(txtCantComida.Text, out int cantComidas))
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
                        else
                        {
                            throw new SinStockExcepcion("No hay stock de la comida seleccionada. Elija otra comida y/o avise al Administrador.");
                        }





                }
                

                if (chkBebida.Checked)
                {

                    switch (cmbBebida.SelectedIndex)
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
                                    idProducto = 12;
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

                        bebida = bar.Inventario[Producto.ObtenerProductoPorId(bar.Inventario, idProducto)];


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
        }*/

            private void cmbIngredientes_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void chkComida_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void chkBebida_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {

            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {

            }

            private void rTxtIngredientes_TextChanged(object sender, EventArgs e)
            {

            }
        
    }
}
