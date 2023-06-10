using DesignPattners_Aula7.Interfaces;
using DesignPattners_Aula7.Services;

namespace DesignPattners_Aula7.Models
{
    public class CriadorDeNotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataDeEmissao { get; set; }


        private double valorTotal;
        private double impostos;

        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();


        private IList<IAcaoAposGerarNota> todasAcoesASeremExecutadas;


        public CriadorDeNotaFiscal ParaEmpresa(string razaoSocial)
        {
            RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscal ComCNPJ(string cnpj)
        {
            Cnpj = cnpj;
            return this;
        }
        public CriadorDeNotaFiscal ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            valorTotal += item.Valor;
            impostos += item.Valor * 0.05;
            return this;
        }

        public CriadorDeNotaFiscal ComObservacoes(string observacoes)
        {
            Observacoes = observacoes;
            return this;
        }

        public CriadorDeNotaFiscal NaDataAtual()
        {
            DataDeEmissao = DateTime.Now;
            return this;
        }

        public void AdicionaAcao(IAcaoAposGerarNota NovaAcao)
        {
            todasAcoesASeremExecutadas.Add(NovaAcao);
        }


        public NotaFiscal Constroi()
        {
            var nf = new NotaFiscal(
                RazaoSocial,
                Cnpj,
                DataDeEmissao,
                valorTotal,
                impostos,
                todosItens,
                Observacoes);


            foreach(IAcaoAposGerarNota acao in todasAcoesASeremExecutadas)
            {
                acao.Executa(nf);
            }


            //new EnviadorDeEmail().Executa(nf);
            //new NotaFiscalDao().Executa(nf);
            //new EnviadorDeSMS().Executa(nf);
            return nf;
        }


    }
}
