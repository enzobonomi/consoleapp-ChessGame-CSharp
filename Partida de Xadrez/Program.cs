using System;
using tabuleiro;

namespace Partida_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.MostrarTabuleiro(tab);
        }
    }
}
