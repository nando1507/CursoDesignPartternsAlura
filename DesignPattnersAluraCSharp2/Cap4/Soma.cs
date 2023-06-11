using DesignPattnersAluraCSharp2.Cap5;

namespace DesignPattnersAluraCSharp2.Cap4
{
    public class Soma : IExpressao
    {
        public IExpressao esquerda { get; set; }
        public IExpressao direita {get;set;}
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = esquerda.Avalia();
            int resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda + resultadoDaDireita;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSoma(this);
        }

    }
}
