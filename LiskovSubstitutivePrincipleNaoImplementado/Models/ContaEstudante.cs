using System;

namespace SemLiskovSubstitutivePrinciple.Models
{
    public class ContaEstudante: ContaComum
    {
        public int Milhas { get; private set; }

        public override void Deposita(double valor)
        {
            base.Deposita(valor);
            Milhas += (int)valor;
        }

        public override void SomaInvestimento()
        {
            throw new Exception("Uma conta de estudante não possui rendimentos.");
        }
    }
}
