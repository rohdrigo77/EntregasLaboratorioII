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
    public partial class VistaPrincipal : Form
    {
        Empleado empleadoLogueado;
        Mesa mesaSeleccionada;
        AbrirCuenta abrirCuenta;
        Dictionary<int, Button> botones;
        Dictionary<int, bool> disponibilidadMesas;
        Bar lesUTN = new Bar();

        private VistaPrincipal()
        {

            InitializeComponent();
            botones = new Dictionary<int, Button>();
            CargarMesas();

        }

        public VistaPrincipal(Empleado empleadoActual) : this()
        {
 
            empleadoLogueado = empleadoActual;
            lblNombreUsuario.Text = empleadoActual.Nombre;

        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {
            ObtenerEstadoMesas();
            btnCobrarMesa.Enabled = false;
        }

        private void CargarMesas()
        {

            botones.Add(1, this.btnMesa1);
            botones.Add(2, this.btnMesa2);
            botones.Add(3, this.btnMesa3);
            botones.Add(4, this.btnMesa4);
            botones.Add(5, this.btnMesa5);
            botones.Add(6, this.btnMesa6);
            botones.Add(7, this.btnMesa7);
            botones.Add(8, this.btnMesa8);
            botones.Add(9, this.btnMesa9);
            botones.Add(10, this.btnMesa10);
            botones.Add(11, this.btnMesa11);
            botones.Add(12, this.btnMesa12);
            botones.Add(13, this.btnMesa13);
            botones.Add(14, this.btnMesa14);
            botones.Add(15, this.btnMesa15);
            botones.Add(16, this.btnMesa16);
            botones.Add(17, this.btnMesa17);
            botones.Add(18, this.btnMesa18);
            botones.Add(19, this.btnMesa19);
            botones.Add(20, this.btnMesa20);

        }

        private void ObtenerEstadoMesas()
        {
            disponibilidadMesas = lesUTN.EstadoMesas();

            foreach (KeyValuePair<int, bool> mesa in disponibilidadMesas)
            {
                if (mesa.Value)
                {
                    botones[mesa.Key].BackColor = Color.Green;
                }                    
                else
                {
                    botones[mesa.Key].BackColor = Color.IndianRed;
                }
            }
        }

        private void InfoMesa(string info)
        {
            lstMesas.DataSource = info;
        }

        private void btnMesaClick(object sender, EventArgs e)
        {

            Button auxBtn = (Button)sender;          

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == auxBtn)
                {
                    mesaSeleccionada = lesUTN.Mesas[item.Key];

                    if (!mesaSeleccionada.MesaOcupada)
                    {
                        if(MessageBox.Show("Esta mesa está libre. /n ¿Desea abrir una cuenta a un cliente nuevo?","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            abrirCuenta = new AbrirCuenta(mesaSeleccionada,lesUTN);
                            abrirCuenta.ShowDialog();
                          
                        }
                        
                    }
                    else
                    {
                        InfoMesa(lesUTN.MostrarInformacionMesa(item.Key));
                        btnCobrarMesa.Enabled = true;
                    }
                }
            }

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnCobrarMesa_Click(object sender, EventArgs e)
        {
            StringBuilder mensaje = new StringBuilder();  

            
            mensaje.Append("Está por cerrar la cuenta de esta mesa. Continuar?");
            mensaje.AppendLine(" ");
            mensaje.AppendLine(mesaSeleccionada.ToString());

            if (MessageBox.Show(mensaje.ToString(), "Cerrar Cuenta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                mesaSeleccionada.Cliente = null;
                mesaSeleccionada.MesaOcupada = false;
            }
        }

        private void btnLiberarMesa_Click(object sender, EventArgs e)
        {

        }

        private void btnStock_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

    }
}
