using DesignPattnersAluraCSharp2.Cap8;

namespace DesignPattnersAluraCSharp2.Cap9
{
    public class ContatoCliente
    {
        public ContatoCliente(Cliente cliente, Cobranca cobranca)
        {
            Cliente = cliente;
            Cobranca = cobranca;
        }

        public Cliente Cliente { get; }
        public Cobranca Cobranca { get; }

        public void Dispara()
        {
            Console.WriteLine(  "Dispara");
        }
    }
}