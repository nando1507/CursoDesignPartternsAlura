using DesignPattners_Aula3.Interfaces;
using System;

namespace DesignPattners_Aula3.Models
{
    public class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

    }
}
