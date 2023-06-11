using DesignPattnersAluraCSharp2.Cap7.Interfaces;

namespace DesignPattnersAluraCSharp2.Cap7.Models
{
    public class FilaDeTrabalho
    {
        private IList<IComando> comandos = new List<IComando>();

        public void Adiciona(IComando comando)
        {
            comandos.Add(comando);
        }

        public void Processa()
        {
            foreach (IComando comando in comandos)
            {
                comando.Executa();
            }
        }
    }
}
