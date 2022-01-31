using InterfaceComAbstract.Entidades;
using InterfaceComAbstract.Entidades.Enuns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceComAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractForma forma = new Circulo() { raio = 4, cor = Cor.White};
            AbstractForma forma2 = new Retangulo() { altura = 4, largura = 3,cor = Cor.Black};

            Console.WriteLine(forma);
            Console.WriteLine(forma2);

        }
    }
}
