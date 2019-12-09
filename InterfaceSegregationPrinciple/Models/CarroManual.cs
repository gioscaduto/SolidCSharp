using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Models
{
    public class CarroManual : ICarroManual
    {
        public void Acelera()
        {
            Console.WriteLine("Acelerando");
            TrocaMarcha();
        }

        public void Freia()
        {
            Console.WriteLine("Freiando");
            TrocaMarcha();
        }

        public void TrocaMarcha()
        {
            Console.WriteLine("Trocando a Marcha");
        }
    }
}
