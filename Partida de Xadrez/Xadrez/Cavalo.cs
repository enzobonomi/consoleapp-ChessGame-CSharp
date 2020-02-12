
using tabuleiro;


namespace Xadrez
{
    class Cavalo : Peca
    {
        public Cavalo(Tabuleiro tabuleiro, CorDaPeca cor) : base(tabuleiro, cor)
        {

        }
        public override string ToString()
        {
            return "C";
        }
    }
}