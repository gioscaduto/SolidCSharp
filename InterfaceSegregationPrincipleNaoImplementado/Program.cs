using SemInterfaceSegregationPrinciple.Models;
using System;

namespace SemInterfaceSegregationPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Carro Manual");

            ICarro carroManual = new CarroManual();
            carroManual.Acelera();
            carroManual.Freia();

            Console.WriteLine();
            Console.WriteLine("Carro Automático");

            ICarro carroAutomatico = new CarroAutomatico();
            carroAutomatico.Acelera();
            carroAutomatico.Freia();
            //carroAutomatico.TrocaMarcha(); Exceção

            Console.ReadKey();
        }
    }
}
