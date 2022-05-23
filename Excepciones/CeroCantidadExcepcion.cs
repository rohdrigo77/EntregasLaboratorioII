using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class CeroCantidadExcepcion : Exception
    {
        public CeroCantidadExcepcion()
        : base()
        {

        }

        public CeroCantidadExcepcion(string message)
       : base(message)
        {

        }

        public CeroCantidadExcepcion(string message, Exception innerException)
       : base(message,innerException)
        {

        }


    }
}
