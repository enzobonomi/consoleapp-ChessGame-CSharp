
using tabuleiro;


namespace Xadrez
{
    class Bispo : Peca
    {
        public Bispo(Tabuleiro tabuleiro, CorDaPeca cor) : base(tabuleiro, cor)
        {

        }
        public override string ToString()
        {
            return "B";
        }
    }
}