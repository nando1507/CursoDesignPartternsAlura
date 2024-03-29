﻿using DesignPattners_Aula2.Interfaces;

namespace DesignPattners_Aula2.Models
{
    public class DescontoPorMaisDeQuinhetosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor > 500.0)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return Proximo.Desconta(orcamento);
            }
        }
    }
}
