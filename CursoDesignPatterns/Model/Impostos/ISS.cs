using CursoDesignPatterns1.Interface;

namespace CursoDesignPatterns1.Model
{
    public partial class ISS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
