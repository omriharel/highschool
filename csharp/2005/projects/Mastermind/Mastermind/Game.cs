using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Game
    {
        private Solution solution;
        private Guess currentGuess;
        private Score currentScore;
        private int positions, characters;
        private bool duplicates;
        private History history;
        private int round;
        private bool FlagJustHandled;

        public Game()
        {
            solution = new Solution();
            positions = Defvals.positions;
            characters = Defvals.characters;
            duplicates = Defvals.duplicates;
            history = new History();
            currentScore = new Score();
            currentScore.Position = 0;
            currentScore.Correct = 0;
            round = 0;
            FlagJustHandled = false;
            Console.Clear();
        }

        public void Play()
        {
            round = 0;
            while (currentScore.Position < positions)
            {
                if (round != 0)
                    history.Add(currentGuess);
                round++;
                Console.Write("Round " + round + ". Enter your guess: ");
                string g = Console.ReadLine();
                if (IsFlag(g))
                    HandleFlag(g.ToLower());
                while (!Defvals.CheckGuess(g, positions, characters, duplicates) || FlagJustHandled)
                {
                    if (FlagJustHandled)
                    {
                        FlagJustHandled = false;
                        Console.Write("Round " + round + ". Enter your guess: ");
                        g = Console.ReadLine();
                        if (IsFlag(g))
                            HandleFlag(g.ToLower());
                        continue;
                    }
                    else
                    {
                        Console.Write("You did not enter a valid guess. Please try again. ");
                        g = Console.ReadLine();
                    }
                }
                currentGuess = new Guess(g.ToLower());
                Console.Write("Accepted guess: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(currentGuess.Text);
                Console.ResetColor();
                Console.Write(". ");
                currentScore = solution.CheckGuess(currentGuess);
                currentScore.Show();
            }
            Console.WriteLine("Congratulations! You won. The solution was indeed " + solution.Text + ".");
            switch (round)
            {
                case 1:
                    Console.WriteLine("It only took you one round to figure it out! You rock!");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("You did it pretty quickly, within " + round + " rounds.");
                    break;
                default:
                    Console.WriteLine("It took you " + round + " rounds to complete. You can get better.");
                    break;
            }
            Console.Write("Press any key to continue. ");
            Console.ReadKey(true);
        }

        private void ShowHistory()
        {
            history.Show(solution);
        }

        private bool IsFlag(string s)
        {
            if (s.StartsWith("/"))
                return true;
            return false;
        }

        private void HandleFlag(string s)
        {
            Console.Clear();
            FlagJustHandled = true;
            if (s == "/help" || s == "/?")
            {
                DisplayHelp();
                return;
            }
            //else if (s == "/hint")
            //{
            //    GiveHint();
            //    return;
            //}
            else if (s == "/history")
            {
                ShowHistory();
                return;
            }
            else
            {
                Console.WriteLine("Your flag is invalid. For allowed flags, type '/help' or '/?'.");
                return;
            }
        }

        private void DisplayHelp()
        {
            Console.WriteLine("Game Help:");
            Console.WriteLine("To get a look on your guess History so far, type '/history'.");
            Console.WriteLine("To get a hint about the solution at the cost of one round, type '/hint'.");
        }
    }
}
