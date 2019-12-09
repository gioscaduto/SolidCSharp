using SemDependencyInversionPrinciple.Models;
using System;

namespace SemDependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            var enviadorDeEmail = new EnviadorDeEmail();
            var notaFiscalDAL = new NotaFiscalDAL();

            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(enviadorDeEmail, notaFiscalDAL);

            var fatura = new Fatura(1099.99, "João");

            geradorDeNotaFiscal.Gera(fatura);
            
            Console.ReadKey();
        }
    }
}
