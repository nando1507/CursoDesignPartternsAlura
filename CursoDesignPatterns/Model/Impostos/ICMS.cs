using CursoDesignPatterns1.Interface;

namespace CursoDesignPatterns1.Model
{
    public partial class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
