using DesignPattners_Aula5.Interfaces;
using System.Drawing;

namespace DesignPattners_Aula5.Models.States
{
    public class Aprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= (orcamento.Valor * 0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento aprovado não pode ser aprovado Novamente");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new Finalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento aprovado não pode ser reprovado ");
        }
    }
}
