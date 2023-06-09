using DesignPattners_Aula5.Interfaces;
using DesignPattners_Aula5.Models.States;

namespace DesignPattners_Aula5.Models
{

    public class Orcamento
    {
        public IEstadoOrcamento EstadoAtual { get; set; }

        public double Valor { get; set; }

        public IList<Item> Itens { get; private set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new Em_Aprovacao();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }

        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova() 
        { 
            EstadoAtual.Reprova(this);
        }

        public void Finaliza() 
        { 
            EstadoAtual.Finaliza(this);
        }
    }



}
