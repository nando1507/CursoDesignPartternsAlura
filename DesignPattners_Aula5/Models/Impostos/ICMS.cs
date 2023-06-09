using DesignPattners_Aula5.Interfaces;

namespace DesignPattners_Aula5.Models.Impostos
{
    public class ICMS : Imposto
    {
        public ICMS()
        {

        }
        public ICMS(Imposto _outroImposto) : base(_outroImposto)
        {
        }


        //public double Calcula(Orcamento orcamento)
        //{
        //    return orcamento.Valor * 0.1;
        //}

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1 + CalculoDoOutroImposto(orcamento);
        }
    }
}
