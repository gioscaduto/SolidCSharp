using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Models
{
    public class GeradorDeNotaFiscal
    {
        private readonly IList<IAcaoAposGerarNota> _acoes;
        
        public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes)
        {
            _acoes = acoes;
        }

        public NotaFiscal Gera(Fatura fatura)
        {
            double valor = fatura.ValorMensal;

            NotaFiscal nf = new NotaFiscal(valor, Imposto(valor));

            foreach (var acao in _acoes)
            {
                acao.Executa(nf);
            }

            return nf;
        }

        private double Imposto(double valor) => valor * 0.04;
    }
}
