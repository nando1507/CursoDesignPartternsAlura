using DesignPattners_Aula5.Interfaces;
using System;

namespace DesignPattners_Aula5.Models.Impostos
{
    public class ISS : Imposto
    {
        public ISS(Imposto _outroImposto) : base(_outroImposto)
        {
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
