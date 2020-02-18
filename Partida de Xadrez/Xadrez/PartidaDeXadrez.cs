using System;
using tabuleiro;
using System.Collections.Generic;

namespace Xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro tab { get; private set; }
        public int turno { get; private set; }
        public CorDaPeca jogadorAtual { get; private set; }
        public bool terminada { get; private set; }
        private HashSet<Peca> pecas;
        private HashSet<Peca> capturadas;

        public PartidaDeXadrez()
        {
            tab = new Tabuleiro(8, 8);
            turno = 1;
            jogadorAtual = CorDaPeca.Branca;
            terminada = false;
            pecas = new HashSet<Peca>();
            capturadas = new HashSet<Peca>();
            colocarPecasInicialmente();
        }

        public void executaMovimento(Posicao origem, Posicao destino)
        {
            Peca p = tab.retirarPeca(origem);
            p.incrementarQuantidadeDeMovimentos();
            Peca pecaCapturada = tab.retirarPeca(destino);
            tab.colocarPeca(p, destino);
            if (pecaCapturada != null)
            {
                capturadas.Add(pecaCapturada);
            }

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

        public HashSet<Peca> pecasCapturadas(CorDaPeca cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach(Peca x in capturadas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            return aux;
        }
        public HashSet<Peca> pecasEmJogo(CorDaPeca cor)
        {
            HashSet<Peca> aux = new HashSet<Peca>();
            foreach (Peca x in pecas)
            {
                if (x.Cor == cor)
                {
                    aux.Add(x);
                }
            }
            aux.ExceptWith(pecasCapturadas(cor));
            return aux;
        }

        public void colocarNovaPeca(char coluna, int linha, Peca peca)
        {
            tab.colocarPeca(peca, new PosicaoXadrez(coluna, linha).toPosicao());
            pecas.Add(peca);

        }
        private void colocarPecasInicialmente()
        {
            colocarNovaPeca('c', 1, new Torre(tab, CorDaPeca.Branca));
            colocarNovaPeca('c', 2, new Torre(tab, CorDaPeca.Branca));
            colocarNovaPeca('d', 2, new Torre(tab, CorDaPeca.Branca));
            colocarNovaPeca('e', 2, new Torre(tab, CorDaPeca.Branca));
            colocarNovaPeca('e', 1, new Torre(tab, CorDaPeca.Branca));
            colocarNovaPeca('d', 1, new Rei(tab, CorDaPeca.Branca));

            colocarNovaPeca('c', 7, new Torre(tab, CorDaPeca.Preta));
            colocarNovaPeca('c', 8, new Torre(tab, CorDaPeca.Preta));
            colocarNovaPeca('d', 7, new Torre(tab, CorDaPeca.Preta));
            colocarNovaPeca('e', 7, new Torre(tab, CorDaPeca.Preta));
            colocarNovaPeca('e', 8, new Torre(tab, CorDaPeca.Preta));
            colocarNovaPeca('d', 8, new Rei(tab, CorDaPeca.Preta));

        }
    }
}
