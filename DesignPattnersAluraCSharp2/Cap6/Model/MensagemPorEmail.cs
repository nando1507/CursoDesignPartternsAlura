using DesignPattnersAluraCSharp2.Cap6.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattnersAluraCSharp2.Cap6.Model
{
    public class MensagemPorEmail : IMensagem
    {
        private string nome;

        public MensagemPorEmail(string nome)
        {
            this.nome = nome;
        }

        public IEnviador Enviador { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Envia()
        {
            Console.WriteLine("Enviando mensagem por e-mail");
            Console.WriteLine("Mensagem para o usuário {0}", nome);
        }

        public string Formata()
        {
            throw new NotImplementedException();
        }
    }

}
