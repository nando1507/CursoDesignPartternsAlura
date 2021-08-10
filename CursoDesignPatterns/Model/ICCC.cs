using CursoDesignPatterns1.Interface;

namespace CursoDesignPatterns1.Model
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {   
            if (orcamento.Valor <= 1000.0)
            {
                return orcamento.Valor * 0.05;
            }
            else if (orcamento.Valor > 1000.0 && orcamento.Valor <= 3000.0)
            {
                return orcamento.Valor * 0.07;
            }
            else
            {
                return (orcamento.Valor * 0.08) + 30;
            }           
        }
    }
}
