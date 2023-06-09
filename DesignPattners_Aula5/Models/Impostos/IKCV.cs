using DesignPattners_Aula5.Interfaces;
using System.Diagnostics.CodeAnalysis;

namespace DesignPattners_Aula5.Models.Impostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto _outroImposto) : base(_outroImposto)
        {
        }

        //public double Calcula(Orcamento orcamento)
        //{
        //    if (orcamento.Valor > 500 && terItemMaiorQue100ReaisNo(orcamento))
        //    {
        //        return orcamento.Valor * 0.1;
        //    }
        //    return orcamento.Valor * 0.06;
        //}

        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && terItemMaiorQue100ReaisNo(orcamento);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06 + CalculoDoOutroImposto(orcamento);
        }

        private bool terItemMaiorQue100ReaisNo(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
