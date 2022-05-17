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
        public Bienvenidx()
        {
            InitializeComponent();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtPass.Text))
                MessageBox.Show("Ingrese datos validos");
            else
            {
                if (int.TryParse(txtDNI.Text, out int dni))
                {
                    Empleado userLogueado = Bar.LoguearEmpleado(dni, txtPass.Text);

                    if (userLogueado is not null)
                    {
                        VistaPrincipal mp = new VistaPrincipal(userLogueado);
                        mp.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            this.txtDNI.Text = "33112312";
            this.txt_pass.Text = "ruf123";
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            this.txtDNI.Text = "25097323";
            this.txt_pass.Text = "MadeINLanus";

            this.comboBox1.DataSource = null;
            this.comboBox1.DataSource = new List<string>() { "pepe", "juan", "margin" };

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.comboBox1.DataSource = new List<string>() { "pepe", "juan" };
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
