using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Models
{
    public class CarroAutomatico : ICarro
    {
        public void Acelera()
        {
            Console.WriteLine("Acelerando");
        }

        public void Freia()
        {
            Console.WriteLine("Freiando");
        }
    }
}
