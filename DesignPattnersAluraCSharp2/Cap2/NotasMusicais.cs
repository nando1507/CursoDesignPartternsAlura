using DesignPattnersAluraCSharp2.Cap2.Interface;
using DesignPattnersAluraCSharp2.Cap2.Model;

namespace DesignPattnersAluraCSharp2.Cap2
{
    public class NotasMusicais
    {
        IDictionary<string, INota> notas = new Dictionary<string, INota>()
        {
            {"do", new Do() },
            {"re", new Re() },
            {"mi", new Mi() },
            {"fa", new Fa() },
            {"sol", new Sol() },
            {"la", new La() },
            {"si", new Si() }
        };

        public INota Pega(string nome)
        {
            return notas[nome];
        }
    }
}
