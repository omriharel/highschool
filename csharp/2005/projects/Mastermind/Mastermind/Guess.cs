using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Guess
    {
        private string text;

        public string Text
        {
            get { return text; }
        }

        public Guess(string g)
        {
            text = g.ToLower();
        }
    }
}
