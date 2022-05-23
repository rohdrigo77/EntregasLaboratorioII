using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NombreApellidoInvalidosExcepcion : Exception
    {
        public NombreApellidoInvalidosExcepcion()
        : base()
        {

        }

        public NombreApellidoInvalidosExcepcion(string message)
       : base(message)
        {

        }

        public NombreApellidoInvalidosExcepcion(string message, Exception innerException)
       : base(message, innerException)
        {

        }
    }
}
