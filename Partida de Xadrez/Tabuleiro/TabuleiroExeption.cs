using System;

namespace tabuleiro
{
    class TabuleiroExeption:Exception
    {
        public TabuleiroExeption(string mensagem) : base(mensagem)
        {

        }
    }
}
