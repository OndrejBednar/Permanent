using System;
using System.Collections.Generic;
using System.Text;

namespace GussTheNumber
{
    class NumerousSekretator : INumerousSekretator
    {
        static Random rand = new Random();
        int Number;
        public NumerousSekretator()
        {
            Number = rand.Next();
        }
        public NumerousSekretator(int start = 1, int end = 10)
        {
            Number = rand.Next(start, end);
        }
        public int TipCounter { get; private set; }

        public bool Guessed { get; private set; }

        public GameState LastTipState { get; private set; }

        public bool Guess(int number)
        {
            if (number > Number)
            {
                LastTipState = GameState.IsLess;
            }
            if (number < Number)
            {
                LastTipState = GameState.IsGreater;
            }
            if (number == Number)
            {
                LastTipState = GameState.IsEqual;
            }
            switch (LastTipState)
            {
                case GameState.IsGreater:
                    TipCounter++;
                    Console.WriteLine("Hledané číslo je větší");
                    break;
                case GameState.IsEqual:
                    TipCounter++;
                    Console.WriteLine("Dobrá práce uhodl jste !");
                    Guessed = true;
                    break;
                case GameState.IsLess:
                    TipCounter++;
                    Console.WriteLine("Hledané číslo je mensí");
                    break;
            }
            return Guessed;
        }
    }
}
