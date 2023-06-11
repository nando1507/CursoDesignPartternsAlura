using DesignPattnersAluraCSharp2.Cap5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattnersAluraCSharp2.Cap4
{
    public class Subtracao : IExpressao
    {
    
        public IExpressao esquerda { get; set; }
        public IExpressao direita { get; set; }

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            this.esquerda = esquerda;
            this.direita = direita;
        }

        public int Avalia()
        {
            int resultadoDaEsquerda = esquerda.Avalia();
            int resultadoDaDireita = direita.Avalia();
            return resultadoDaEsquerda - resultadoDaDireita;
        }
        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeSubtracao(this);
        }
    }
}
