using System;

namespace GussTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            NumerousSekretator game = new NumerousSekretator();
            Console.WriteLine("hádej");
            while (true)
            {
                int guess = int.Parse(Console.ReadLine());
                game.Guess(guess);
            }
        }
    }
}
