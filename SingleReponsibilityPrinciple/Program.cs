using SingleReponsibilityPrinciple.Models;
using System;

namespace SingleReponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario calculadoraDeSalario = new CalculadoraDeSalario();

            var maria = new Funcionario(new Desenvolvedor(new CincoOuSetePorcento()), 3500);
            var joao = new Funcionario(new Gerente(new DezOuQuinzePorcento()), 7000);

            var salarioMaria = calculadoraDeSalario.Calcula(maria);
            var salarioJoao = calculadoraDeSalario.Calcula(joao);

            Console.WriteLine($"Salário da Maria: R$ {salarioMaria}");
            Console.WriteLine($"Salário do João: R$ {salarioJoao}");
            Console.ReadKey();
        }
    }
}
