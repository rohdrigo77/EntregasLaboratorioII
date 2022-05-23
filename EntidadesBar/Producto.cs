using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesBar
{
    public abstract class Producto
    {
        static int lastId;
        protected int idProducto;
        protected string nombre;
        protected int existencias;
        private float precio;


        static Producto()
        {
            lastId = 1;
        }

        public Producto()
        {

        }

        protected Producto(string nombre, int existencias, float precio)
        {
            this.idProducto = lastId;
            this.nombre = nombre;
            this.existencias = existencias;
            this.precio = precio;

            lastId++;
        }

        protected abstract int PedirAlProveedor
        {
            set;
        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public float Precio 
        {
            get
            {
                return precio;
            }
        }

        public abstract bool ReponerProducto(int cantidad);

        public bool RestarProductos(int cantidadARestar)
        {
            bool productoRestado = false; 

            if ((this.Existencias - cantidadARestar) >= 0)
            {
                this.Existencias -= cantidadARestar;

                if (this.Existencias == 0)
                {
                    throw new SinStockExcepcion("Se ha quedado sin productos " + this.Nombre.Trim() + ". Avise a su Administrador.");
                }

                productoRestado = true;

            }
            else
            {
                throw new SobreventaExcepcion("No hay suficiente stock para satisfacer el pedido. Elija una cantidad menor o hable con Administración.");
            }

            return productoRestado;
        }

        public static bool operator == (Producto p1, int id)
        {
            return p1.idProducto == id;
        }

        public static bool operator != (Producto p1, int id)
        {
            return !(p1 == id);
        }

        public static Producto BuscarProducto(List<Producto> lista, int id)
        {
            foreach (Producto item in lista)
            {
                if (item == id)
                {
                    return item;
                }
            }
                

            return null;
        }

        public static List<Producto> DevolverProductos(List<Producto> lista, Type tipoProducto)
        {
            List<Producto> aux = new List<Producto>();

            foreach (Producto item in lista)
            {
                if (item.GetType() == tipoProducto)
                {
                    aux.Add(item);

                }
            }
            return aux;
        }

        public static List<Producto> DevolverProductos(List<Producto> lista, string nombre)
        {
            List<Producto> aux = new List<Producto>();

            foreach (Producto item in lista)
            {
                if (item.nombre.ToLower().Trim().Contains(nombre.Trim().ToLower()))
                {
                    aux.Add(item);
                }
            }

            return aux;
        }


        public int IdProducto
        {
            get
            {
                return idProducto;
            }
        }

        public int Existencias
        {
            set
            {
                this.existencias = value;
            }
            get
            {
                return this.existencias;
            }
        }



    }
}
