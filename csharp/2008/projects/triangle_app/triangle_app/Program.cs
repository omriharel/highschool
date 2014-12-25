/* 
This program takes the user's character input and makes a triangle out of it
according to the user's request.
Changelog:
 * v0.4 - Added changelog into primary output, increased maximum size to 120 (Thanks Roy)
 * v0.3 - Attempting to make program completely customizable, added restart function
 * v0.2 - Handling wrong user input fixed, "Press any key to exit" now working
 * v0.1 - Initial build
*/

using System;

namespace Triangle
{
    class Program
    {
        static char myChar;
        static int myLen;
        const int minSize = 2;
        const int maxSize = 120;
        static string version = "v0.4";

        static void Main(string[] args)
        {
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            string userInput = "";

            do
            {
                Console.SetWindowSize(125, 60);
                Console.WriteLine("Triangle Maker " + version + " by Omri Harel\n");
                Console.WriteLine("Changelog:");
                Console.WriteLine("* v0.4 - Added changelog into primary output, increased maximum size to 120 (Thanks Roy)");
                Console.WriteLine("* v0.3 - Attempting to make program completely customizable, added restart function");
                Console.WriteLine("* v0.2 - Handling wrong user input fixed, \"Press any key to exit\" now working");
                Console.WriteLine("* v0.1 - Initial build\n");
                Console.WriteLine("This programs allows you to pick any character.");
                Console.WriteLine("It then asks for your desired height (in lines) and");
                Console.WriteLine("creates a triangle according to your choices.\n\n");
                do
                {
                    Console.Write("Which character you would like to use? ");
                    userInput = Console.ReadLine();
                }
                while (checkIsOk(0, userInput) == false);
                Console.WriteLine("Character " + myChar + " accepted.\n");
                do
                {
                    Console.Write("Please define the height of the triangle. (" + minSize + " to " + maxSize + ", integers only.) ");
                    userInput = Console.ReadLine();
                }
                while (checkIsOk(1, userInput) == false);
                Console.WriteLine("Height " + myLen + " accepted.\n");
                Console.WriteLine("Displaying triangle.");
                displayTriangle(myLen, myChar);
                Console.WriteLine("Displayed triangle. Press the R key to start over, or any other key to exit.");
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.R)
                {
                    Console.Clear();
                }
            }
            while (cki.Key == ConsoleKey.R);
        }

        static bool checkIsOk(int type, string input)
        {
            if (type == 0)
            {
                char toUse = ' ';
                toUse = input[0]; // You can't find too many problems here. xD
                myChar = toUse;
                return true;
            }
            else if (type == 1)
            {
                int toUse = 0;
                try 
                {
                    toUse = int.Parse(input);
                }
                catch(FormatException) 
                {
                    Console.WriteLine("You're trying to put in letters, symbols and/or decimal numbers.\n");
                    return false;
                }
                if (toUse >= minSize && toUse <= maxSize)
                {
                    myLen = toUse;
                    return true;
                }
                else
                {
                    Console.WriteLine("You're entering a number out of the range.\n");
                    return false;
                }
            }
            return false;
        }

        static void displayTriangle(int theLen, char theChar)
        {   
            int i;
            for (i = 0; i <= theLen; i++)
            {
                int x;
                for (x = 0; x < i; x++)
                {
                    Console.Write(theChar);
                }
                Console.Write("\n   ");
            }
            Console.Write("\n");
        }
    }
}
