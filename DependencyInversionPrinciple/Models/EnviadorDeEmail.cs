using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Models
{
    public class EnviadorDeEmail: IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal nf)
        {
            Console.WriteLine("Enviado E-mail.");
        }
    }
}
