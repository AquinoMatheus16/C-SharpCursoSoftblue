﻿using System;

namespace Softblue
{
    class Program
    {
        static void Main()
        {
            // Inicia o jogo
            Game game = new Game(5); // Número de chances do usuário
            game.Play();
        }
    }
}