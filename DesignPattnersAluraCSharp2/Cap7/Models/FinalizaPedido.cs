using DesignPattnersAluraCSharp2.Cap7.Interfaces;

namespace DesignPattnersAluraCSharp2.Cap7.Models
{

    public class FinalizaPedido : IComando
    {
        private Pedido pedido;

        public FinalizaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            pedido.Finaliza();
        }
    }
}