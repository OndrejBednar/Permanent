using System;

namespace GussTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool guessed = false;
            NumerousSekretator game = new NumerousSekretator(0,100);
            Console.WriteLine("hádej");
            while (guessed == false)
            {
                int guess = int.Parse(Console.ReadLine());
                if (game.Guess(guess))
                {
                    guessed = true;
                }
            }
        }
    }
}
