using DesignPattnersAluraCSharp2.Cap4;

namespace DesignPattnersAluraCSharp2.Cap5
{
    public class Impressora : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.esquerda.Aceita(this);
            Console.Write(" + ");
            soma.direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.esquerda.Aceita(this);
            Console.Write(" - ");
            subtracao.direita.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.numero);
        }
    }
}
