using System;

namespace check_all_letters
{
    class Program
    {
        static ConsoleKeyInfo cki = new ConsoleKeyInfo();
        static string userString, userInput = "";
        static char[] missingLetters;
        static string version = "v0.1";

        static void Main(string[] args)
        {
            Console.Title = "All Letters Checker " + version;
            do
            {
                initialize();
                getInput();
                showMissingLetters();
                Console.WriteLine("\nIf you wish to start over to analyze another string, press R.");
                Console.WriteLine("If you're done, just press any other key to exit.");
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.R)
                    Console.Clear();
            }
            while (cki.Key == ConsoleKey.R);
        }

        static void initialize()
        {
            Console.WriteLine("All Letters Checker " + version + " by Omri Harel.");
            Console.WriteLine("C# Part 2 - Page 20, Ex 16. [Level 2]");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("This program gets a string made by the user, checks if it includes");
            Console.WriteLine("all letters in both capital and lowercase forms, and notifies which");
            Console.WriteLine("characters are missing, if any.\n");
        }

        static void getInput()
        {
            do
            {
                Console.WriteLine("Please enter a string which contains letters only:");
                userInput = Console.ReadLine();
                if (userInput.Length == 0)
                {
                    Console.WriteLine("No empty strings!");
                    continue;
                }
                bool illegalChars = false;
                for (int i = 0; i < userInput.Length; i++)
                {
                    if (!((userInput[i] >= 'A' && userInput[i] <= 'Z') || (userInput[i] >= 'a' && userInput[i] <= 'z')))
                    {
                        userInput = userInput.Remove(i, 1);
                        i--;
                        illegalChars = true;
                    }
                }
                if (illegalChars)
                    Console.WriteLine("\nSome of your characters are not letters, and therefore have been deleted.");
                if (userInput.Length == 0)
                {
                    if (illegalChars)
                        Console.WriteLine("Deletion of non-letter characters has nullified your string.\nPlease try again.");
                    else
                        Console.WriteLine("\nNo empty strings!");
                }
            }
            while (userInput.Length == 0);
            Console.WriteLine("String " + userInput + " accepted.");
            userString = userInput;
        }

        static void showMissingLetters()
        {
            int missingsum = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                int subsum = 0;
                for (int j = 0; j < userString.Length; j++)
                {
                    if (userString[j] == i)
                        subsum++;
                }
                if (subsum == 0)
                    missingsum++;
            }
            for (char i = 'a'; i <= 'z'; i++)
            {
                int subsum = 0;
                for (int j = 0; j < userString.Length; j++)
                {
                    if (userString[j] == i)
                        subsum++;
                }
                if (subsum == 0)
                    missingsum++;
            }
            missingLetters = new char[missingsum];
            int missingLettersCount = 0;
            for (char i = 'A'; i <= 'Z'; i++)
            {
                int subsum = 0;
                for (int j = 0; j < userString.Length; j++)
                {
                    if (userString[j] == i)
                        subsum++;
                }
                if (subsum == 0)
                {
                    missingLetters[missingLettersCount] = i;
                    missingLettersCount++;
                }
            }
            for (char i = 'a'; i <= 'z'; i++)
            {
                int subsum = 0;
                for (int j = 0; j < userString.Length; j++)
                {
                    if (userString[j] == i)
                        subsum++;
                }
                if (subsum == 0)
                {
                    missingLetters[missingLettersCount] = i;
                    missingLettersCount++;
                }
            }
            if (missingLetters.Length == 0)
            {
                Console.WriteLine("\nYour string includes all letters.");
            }
            else
            {
                Console.WriteLine("\nThe following characters are missing:");
                for (int i = 0; i < missingLetters.Length; i++)
                {
                    if (i == missingLetters.Length - 1)
                        Console.Write(missingLetters[i] + ".\n");
                    else
                        Console.Write(missingLetters[i] + ", ");
                }
            }
        }
    }
}
