using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    class Program
    {
        static bool quit = false;
        static string version = "0.10";

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            bool ok;

            Console.WriteLine("Mastermind by Omri Harel, Copyright 2008-2009.");
            Console.WriteLine("Version " + version + ".");
            
            Console.Write("How many characters? (" + Defvals.MIN_CHARS + "-" + Defvals.MAX_CHARS + ") ");
            do
	        {
                ok = true;
                try
                {
                    Defvals.characters = int.Parse(Console.ReadLine());
                    if (Defvals.characters < Defvals.MIN_CHARS || Defvals.characters > Defvals.MAX_CHARS)
                    {
                        Console.Write("Please enter a value between " + Defvals.MIN_CHARS + " and " +
                            Defvals.MAX_CHARS + ". ");
                        ok = false;
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Invalid value, please try again. ");
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.Write("Invalid value, please try again. ");
                    ok = false;
                }
	        }
            while (!ok);
            Console.Write("How many positions? (" + Defvals.MIN_POS + "-" + Defvals.MAX_POS + ") ");
            do
            {
                ok = true;
                try
                {
                    Defvals.positions = int.Parse(Console.ReadLine());
                    if (Defvals.positions < Defvals.MIN_POS || Defvals.positions > Defvals.MAX_POS)
                    {
                        Console.Write("Please enter a value between " + Defvals.MIN_POS + " and " +
                            Defvals.MAX_POS + ". ");
                        ok = false;
                    }
                }
                catch (FormatException)
                {
                    Console.Write("Invalid value, please try again. ");
                    ok = false;
                }
                catch (OverflowException)
                {
                    Console.Write("Invalid value, please try again. ");
                    ok = false;
                }
            }
            while (!ok);
            Console.Write("Allow duplicates? (y/n) ");
            cki = Console.ReadKey();
            Console.WriteLine();
            while (cki.Key != ConsoleKey.Y && cki.Key != ConsoleKey.N)
            {
                Console.Write("Please choose either 'y' or 'n'. ");
                cki = Console.ReadKey();
                Console.WriteLine();
            }
            Defvals.duplicates = (cki.Key == ConsoleKey.Y) ? true : false;
            do
            {
                DisplayMainMenu();
            }
            while (!quit);
        }

        static void DisplayMainMenu()
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            bool endLoop = false;

            Console.Clear();
            Console.WriteLine(" ---------- MAIN MENU ----------");
            Console.WriteLine("   1) New Game");
            Console.WriteLine("   2) Change Defined Values");
            Console.WriteLine("   3) Exit");
            Console.WriteLine(" -------------------------------");
            Console.Write("\nPick an option: (1-3) ");
            cki = Console.ReadKey();
            Console.WriteLine();
            do
            {
                switch (cki.Key)
                {
                    case ConsoleKey.NumPad1:
                    case ConsoleKey.D1:
                        {
                            Game g = new Game();
                            g.Play();
                            endLoop = true;
                        }
                        break;
                    case ConsoleKey.NumPad2:
                    case ConsoleKey.D2:
                        {
                            //ChangeDefinedValues();
                            endLoop = true;
                        }
                        break;
                    case ConsoleKey.NumPad3:
                    case ConsoleKey.D3:
                        {
                            quit = true;
                        }
                        break;
                    default:
                        {
                            Console.Write("Hit a key between 1 and 3. ");
                            cki = Console.ReadKey();
                            Console.WriteLine();
                        }
                        break;
                }
            }
            while (!quit && !endLoop);
            if (endLoop)
                DisplayMainMenu();
        }
    }
}
