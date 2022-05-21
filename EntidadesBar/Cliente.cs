using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBar
{
    public class Cliente
    {
        int idCliente;
        string nombre;
        Cuenta cuenta;


        public Cliente(int numMesa, string nombre, Cuenta cuenta)
        {
            this.idCliente = numMesa;
            this.nombre = nombre;
            this.cuenta = cuenta;
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

        public Cuenta Cuenta

        {
            set
            {
                if (value != null)
                {
                    cuenta = value;
                }
            }
            get
            {
                return cuenta;
            }
        }

       
    }
}
