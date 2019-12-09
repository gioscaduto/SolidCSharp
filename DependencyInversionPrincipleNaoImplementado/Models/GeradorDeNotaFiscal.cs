using System;
using System.Collections.Generic;
using System.Text;

namespace SemDependencyInversionPrinciple.Models
{
    public class GeradorDeNotaFiscal
    {
        private readonly EnviadorDeEmail _enviadorDeEmail;
        private readonly NotaFiscalDAL _notaFiscalDAL;

        public GeradorDeNotaFiscal(EnviadorDeEmail enviadorDeEmail, NotaFiscalDAL notaFiscalDAL)
        {
            _enviadorDeEmail = enviadorDeEmail;
            _notaFiscalDAL = notaFiscalDAL;
        }

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, Imposto(valor));

            _notaFiscalDAL.Salvar(nf);
            _enviadorDeEmail.Envia(nf);

            return nf;
        }

        private double Imposto(double valor) => valor * 0.04;
    }
}
