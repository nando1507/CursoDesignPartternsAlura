using DesignPattners_Aula4.Interfaces;
using System;

namespace DesignPattners_Aula4.Models
{
    public class ISS : Imposto
    {
        
        public ISS(Imposto _outroImposto) : base(_outroImposto)
        {
        }

        public ISS()
        {
            
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }
    }
}
