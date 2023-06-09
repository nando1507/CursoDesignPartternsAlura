using DesignPattners_Aula4.Interfaces;
using System;

namespace DesignPattners_Aula4.Models
{
    public class ICCC : Imposto
    {
        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor <= 1000.0
                ? orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento)
                : orcamento.Valor > 1000.0 && orcamento.Valor < 3000.0
                ? orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento)
                : orcamento.Valor * 0.08 + 30 + CalculoDoOutroImposto(orcamento);
        }
    }
}
