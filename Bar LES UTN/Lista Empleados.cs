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
    /// <summary>
    /// 
    /// </summary>
    public partial class Lista_Empleados : Form
    {
        /// <summary>
        /// Constructor Lista_Empleados
        /// </summary>
        /// <param name="Empleados"></param>
        public Lista_Empleados(List<Empleado> Empleados)
        {
            InitializeComponent();
        }

        /// <summary>
        /// Manejador btnCerrar que cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
           this.Close(); 
        }


    }
}
