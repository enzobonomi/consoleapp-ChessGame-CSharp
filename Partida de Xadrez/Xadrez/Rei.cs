
using tabuleiro;


namespace Xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tabuleiro, CorDaPeca cor) : base(tabuleiro, cor)
        {

        }
        public override string ToString()
        {
            return "R";
        }
    }
}
