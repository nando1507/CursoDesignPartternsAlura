using DesignPattnersAluraCSharp2.Cap4;

namespace DesignPattnersAluraCSharp2.Cap5
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeNumero(Numero numero);
    }


}
