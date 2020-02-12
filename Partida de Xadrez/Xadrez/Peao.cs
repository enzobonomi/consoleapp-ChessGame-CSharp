
using tabuleiro;


namespace Xadrez
{
    class Peao : Peca
    {
        public Peao(Tabuleiro tabuleiro, CorDaPeca cor) : base(tabuleiro, cor)
        {

        }
        public override string ToString()
        {
            return "P";
        }
    }
}