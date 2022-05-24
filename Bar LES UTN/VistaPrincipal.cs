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
        Lista_Empleados empleados;
        Stock stock;
        Dictionary<int, Button> botones;
        Dictionary<int, bool> disponibilidadMesas;
        Bar lesUTN;
        EventArgs argsMesaClick;
        bool cuentaCerrada=false;

        /// <summary>
        /// Constructor VistaPrincipal
        /// </summary>
        private VistaPrincipal()
        {
            InitializeComponent();
            botones = new Dictionary<int, Button>();
            disponibilidadMesas = new Dictionary<int, bool>();
            btnCobrarYLiberarMesa.Enabled = false;
            btnEmpleados.Enabled = false;

        }

        /// <summary>
        /// Constructor VistaPrincipal que recibe el empleado logueado y el bar
        /// </summary>
        /// <param name="empleadoActual"></param>
        /// <param name="barLogueado"></param>
        public VistaPrincipal(Empleado empleadoActual, Bar barLogueado)
        : this()
        {

            empleadoLogueado = empleadoActual;
            lblNombreUsuario.Text = empleadoActual.Nombre;
            lesUTN = barLogueado;
            CargarMesas();
            ObtenerEstadoMesas();
            
            if (empleadoLogueado.Permisos == EPermisos.Administrador)
            {
                lblEmpleadoAdmin.Visible = true;
                this.BackColor = Color.Yellow;
                btnEmpleados.Enabled = true;
            }

        }



        /// <summary>
        /// Agrega al diccionario de botones los pares de clave valor segun numero de boton y el boton presionado
        /// </summary>
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

        /// <summary>
        /// Metodo que puebla el diccionario de disponibilidadMesas segun el numero de mesa y si esta o no ocupada, y modifica el color de los botones segun los datos anteriores
        /// </summary>
        private void ObtenerEstadoMesas()
        {
            disponibilidadMesas.Clear();

            for (int i = 1; i <= this.lesUTN.Mesas.Length; i++)
            {
                disponibilidadMesas.Add(i, this.lesUTN.Mesas[i - 1].MesaOcupada);
            }

            foreach (KeyValuePair<int, bool> mesa in disponibilidadMesas)
            {
                if (mesa.Value)
                {
                    botones[mesa.Key].BackColor = Color.IndianRed;

                }
                else
                {
                    botones[mesa.Key].BackColor = Color.Green;
                }
            }
        }

        /// <summary>
        ///  Metodo que puebla rTxtMesas.Text segun el string recibido
        /// </summary>
        /// <param name="info"></param>
        private void InfoMesa(string info)
        { 
            rTxtMesas.Text = info;
        }

        /// <summary>
        /// Manejador btnMesaClick que habilita botones segun booleano y muestra el estado de la mesa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMesaClick(object sender, EventArgs e)
        {
            argsMesaClick = e;

            if (cuentaCerrada==false)
            {
                btnCobrarYLiberarMesa.Enabled = false;
            }
           
            VerificarBotonYMesa(sender);

        }

        /// <summary>
        /// Metodo que Verifica el objeto presionado
        /// </summary>
        /// <param name="click"></param>
        private void VerificarBotonYMesa(object click)
        {
            Button auxBtn = (Button)click;

            VerificarBoton(auxBtn);            
        }

        /// <summary>
        /// Metodo que Verifica el boton presionado y la mesa relacionada
        /// </summary>
        /// <param name="boton"></param>
        private void VerificarBoton(Button boton)
        {
            ObtenerEstadoMesas();

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == boton)
                {

                    mesaSeleccionada = lesUTN.Mesas[item.Key - 1];           
                    break;
                }
            }

            VerificarMesa();
        }

        /// <summary>
        /// Metodo que verifica si la mesa esta ocupada o no y actua en consecuencia, permitiendo abrir una nueva cuenta, o mostrando los datos de la ya creada
        /// </summary>
        private void VerificarMesa()
        {

            if (mesaSeleccionada.MesaOcupada == false)
            {                   

                if (MessageBox.Show("¿Desea abrir una cuenta a un cliente nuevo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    abrirCuenta = new AbrirCuenta(mesaSeleccionada.NumeroMesa, lesUTN);
                    abrirCuenta.ShowDialog();
                    disponibilidadMesas[mesaSeleccionada.NumeroMesa] = mesaSeleccionada.MesaOcupada;
                                           
                }          
                                                       
            }
            else
            {
                btnCobrarYLiberarMesa.Enabled = true;
                InfoMesa(lesUTN.MostrarInformacionMesa(mesaSeleccionada.NumeroMesa));
            }

            ObtenerEstadoMesas();

        }

        /// <summary>
        /// 
        /// </summary>
        private void CobrarMesa()
        {
            StringBuilder mensaje = new StringBuilder();


            mensaje.Append("Está por cerrar la cuenta de esta mesa. Continuar?");
            mensaje.AppendLine(" ");
            mensaje.AppendLine(mesaSeleccionada.ToString());

            if (MessageBox.Show(mensaje.ToString(), "Cerrar Cuenta", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                cuentaCerrada = true;
                mesaSeleccionada.Cliente.Cuenta.CuentaCerrada = true;
                mesaSeleccionada.MesaOcupada = false;
                LiberarMesa();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCobrarYLiberarMesa_Click(object sender, EventArgs e)
        {
            LiberarMesa();
        }

        /// <summary>
        /// 
        /// </summary>
        private void LiberarMesa()
        {
            if (cuentaCerrada == false)
            {

                CobrarMesa();
                mesaSeleccionada.MesaOcupada = false;               
                ObtenerEstadoMesas();
                InfoMesa(lesUTN.MostrarInformacionMesa(mesaSeleccionada.NumeroMesa)); 
                btnCobrarYLiberarMesa.Enabled = false;

            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStock_Click(object sender, EventArgs e)
        {
            stock = new Stock(lesUTN.Inventario ,empleadoLogueado.Permisos);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEmpleados_Click(object sender, EventArgs e)
        { 
            empleados = new Lista_Empleados(lesUTN.Empleados);
            empleados.Show();
            
        }

    }
}
