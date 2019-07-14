using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var jogo = new Jogo(
                new Jogador("Ronaldo"),
                new Jogador3()
            );
            
            jogo.IniciarJogo();
        }
    }
}
