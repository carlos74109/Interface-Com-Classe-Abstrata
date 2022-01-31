using InterfaceComAbstract.Entidades.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComAbstract.Entidades
{
    internal abstract class AbstractForma : IForma
    {

        public Cor cor;

        public abstract double Area();

        public override string ToString()
        {
            return "Cor do retangulo é: " + cor + " sua area é: " + Area();
        }
    }
}
