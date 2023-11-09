using System;
using XadrezUDM.tabuleiro;

namespace XadrezUDM.xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor) : base(tab, cor) { }

        public override string ToString()
        {
            return "R";
        }
    }
}
