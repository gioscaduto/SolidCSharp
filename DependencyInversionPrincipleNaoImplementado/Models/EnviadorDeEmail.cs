using System;
using System.Collections.Generic;
using System.Text;

namespace SemDependencyInversionPrinciple.Models
{
    public class EnviadorDeEmail
    {
        public void Envia(NotaFiscal nf)
        {
            Console.WriteLine("Enviado E-mail.");
        }
    }
}
