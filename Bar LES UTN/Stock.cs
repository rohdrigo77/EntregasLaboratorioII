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
    public partial class Stock : Form
    {
        AgregarProducto agregarProducto;
        List<Producto> listaProductos;
        
        public Stock(List<Producto> inventarioStock, EPermisos permisos)
        {
            InitializeComponent();
            listaProductos=inventarioStock;
            listaProductos.Sort();
            dtgStock.DataSource = listaProductos;
            
            if (!(permisos == EPermisos.Administrador))
            {
                btnAgregarProducto.Enabled = false;
            }
            
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            agregarProducto = new AgregarProducto(listaProductos);
        }



    }
}
