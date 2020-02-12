using System;
using tabuleiro;
using Xadrez;

namespace Partida_de_Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.Write("Origem:");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino:");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destino);


                }

                Tela.imprimirTabuleiro(partida.tab);
               
            }
            catch (TabuleiroExeption error)
            {
                Console.WriteLine(error.Message);
            }

            Console.ReadLine();
        }
    }
}
