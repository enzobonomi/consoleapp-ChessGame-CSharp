using System;
using tabuleiro;
using Xadrez;

namespace Partida_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez posicao = new PosicaoXadrez('c', 7);

            Console.WriteLine(posicao); ;


            Console.WriteLine(posicao.toPosicao());
        }
    }
}
