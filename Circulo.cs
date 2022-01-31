using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComAbstract.Entidades
{
    internal class Circulo : AbstractForma
    {
        public double raio;
        public override double Area()
        {
            return Math.PI * raio * raio;
        }

      
    }
}
