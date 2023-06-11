using DesignPattnersAluraCSharp2.Cap2.Interface;

namespace DesignPattnersAluraCSharp2.Cap2.Model
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (INota i in musica)
            {
                Console.Beep(i.frenquencia, 500);
            }
        }
    }
}
