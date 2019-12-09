using System;

namespace SemInterfaceSegregationPrinciple.Models
{
    class CarroManual : ICarro
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
