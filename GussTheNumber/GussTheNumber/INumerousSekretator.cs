using System;
using System.Collections.Generic;
using System.Text;

namespace GussTheNumber
{
    interface INumerousSekretator
    {
        int TipCounter { get; }
        bool Guessed { get; }
        GameState LastTipState { get; }
        bool Guess(int number);
    }
}
