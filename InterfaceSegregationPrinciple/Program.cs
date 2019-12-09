using InterfaceSegregationPrinciple.Models;
using System;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carro Manual");

            ICarroManual carroManual = new CarroManual();
            carroManual.Acelera();
            carroManual.Freia();

            Console.WriteLine();
            Console.WriteLine("Carro Automático");

            ICarro carroAutomatico = new CarroAutomatico();
            carroAutomatico.Acelera();
            carroAutomatico.Freia();

            Console.ReadKey();
        }
    }
}
