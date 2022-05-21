using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBar
{


    public class Bebida : Producto
    {
        bool tieneAlcohol;
        EVersionBebida formato;


        public Bebida(string nombre, int cantDisp, float precio, bool conAlcohol, EVersionBebida formato)
            : base(nombre, cantDisp, precio)
        {

            this.formato = formato;
            this.tieneAlcohol = conAlcohol;

        }

        protected override int PedirAlProveedor
        {
            set
            {
                this.Existencias += value * 6;
            }
        }

        public override bool ReponerProducto(int cantidad)
        {
            if (this.Existencias < 200 && cantidad > 0)
            {
                PedirAlProveedor = cantidad;
                return true;
            }
            return false;

        }
    }
}
