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
    public partial class Bienvenidx : Form
    {
        Bar barSinLoguear;
        List<string> nombresUsuario = new List<string>();
        public Bienvenidx()
        {
            InitializeComponent();
            barSinLoguear = new Bar();

            foreach (Empleado empleado in barSinLoguear.Empleados)
            {
                nombresUsuario.Add(empleado.Nombre);

            }

            cmbUsuario.DataSource = nombresUsuario;

        }

        /// <summary>
        /// Manejador btnAceptar que verifica datos ingresados y permite o no el logueo de usuarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {

                if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtPass.Text))
                {
                    MessageBox.Show("No ingresó datos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    if (int.TryParse(txtDNI.Text, out int dni) && dni > 0)
                    {
                        Empleado empleadoLogueado = barSinLoguear.LoguearEmpleado(dni, txtPass.Text);
                        if (empleadoLogueado is not null)
                        {
                            VistaPrincipal mp = new VistaPrincipal(empleadoLogueado, barSinLoguear);
                            mp.Show();
                            this.Hide();
                        }                                                     
                    }
                    else
                    {
                        MessageBox.Show("Datos inexistentes o ingresó carácteres inválidos.", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }


            }

        /// <summary>
        /// Manejador btnCancelar que cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Manejador cmbUsuario que modifica los textos 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDNI.Text = (barSinLoguear.Empleados[cmbUsuario.SelectedIndex]).Dni.ToString();
            
            switch ((barSinLoguear.Empleados[cmbUsuario.SelectedIndex]).Dni)
            {
                case 37865167:
                    txtPass.Text = "123456";
                    break;
                case 33112312:
                    txtPass.Text = "ruf123";
                    break;
                case 25097323:
                    txtPass.Text = "MadeINLanus";
                    break;
            }
        }
    }
}
