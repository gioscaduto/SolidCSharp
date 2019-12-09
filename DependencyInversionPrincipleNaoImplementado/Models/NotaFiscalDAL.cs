using System;
using System.Collections.Generic;
using System.Text;

namespace SemDependencyInversionPrinciple.Models
{
    public class NotaFiscalDAL
    {
        public void Salvar(NotaFiscal nf)
        {
            Console.WriteLine("Salvando a Nota Fiscal");
        }
    }
}
