using System;
using tabuleiro;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public CorDaPeca jogadorAtual { get; private set; }
        public bool terminada { get; private set; }

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = CorDaPeca.Branca;
            terminada = false;
            colocarPecasInicialmente();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQuantidadeDeMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
        }

        public void realizaJogada(Posicao origem, Posicao destino)
        {
            executaMovimento(origem, destino);
            turno++;
            mudaJogador();
        }

        public void validarPosicaoDeOrigem(Posicao pos)
        {
            if (tab.peca(pos) == null)
            {
                throw new TabuleiroExeption("Não existe peça na posição de origem escolhida!");
            }
            if (jogadorAtual != tab.peca(pos).Cor)
            {
                throw new TabuleiroExeption("A peça de origem escolhida não é sua!");
            }
            if (!tab.peca(pos).existeMovimentosPossiveis())
            {
                throw new TabuleiroExeption("Não há movimentos possíveis para a peça de origem escolhida!");
            }
        }

        public void validarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!tab.peca(origem).podeMoverPara(destino))
            {
                throw new TabuleiroExeption("Posição de destino inválida!");
            }
        }
        private void mudaJogador()
        {
            if (jogadorAtual == CorDaPeca.Branca)
            {
                jogadorAtual = CorDaPeca.Preta;
            }
            else
            {
                jogadorAtual = CorDaPeca.Branca;
            }
        }
        private void colocarPecasInicialmente()
        {
            tab.colocarPeca(new Torre(tab, CorDaPeca.Preta), new PosicaoXadrez('a', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, CorDaPeca.Preta), new PosicaoXadrez('b', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, CorDaPeca.Preta), new PosicaoXadrez('c', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, CorDaPeca.Preta), new PosicaoXadrez('d', 1).toPosicao());
            tab.colocarPeca(new Torre(tab, CorDaPeca.Preta), new PosicaoXadrez('e', 1).toPosicao());

            tab.colocarPeca(new Torre(tab, CorDaPeca.Branca), new PosicaoXadrez('a', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, CorDaPeca.Branca), new PosicaoXadrez('b', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, CorDaPeca.Branca), new PosicaoXadrez('c', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, CorDaPeca.Branca), new PosicaoXadrez('d', 8).toPosicao());
            tab.colocarPeca(new Torre(tab, CorDaPeca.Branca), new PosicaoXadrez('e', 8).toPosicao());
        }
    }
}
