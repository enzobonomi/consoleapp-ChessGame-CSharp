﻿using System;
using System.Collections.Generic;
using System.Text;
using Xadrez;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao {get; set;}
        public CorDaPeca Cor { get; set; }
        public int QuantidadeDeMovimentos { get; set; }
        public Tabuleiro Tabuleiro { get; set; }

        public Peca(Tabuleiro tabuleiro, CorDaPeca cor)
        {
            this.Posicao = null;
            this.Cor = cor;
            this.Tabuleiro = tabuleiro;
            this.QuantidadeDeMovimentos = 0;
        }
        public void incrementarQuantidadeDeMovimentos()
        {
            QuantidadeDeMovimentos++;
        }

        public abstract bool[,] movimentosPossiveis();
        
       
    }
}
