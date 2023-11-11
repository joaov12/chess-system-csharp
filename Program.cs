using XadrezUDM.tabuleiro;
using XadrezUDM.xadrez;

namespace XadrezUDM
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();
                while (!partida.terminada)
                {
                    try
                    {


                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab);
                        Console.WriteLine();
                        Console.WriteLine("Turno: " + partida.turno);
                        Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);



                        Console.WriteLine("\n");
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();

                        partida.realizaJogada(origem, destino);
                    }catch(TabuleiroException e)
                    {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}