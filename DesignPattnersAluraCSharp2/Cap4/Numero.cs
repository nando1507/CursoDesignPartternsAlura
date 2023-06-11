using DesignPattnersAluraCSharp2.Cap5;

namespace DesignPattnersAluraCSharp2.Cap4
{
    public class Numero : IExpressao
    {
        public int numero;
        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int Avalia()
        {
            return numero;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }
    }
}
