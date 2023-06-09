using DesignPattners_Aula5.Interfaces;

namespace DesignPattners_Aula5.Models.States
{
    public class Finalizado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception(" Orcamentos finalizados nao recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento Finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento Finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento Finalizado");
        }
    }
}
