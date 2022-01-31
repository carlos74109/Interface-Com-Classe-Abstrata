using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComAbstract.Entidades
{
    internal class Retangulo : AbstractForma
    {

        public double altura;
        public double largura;

        public override double Area()
        {
            return altura * largura;
        }

       
    }
}
