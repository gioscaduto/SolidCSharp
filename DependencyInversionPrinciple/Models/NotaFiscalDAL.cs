using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Models
{
    public class NotaFiscalDAL: IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Salvando a Nota Fiscal");
        }
    }
}
