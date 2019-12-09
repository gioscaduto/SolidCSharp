using LiskovSubstitutivePrinciple.Models;
using System;
using System.Collections.Generic;

namespace LiskovSubstitutivePrinciple
{
    class Program
    {
       
        // Utilizado Composição no Lugar de Herança
        static void Main(string[] args)
        {
            IList<ContaComum> contas = ContasComumDoBanco();

            foreach (var conta in contas)
            {
                conta.Deposita(140);
                conta.SomaInvestimento();

                Console.WriteLine($"Novo Saldo {conta.GetSaldo()}");
            }

            Console.ReadKey();
        }

        private static IList<ContaComum> ContasComumDoBanco()
        {
            List<ContaComum> contas = new List<ContaComum>();

            contas.Add(NovaContaComum(120));
            contas.Add(NovaContaComum(129));
            
            return contas;
        }

        private static IList<ContaEstudante> ContasEstudanteDoBanco()
        {
            List<ContaEstudante> contas = new List<ContaEstudante>();

            contas.Add(NovaContaEstudante(99));
            contas.Add(NovaContaEstudante(105));

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
