using System;
using System.Collections.Generic;
using System.Text;

namespace SemInterfaceSegregationPrinciple.Models
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

        public void TrocaMarcha()
        {
            throw new NotImplementedException("O motorista não pode trocar a marcha em um carro automático");
        }
    }
}
