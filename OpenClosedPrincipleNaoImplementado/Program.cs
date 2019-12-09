using SemOpenClosedPrinciple.Models;
using System;

namespace SemOpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var compra = new Compra(799, "SP");
            var calculadora = new CalculadoraDePrecos(); 

            var precoFinal = calculadora.Calcular(compra);

            Console.WriteLine($"Valor da Compra: R$ {compra.Valor}, Preço Final: R$ {precoFinal}");

            Console.ReadKey();
        }
    }
}
