using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinStockExcepcion : Exception
    {
        public SinStockExcepcion(string message)
         : base(message)
        {

        }
    }
}
