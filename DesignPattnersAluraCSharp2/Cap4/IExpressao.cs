using DesignPattnersAluraCSharp2.Cap5;

namespace DesignPattnersAluraCSharp2.Cap4
{
    public interface IExpressao
    {
        int Avalia();
        void Aceita(IVisitor impressora);
    }
}
