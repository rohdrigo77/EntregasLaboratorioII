using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesBar
{
    public class Bar
    {

        private List<Empleado> listaEmpleados;
        private List<Producto> inventario;
        private Mesa[] mesas;
        List<Producto> bebidas;
        List<Producto> comidas;

        public Bar()
        {
            bebidas = new List<Producto>();
            comidas = new List<Producto>();
            InstanciarMesas();
            InstanciarProductos();
            InstanciarEmpleados();
           
        }

        public Mesa[] Mesas
        {

            get 
            { 
                return mesas; 
            }
        }
        private void InstanciarMesas()
        {
            mesas = new Mesa[20]
            {
              new Mesa(1,new Cliente(numMesa: 1,
                                     nombre: "Juan",
                                     new Cuenta(new List<Producto>(){
                              new Comida(nombre:"Hambur Completa",cantDisp:20,precio:600,
                                        new List<EIngredientes>(){EIngredientes.CarneRoja,EIngredientes.Lechuga,EIngredientes.Queso,EIngredientes.Tomate}),

                              new Comida(nombre:"Entradadita",cantDisp:200,precio:300,
                                        new List<EIngredientes>(){ EIngredientes.Aceitunas,EIngredientes.Queso,EIngredientes.Papas,EIngredientes.Salchicha}),
                               new Bebida(nombre:"Coca Cola",cantDisp:101,precio: 350,conAlcohol: false,formato: EVersionBebida.BotellaLitro),
                                new Bebida(nombre:"Coca Cola",cantDisp:101,precio: 350,conAlcohol: false,formato: EVersionBebida.BotellaLitro)
                    }
                    )),true),

                new Mesa(2,new Cliente(2,"Margarita",
                    new Cuenta(new List<Producto>(){
                              new Comida(nombre:"Hambur Completa",cantDisp:20,precio:600,
                                        new List<EIngredientes>(){EIngredientes.CarneRoja,EIngredientes.Lechuga,EIngredientes.Queso,EIngredientes.Tomate}),

                              new Comida(nombre:"Entradadita",cantDisp:200,precio:300,
                                        new List<EIngredientes>(){ EIngredientes.Aceitunas,EIngredientes.Queso,EIngredientes.Papas,EIngredientes.Salchicha}),
                               new Bebida(nombre:"Coca Cola",cantDisp:101,precio: 350,conAlcohol: false,formato: EVersionBebida.BotellaLitro),
                                new Bebida(nombre:"Coca Cola",cantDisp:101,precio: 350,conAlcohol: false,formato: EVersionBebida.BotellaLitro)
                    }
                    )),true),

              new Mesa(3,null,false),
              new Mesa(4,null,false),
              new Mesa(5,null,false),
              new Mesa(6,null,false),
              new Mesa(7,null,false),
              new Mesa(8,null,false),
              new Mesa(9,null, false),
              new Mesa(10,null, false),
              new Mesa(11,null, false),
              new Mesa(12,null, false),
              new Mesa(13,null, false),
              new Mesa(14,null, false),
              new Mesa(15,null, false),
              new Mesa(16,null, false),
              new Mesa(17,null, false),
              new Mesa(18,null, false),
              new Mesa(19,new Cliente(1,"Juan",new Cuenta(new List<Producto>(){new Bebida(nombre:"Andes",cantDisp:10,precio: 340,conAlcohol: true,formato: EVersionBebida.BotellaLitro)})),true),
              new Mesa(20,null,false),

            };

           
            foreach (Mesa m in mesas)
            {
                if (m.MesaOcupada == true)
                {
                    foreach (Producto p in m.Cliente.Cuenta.PedidosList)
                    {
                        m.Cliente.Cuenta.PedidosDic.Add(p.IdProducto,1);
                    }
                            
                }
            }

        }
        private void InstanciarEmpleados()
        {
            listaEmpleados = new List<Empleado>()
            {
                new Empleado(33112312,"Pepe Peposo","ruf123",EPermisos.Empleado),
                new Empleado(25097323,"Juana RoyalCanin","MadeINLanus",EPermisos.Empleado),
                new Empleado(37865167,"Jorge Rodrigo Bogado","123456",EPermisos.Administrador),

            };
        }
        private void InstanciarProductos()
        {
            this.inventario = new List<Producto>()
            {
              new Bebida(nombre:"Coca Cola",cantDisp:95,precio: 450,conAlcohol: false,formato: EVersionBebida.BotellaDosLitros),
              new Bebida(nombre:"Coca Cola",cantDisp:101,precio: 350,conAlcohol: false,formato: EVersionBebida.BotellaLitro),
              new Bebida(nombre:"Brahma",cantDisp:500,precio: 270,conAlcohol: true,formato: EVersionBebida.LataGrande),
              new Bebida(nombre:"Andes",cantDisp:10,precio: 340,conAlcohol: true,formato: EVersionBebida.BotellaLitro),

              new Comida(nombre:"Hambur Completa",cantDisp:20,precio:600,new List<EIngredientes>(){ EIngredientes.CarneRoja,EIngredientes.Lechuga,EIngredientes.Queso,EIngredientes.Tomate}),
              new Comida(nombre:"Hambur Suprema",cantDisp:21,precio:580,new List<EIngredientes>(){ EIngredientes.Pollo,EIngredientes.Lechuga,EIngredientes.Queso,EIngredientes.Tomate}),
              new Comida(nombre:"Entradadita",cantDisp:200,precio:300,new List<EIngredientes>(){ EIngredientes.Aceitunas,EIngredientes.Queso,EIngredientes.Papas,EIngredientes.Salchicha})
            };

        }

        public Empleado LoguearEmpleado(int idUser, string contrasena)
        {
            Empleado empleado = new Empleado();

            foreach (Empleado e in this.listaEmpleados)
            {
                if (e.Dni == idUser && e.VerificarContrasena(contrasena))
                {
                    empleado = e;

                }
            }

            return empleado;
        }



       

        public string MostrarInformacionMesa(int idMesa)
        {
            Mesa auxMesa = null;

            foreach (Mesa item in mesas)
            {
                if (item.NumeroMesa == idMesa)
                    auxMesa = item;
            }

            if (auxMesa is null)
                return "mesa no encontrada";

            return auxMesa.ToString();
        }

        public List<Producto> Inventario
        {

            get
            {
                return this.inventario;
            }

        }

       public bool ProductosRestados(Producto producto, int numeroARestar)
       {

            bool productoRestado = false;

            foreach (Producto p in inventario)
            {
                if (p == producto)
                {
                    productoRestado = p.RestarProductos(numeroARestar);
                }
                
            }

            return productoRestado;
       }

        public List<Producto> Bebidas
        {

            get
            {

                bebidas.Clear();
                foreach (Producto p in inventario)
                {
                    if (p is Bebida)
                    {
                        bebidas.Add(p);

                    }
                }

                return bebidas;
            }
        }

        public List<Producto> Comidas
        {

            get
            {

                comidas.Clear();
                foreach (Producto p in inventario)
                {
                    if (p is Comida)
                    {
                        bebidas.Add(p);

                    }
                }

                return comidas;
            }
        }
    }
}
