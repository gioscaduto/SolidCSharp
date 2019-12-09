using DependencyInversionPrinciple.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DependencyInversionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<IAcaoAposGerarNota> acoes = new List<IAcaoAposGerarNota>();

            acoes.Add(new EnviadorDeEmail());
            acoes.Add(new NotaFiscalDAL());
            
            acoes.Add(new ERP());// Nova Acao
            
            var geradorDeNotaFiscal = new GeradorDeNotaFiscal(acoes);

            var fatura = new Fatura(1099.99, "João");

            geradorDeNotaFiscal.Gera(fatura);

            Console.ReadKey();
        }
    }
}
