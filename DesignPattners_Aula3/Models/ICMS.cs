using DesignPattners_Aula3.Interfaces;

namespace DesignPattners_Aula3.Models
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }


    }
}
