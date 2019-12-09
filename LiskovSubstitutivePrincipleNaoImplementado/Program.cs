using SemLiskovSubstitutivePrinciple.Models;
using System;
using System.Collections.Generic;

namespace SemLiskovSubstitutivePrinciple
{
    class Program
    {
        // A maneira que a herança foi implementada está ocasionando um problema
        static void Main(string[] args)
        {
            IList<ContaComum> contas = ContasDoBanco();

            foreach (var conta in contas)
            {
                conta.Deposita(140);
                conta.SomaInvestimento(); // Será disparada uma Exceção quando a Conta for do Tipo ContaEstudante

                Console.WriteLine($"Novo Saldo {conta.Saldo}");
            }

            Console.ReadKey();
        }

        private static IList<ContaComum> ContasDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();

            contas.Add(NovaContaComum(120));
            contas.Add(NovaContaComum(129));
            contas.Add(NovaContaEstudante(90));

            return contas;
        }

        private static ContaComum NovaContaComum(double saldo)
        {
            ContaComum conta = new ContaComum();
            conta.Deposita(saldo);
            return conta;
        }

        private static ContaEstudante NovaContaEstudante(double saldo)
        {
            ContaEstudante conta = new ContaEstudante();
            conta.Deposita(saldo);
            return conta;
        }
    }
}
