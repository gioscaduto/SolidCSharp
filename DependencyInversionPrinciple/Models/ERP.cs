using System;

namespace DependencyInversionPrinciple.Models
{
    public class ERP : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviando Nota Fiscal para o ERP");
        }
    }
}
