using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Defvals
    {
        private Defvals() { }

        public const int MAX_CHARS = 32;
        public const int MIN_CHARS = 2;

        public const int MAX_POS = 10;
        public const int MIN_POS = 2;

        public const string alpha = "abcdefghijklmnopqrstuvwxyz";

        public static int positions;
        public static int characters;
        public static bool duplicates;

        public static int HowMany(string st, char c)
        {
            int count = 0;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == c)
                    count++;
            }
            return count;
        }

        public static bool CheckGuess(string s, int positions, int characters, bool duplicates)
        {
            if (s.Length != positions)
                return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s.ToLower()[i] < alpha[0] || s.ToLower()[i] > alpha[characters - 1])
                    return false;
            }
            if (!duplicates)
            {
                int[] indexers = new int[characters];
                for (int i = 0; i < indexers.Length; i++)
                {
                    indexers[i] = 0;
                }
                for (int i = 0; i < s.Length; i++)
                {
                    for (int j = 0; j < characters; j++)
                    {
                        if (s[i] == alpha[j])
                            indexers[j]++;
                    }
                }
                for (int i = 0; i < indexers.Length; i++)
                {
                    if (indexers[i] > 1)
                        return false;
                }
            }
            return true;
        }
    }
}
