using OpenClosedPrinciple.Models;
using System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var compra = new Compra(799, "SP");

            //Nova Forma de Entrega: Por Transportadora
            var calculadora = new CalculadoraDePrecos
                                (new TabelaDePrecoPadrao(), 
                                 new Transportadora());

            var precoFinal = calculadora.Calcular(compra);

            Console.WriteLine($"Valor da Compra: R$ {compra.Valor}, Preço Final: R$ {precoFinal}");

            Console.ReadKey();
        }
    }
}
