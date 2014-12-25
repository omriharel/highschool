using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Solution
    {
        private string text;

        public string Text
        {
            get { return text; }
        }

        public Solution()
        {
            int positions = Defvals.positions;
            int characters = Defvals.characters;
            bool duplicates = Defvals.duplicates;
            string alpha = Defvals.alpha.Substring(0, characters);
            string cantUse = "";
            this.text = "";
            Random rand = new Random();
            for (int i = 0; i < positions; i++)
            {
                char toAdd = alpha[rand.Next() % characters];
                if (!duplicates)
                {
                    if (cantUse.Contains(toAdd.ToString()))
                    {
                        i--;
                        continue;
                    }
                    else
                        cantUse += toAdd.ToString();
                }
                text += toAdd.ToString();
            }
        }

        public Score CheckGuess(Guess g)
        {
            Score s = new Score();
            for (int i = 0; i < Defvals.characters; i++)
            {
                if (Defvals.HowMany(g.Text, Defvals.alpha[i]) >=
                    Defvals.HowMany(this.Text, Defvals.alpha[i]))
                {
                    s.Correct += Defvals.HowMany(this.Text, Defvals.alpha[i]);
                }
                else
                {
                    s.Correct += Defvals.HowMany(g.Text, Defvals.alpha[i]);
                }
            }
            for (int i = 0; i < Defvals.positions; i++)
            {
                if (this.Text[i] == g.Text[i])
                    s.Position++;
            }
            return s;
        }
    }
}
