using DesignPattners_Aula1.Interfaces;
using System;

namespace DesignPattners_Aula1.Models
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

    }
}
