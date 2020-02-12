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

        public void colocarPeca(Peca p, Posicao position)
        {
            Pecas[position.Linha, position.Coluna] = p;
            p.Posicao = position;
        }


    }
}
