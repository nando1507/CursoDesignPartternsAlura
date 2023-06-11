using DesignPattnersAluraCSharp2.Cap8;

namespace DesignPattnersAluraCSharp2.Cap9
{
    internal class ClienteDao
    {
        public ClienteDao()
        {
        }

        public Cliente BuscaPorCpf(string cpf)
        {
            return new Cliente()
            { 
                Nome = "victor",
                Endereco = "Rua Vergueiro",
                DataDeNascimento = DateTime.Now
            };
        }
    }
}