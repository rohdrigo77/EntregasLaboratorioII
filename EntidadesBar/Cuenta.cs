using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBar
{
    public class Cuenta
    {

        private static int ultimaCuenta;
        private int idCuenta;
        private List<Producto> pedido;
        private Dictionary<int, int> pedidos;
        private bool cuentaCerrada;
        private float costo;

        static Cuenta()
        {
            ultimaCuenta = 0;
        }

        public Cuenta(List<Producto> pedido) : this()
        {
            this.pedido = pedido;
            this.costo = CalcularCosto(pedido);
        }

        public Cuenta()
        {
            cuentaCerrada = false;
            idCuenta = ultimaCuenta;
            pedido = new List<Producto>();
            pedidos = new Dictionary<int, int>();
            ultimaCuenta++;

        }

        private static float CalcularCosto(List<Producto> pedido)
        {

            float costo = 0;
            foreach (Producto item in pedido)
            {
                costo += item.Precio;
            }

            return costo;

        }

        public Dictionary<int, int> PedidosDic
        {

            set
            {
                pedidos = value;   
            }
            get
            {
                return pedidos;
            }

        }

        public List<Producto> PedidosList
        {
            get
            {
                return pedido;
            }
        }


        public bool CuentaCerrada
        {
            set
            {
                cuentaCerrada = value;
            }
            get
            {
                return cuentaCerrada;
            }

        }

        public static int UltimaCuenta
        {
            get
            {
                return ultimaCuenta;
            }
        }

        private string MostrarPedidoYCosto()
        {
            StringBuilder sb = new StringBuilder();
            float costo = CalcularCosto(pedido);

            sb.Append("***Pedido***");
            sb.AppendLine(" ");

            
            foreach (KeyValuePair<int, int> pedidoNombreCantidad in pedidos)
            {
                foreach (Producto p in pedido)
                {
                    if (p.IdProducto == pedidoNombreCantidad.Key)
                    {
                        sb.AppendLine(p.Nombre +"---" + pedidoNombreCantidad.Value);
                    }
                   
                }              
            }

            sb.AppendLine(" ");
            sb.AppendLine("***Total: $ " + costo + "***");

            return sb.ToString();

        }

        public override string ToString()
        {



            return this.MostrarPedidoYCosto();
        }



    }
}
