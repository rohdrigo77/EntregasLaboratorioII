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
        Bar lesUTN;

        private VistaPrincipal()
        {
            InitializeComponent();
            botones = new Dictionary<int, Button>();
            disponibilidadMesas = new Dictionary<int, bool>();
        }

        public VistaPrincipal(Empleado empleadoActual, Bar barLogueado)
        : this()
        {
 
            empleadoLogueado = empleadoActual;
            lblNombreUsuario.Text = empleadoActual.Nombre;
            lesUTN = barLogueado;                    
            CargarMesas();
            ObtenerEstadoMesas();
            btnCobrarMesa.Enabled = false;

            if (empleadoLogueado.Permisos == EPermisos.Administrador)
            {
                lblEmpleadoAdmin.Visible = true;
                this.BackColor = Color.Yellow;
            }
            

        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {

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

        private void InfoMesa(string info)
        {

            rTxtMesas.Text = info;
        }

        private void btnMesaClick(object sender, EventArgs e)
        {
            VerificarBotonYMesa(sender);
                 
        }

        private void VerificarBotonYMesa(object click)
        {           
            Button auxBtn = (Button)click;

            foreach (KeyValuePair<int, Button> item in botones)
            {
                if (item.Value == auxBtn)
                {
                    btnCobrarMesa.Enabled = false;
      
                    if (disponibilidadMesas[item.Key] == false)
                    {
                            
                        if (MessageBox.Show("Esta mesa está libre. ¿Desea abrir una cuenta a un cliente nuevo?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            abrirCuenta = new AbrirCuenta(item.Key, lesUTN);
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

        private void VerificarMesa()
        {
            


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

                if (MessageBox.Show("Cuenta cerrada exitosamente. Desea liberar la mesa?", "Cerrar Cuenta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    mesaSeleccionada.MesaOcupada = false;
                }
            }
        }

        private void btnLiberarMesa_Click(object sender, EventArgs e)
        {
            mesaSeleccionada.MesaOcupada = false;
        }

        private void btnStock_Click(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {

        }

    }
}
