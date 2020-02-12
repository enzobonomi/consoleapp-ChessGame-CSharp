using System;
using tabuleiro;
using Xadrez;

namespace Partida_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            

            tab.colocarPeca(new Torre(tab, CorDaPeca.Preta), new Posicao(0, 0));
            tab.colocarPeca(new Torre(tab, CorDaPeca.Preta), new Posicao(4, 6));
            tab.colocarPeca(new Rei(tab, CorDaPeca.Preta), new Posicao(3, 5));
            Tela.MostrarTabuleiro(tab);
        }
    }
}
