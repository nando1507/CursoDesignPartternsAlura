using DesignPattners_Aula5.Interfaces;

namespace DesignPattners_Aula5.Models.Impostos
{
    public class ICPP : TemplateDeImpostoCondicional
    {
        public ICPP(Imposto _outroImposto) : base(_outroImposto)
        {
        }

        //public double Calcula(Orcamento orcamento)
        //{
        //    if(orcamento.Valor >= 500)
        //    {
        //        return orcamento.Valor * 0.07;
        //    }
        //    else
        //    {
        //        return orcamento.Valor * 0.05;
        //    }

        //}
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07 + CalculoDoOutroImposto(orcamento);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05 + CalculoDoOutroImposto(orcamento);
        }
    }
}
