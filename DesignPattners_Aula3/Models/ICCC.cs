using DesignPattners_Aula3.Interfaces;
using System;

namespace DesignPattners_Aula3.Models
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor <= 1000.0
                ? orcamento.Valor * 0.05
                : orcamento.Valor > 1000.0 && orcamento.Valor < 3000.0
                ? orcamento.Valor * 0.07
                : orcamento.Valor * 0.08 + 30;
        }
    }
}
