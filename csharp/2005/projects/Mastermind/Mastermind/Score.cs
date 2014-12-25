using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Score
    {
        public int Correct;
        public int Position;

        public Score()
        {
            Correct = 0;
            Position = 0;
        }

        public void Show()
        {
            Console.Write("Score: Correct - ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(this.Correct);
            Console.ResetColor();
            Console.Write(". In position: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(this.Position);
            Console.ResetColor();
            Console.WriteLine(".");
        }
    }
}
