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

        public GameState LastTipState => throw new NotImplementedException();

        public bool Guess(int number)
        {
            switch (number != Number)
            {
                case 1:
                    LastTipState
                    break;
            }
            if (number == Number)
            {
                TipCounter++;
                Guessed = true;
            }
            TipCounter++;
            return Guessed;
        }
    }
}
