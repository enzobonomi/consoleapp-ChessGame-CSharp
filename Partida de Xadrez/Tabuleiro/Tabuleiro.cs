using System;
using System.Collections.Generic;
using System.Text;

namespace tabuleiro
{
    class Tabuleiro
    {
        public int Linhas { get; set; }
        public int Colunas { get; set; }

        private Peca[,] Pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.Linhas = linhas;
            this.Colunas = colunas;
            Pecas = new Peca[linhas, colunas];
        }

        public Peca peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }
        public Peca peca(Posicao posicao)
        {
            return Pecas[posicao.Linha, posicao.Coluna];
        }

        public bool existePeca(Posicao posicao)
        {
            validarPosicao(posicao);
            return peca(posicao) != null;
        }

        public void colocarPeca(Peca p, Posicao posicao)
        {
            if (existePeca(posicao))
            {
                throw new TabuleiroExeption("Já existe  uma peça nessa posição!/There is already a piece in that position!");
            }
            Pecas[posicao.Linha, posicao.Coluna] = p;
            p.Posicao =posicao;
        }
        
        public Peca retirarPeca(Posicao posicao)
        {
            if (peca(posicao) == null)
            {
                return null;
            }
            Peca aux = peca(posicao);
            aux.Posicao = null;
            Pecas[posicao.Linha, posicao.Coluna] = null;
            return aux;
        }


        public bool posicaoValida(Posicao posicao)
        {
            if (posicao.Linha<0 || posicao.Linha >= Linhas || posicao.Coluna < 0 || posicao.Coluna >= Colunas)
            {
                return false;
            }
            return true;
        }
        public void validarPosicao (Posicao posicao)
        {
            if (!posicaoValida(posicao))
            {
                throw new TabuleiroExeption("Posição Inválida!/Invalid Position!");
            }
        }





    }
}
