using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattners_Aula6.Models
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

        public NotaFiscal Constroi()
        {
            return new NotaFiscal(
                RazaoSocial, 
                Cnpj, 
                DataDeEmissao, 
                valorTotal, 
                impostos, 
                todosItens, 
                Observacoes);
        }



    }
}
