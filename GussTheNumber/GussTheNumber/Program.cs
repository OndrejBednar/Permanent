using System;

namespace GussTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guessed = false;
            NumerousSekretator game = new NumerousSekretator(0,100);
            Console.WriteLine("hádej náhodné číslo od 0 do 100");
            while (guessed == false)
            {
                int guess = int.Parse(Console.ReadLine());
                if (game.Guess(guess))
                {
                    guessed = true;
                }
                switch (game.LastTipState)
                {
                    case GameState.IsGreater:
                        Console.WriteLine("Hledané číslo je větší");
                        break;
                    case GameState.IsEqual:
                        Console.WriteLine("Dobrá práce uhodl jste !");
                        Console.WriteLine($"Na {game.TipCounter} pokus");
                        break;
                    case GameState.IsLess:
                        Console.WriteLine("Hledané číslo je menší");
                        break;
                }
            }

        }
    }
}
