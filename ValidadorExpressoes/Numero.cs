using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidadorExpressoes
{
    public class Numero : Simbolo
    {
        public double numero;

        public Numero(double numero)
        {           
            this.numero = numero;
        }
    }
}
