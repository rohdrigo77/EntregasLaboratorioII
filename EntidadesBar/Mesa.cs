using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesBar
{
    public class Mesa
    {

        private int numeroMesa;
        private Cliente cliente;
        private bool mesaOcupada;

        public Mesa(int numeroMesa, Cliente cliente, bool mesaOcupada)
        {
            this.numeroMesa = numeroMesa;
            this.cliente = cliente;
            this.mesaOcupada = mesaOcupada;
        }

        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int NumeroMesa { get => numeroMesa; }
        public bool EsBarra
        {
            get 
            { 
                return numeroMesa > 15; 
            }
        }

        public override string ToString()
        {
            string tipoMesa = EsBarra ? "Barra" : "Mesa";

            StringBuilder info = new StringBuilder();

            info.AppendLine($"{tipoMesa} N° {this.numeroMesa}");

            if (mesaOcupada == false)
            {
                info.AppendLine("Mesa vacia");
            }
            else
            {
                info.AppendLine($"Mesa ocupada. Cliente: {cliente.Nombre}");
                info.AppendLine(Cliente.Cuenta.ToString());
            }

            return info.ToString();
        }

        public bool MesaOcupada
        {
            set
            {
                this.mesaOcupada = value;
            }
            get 
            {
                return mesaOcupada;
            }
        }

    }
}
