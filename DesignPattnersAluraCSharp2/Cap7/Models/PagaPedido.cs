using DesignPattnersAluraCSharp2.Cap7.Interfaces;

namespace DesignPattnersAluraCSharp2.Cap7.Models
{
    public class PagaPedido : IComando
    {
        private Pedido pedido;

        public PagaPedido(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            pedido.Paga();
        }
    }
}
