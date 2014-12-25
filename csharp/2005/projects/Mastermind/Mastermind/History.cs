using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class History : List<Guess>
    {
        public History() : base()
        {
        }

        public void Show(Solution s)
        {
            int counter = 1;
            Console.WriteLine("\n -------------------- Guess History -------------------- ");
            foreach (Guess g in this)
            {
                Score score = s.CheckGuess(g);
                Console.Write("  " + counter + ") Guess: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(g.Text);
                Console.ResetColor();
                Console.Write(". ");
                score.Show();
                counter++;
            }
            Console.WriteLine(" ------------------------------------------------------- \n");
        }
    }
}
