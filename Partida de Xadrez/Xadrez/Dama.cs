
using tabuleiro;


namespace Xadrez
{
    class Dama : Peca
    {
        public Dama(Tabuleiro tabuleiro, CorDaPeca cor) : base(tabuleiro, cor)
        {

        }
        public override string ToString()
        {
            return "D";
        }
    }
}