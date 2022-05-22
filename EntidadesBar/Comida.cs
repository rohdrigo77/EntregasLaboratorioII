using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBar
{
    public enum EIngredientes
    {
        CarneRoja,
        Pollo,
        Tomate,
        Lechuga,
        Papas,
        Sal,
        SalsaPicante,
        Queso,
        Salchicha,
        Harina,
        Aceitunas
    }
    public class Comida : Producto
    {

        List<EIngredientes> ingredientes;

        public Comida()
        :base()
        {

        }

        public Comida(string nombre, int cantDisp, float precio, List<EIngredientes> ingred) : base(nombre, cantDisp, precio)
        {
            this.ingredientes = ingred;

        }

        public override bool ReponerProducto(int cantidad)
        {
            if (cantidad > 0)
            {
                PedirAlProveedor = cantidad;
                return true;
            }
            return false;
        }
        protected override int PedirAlProveedor
        {
            set { Existencias += value; }
        }

        public List<EIngredientes> Ingredientes
        {
            get
            {
                return this.ingredientes;
            }
            set
            {
                ingredientes = value;
            }
        }
    }
}
