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
        public Bienvenidx()
        {
            InitializeComponent();
            barSinLoguear = new Bar();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
  //          try
    //        {
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
                /*            }
                          catch (Exception ex)
                           {
                               MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           }*/

            }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


       
    }
}
