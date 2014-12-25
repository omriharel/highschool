using System;

namespace triangle_formulas_app
{
    class Program
    {
        static int whichCase = 0;
        static double firstData = 0, secondData = 0;
        static string userInput = "";
        static double a, b, c, alpha;
        static double[] savedA = new double[5];
        static double[] savedB = new double[5];
        static double[] savedC = new double[5];
        static double[] savedAlpha = new double[5];
        static int arrayAddCount = 0;

        static void Main(string[] args)
        {
            const string version = "v0.3";
            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            
            Console.Title = "Trigonometric Formulas Helper " + version;
            Console.SetWindowSize(Console.WindowWidth + 10, Console.WindowHeight + 10);
            do
            {
                Console.WriteLine("Trigonometric Formulas Helper, " + version + " by Omri Harel.");
                Console.WriteLine("All credits for idea and basic implementation are due to Lior Sadan.");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("This program allows you to input any two properties of a");
                Console.WriteLine("straight-angle triangle like so:\n");
                Console.WriteLine("   │\\");
                Console.WriteLine("   │  \\");
                Console.WriteLine("   │    \\");
                Console.WriteLine("   │      \\  C");
                Console.WriteLine(" A │        \\");
                Console.WriteLine("   │        / \\");
                Console.WriteLine("   │        | α \\");
                Console.WriteLine("   │________\\_____\\\n");
                Console.WriteLine("          B\n");
                Console.WriteLine("It then analyzes your pick and gives you the missing details.");
                Console.WriteLine("You may also save your results and display them later on.\n");
                do
                {
                    Console.WriteLine("Please pick an option (1-6):");
                    Console.WriteLine(" - 1. Angle α & line segment A");
                    Console.WriteLine(" - 2. Angle α & line segment B");
                    Console.WriteLine(" - 3. Angle α & line segment C");
                    Console.WriteLine(" - 4. Line segment A & line segment C");
                    Console.WriteLine(" - 5. Line segment B & line segment C");
                    Console.WriteLine(" - 6. Line segment A & line segment B");
                    userInput = Console.ReadLine();
                }
                while (!checkCase(userInput));
                Console.WriteLine("\nNow that you've picked an option, you'll input the triangle's properties.");
                getDataInput(whichCase);
                analyzeTriangle(whichCase);
                displayCurrentResults();
                addToArray();
                Console.WriteLine("\nIf you wish to display the results saved in the array, press D.");
                Console.WriteLine("If you wish to start over to analyze more triangles, press R.");
                Console.WriteLine("If you're done, just press any other key to exit.");
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.D)
                {
                    displayArray();
                    Console.WriteLine("Press R to start over or any other key to exit.");
                    cki = Console.ReadKey(true);
                }
                if (cki.Key == ConsoleKey.R)
                {
                    Console.Clear();
                }
            } while (cki.Key == ConsoleKey.R);
        }

        static bool checkCase(string input)
        {
            try
            {
                whichCase = int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nYou're trying to input a string or a float. Exception catched. Please try again.");
                return false;
            }
            switch (whichCase)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    return true;
                default:
                    {
                        Console.WriteLine("\nYou're trying to input a number out of the range. Please try again.");
                        return false;
                    }
            }
        }

        static void getDataInput(int selectedCase)
        {
            switch (selectedCase)
            {
                case 1:
                    {
                        do
                        {
                            Console.WriteLine("Please input angle α's size in degrees:");
                            userInput = Console.ReadLine();
                        }
                        while (!checkFirstData("angle", userInput));
                        do
                        {
                            Console.WriteLine("Please input line segment A's length:");
                            userInput = Console.ReadLine();
                        }
                        while (!checkSecondData(userInput));
                    }
                    break;
                case 2:
                    {
                        do
                        {
                            Console.WriteLine("Please input angle α's size in degrees:");
                            userInput = Console.ReadLine();
                        }
                        while (!checkFirstData("angle", userInput));
                        do
                        {
                            Console.WriteLine("Please input line segment B's length:");
                            userInput = Console.ReadLine();
                        }
                        while (!checkSecondData(userInput));
                    }
                    break;
                case 3:
                    {
                        do
                        {
                            Console.WriteLine("Please input angle α's size in degrees:");
                            userInput = Console.ReadLine();
                        }
                        while (!checkFirstData("angle", userInput));
                        do
                        {
                            Console.WriteLine("Please input line segment C's length:");
                            userInput = Console.ReadLine();
                        }
                        while (!checkSecondData(userInput));
                    }
                    break;
                case 4:
                    {
                        do
                        {
                            do
                            {
                                Console.WriteLine("Please input line segment A's length:");
                                userInput = Console.ReadLine();
                            }
                            while (!checkFirstData("line", userInput));
                            do
                            {
                                Console.WriteLine("Please input line segment C's length:");
                                userInput = Console.ReadLine();
                            }
                            while (!checkSecondData(userInput));
                            if (secondData < firstData)
                                Console.WriteLine("\nC cannot be shorter in length than A.");
                        } while (secondData < firstData);
                    }
                    break;
                case 5:
                    {
                        do
                        {
                            do
                            {
                                Console.WriteLine("Please input line segment B's length:");
                                userInput = Console.ReadLine();
                            }
                            while (!checkFirstData("line", userInput));
                            do
                            {
                                Console.WriteLine("Please input line segment C's length:");
                                userInput = Console.ReadLine();
                            }
                            while (!checkSecondData(userInput));
                            if (secondData < firstData)
                                Console.WriteLine("\nC cannot be shorter in length than B.");
                        } while (secondData < firstData);
                    }
                    break;
                case 6:
                    {
                        do
                        {
                            Console.WriteLine("Please input line segment A's length:");
                            userInput = Console.ReadLine();
                        }
                        while (!checkFirstData("line", userInput));
                        do
                        {
                            Console.WriteLine("Please input line segment B's length:");
                            userInput = Console.ReadLine();
                        }
                        while (!checkSecondData(userInput));
                    }
                    break;
            }
        }

        static bool checkFirstData(string type, string input)
        {
            switch (type)
            {
                case "angle":
                    {
                        try
                        {
                            firstData = double.Parse(input);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nYou're trying to input a string. Exception catched. Please try again.");
                            return false;
                        }
                        if (firstData <= 0 || firstData >= 90)
                        {
                            Console.WriteLine("\nAn angle in a straight-angle triangle cannot be smaller than / equal to 0 degrees,");
                            Console.WriteLine("or larger than / equal to 90 degrees. Please try again.");
                            return false;
                        }
                        return true;
                    }
                case "line":
                    {
                        try
                        {
                            firstData = double.Parse(input);
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nYou're trying to input a string. Exception catched. Please try again.");
                            return false;
                        }
                        if (firstData <= 0)
                        {
                            Console.WriteLine("\nA line segment's length cannot be 0 or less. Please try again.");
                            return false;
                        }
                        return true;
                    }
            }
            return false;
        }

        static bool checkSecondData(string input)
        {
            try
            {
                secondData = double.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("\nYou're trying to input a string. Exception catched. Please try again.");
                return false;
            }
            if (secondData <= 0)
            {
                Console.WriteLine("\nA line's length cannot be 0 or less. Please try again.");
                return false;
            }
            return true;
        }

        private static double degreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        private static double radianToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        static void analyzeTriangle(int selectedCase)
        {
            switch (selectedCase)
            {
                case 1:
                    {
                        alpha = firstData;
                        a = secondData;
                        c = a / Math.Sin(degreeToRadian(alpha));
                        b = c * Math.Cos(degreeToRadian(alpha));
                    }
                    break;
                case 2:
                    {
                        alpha = firstData;
                        b = secondData;
                        c = b / Math.Cos(degreeToRadian(alpha));
                        a = c * Math.Sin(degreeToRadian(alpha));
                    }
                    break;
                case 3:
                    {
                        alpha = firstData;
                        c = secondData;
                        a = c * Math.Sin(degreeToRadian(alpha));
                        b = c * Math.Cos(degreeToRadian(alpha));
                    }
                    break;
                case 4:
                    {
                        a = firstData;
                        c = secondData;
                        alpha = radianToDegree(Math.Asin(a / c));
                        b = c * Math.Cos(degreeToRadian(alpha));
                    }
                    break;
                case 5:
                    {
                        b = firstData;
                        c = secondData;
                        alpha = radianToDegree(Math.Acos(b / c));
                        a = c * Math.Sin(degreeToRadian(alpha));
                    }
                    break;
                case 6:
                    {
                        a = firstData;
                        b = secondData;
                        alpha = radianToDegree(Math.Atan(a / b));
                        c = a / Math.Sin(degreeToRadian(alpha));
                    }
                    break;
            }
        }

        static void displayCurrentResults()
        {
            Console.WriteLine("\nAngle α is " + alpha + " degrees.");
            Console.WriteLine("Line segment A is " + a + " in length.");
            Console.WriteLine("Line segment B is " + b + " in length.");
            Console.WriteLine("Line segment C is " + c + " in length.");
        }

        static void addToArray()
        {
            if (arrayAddCount > 4)
                Console.WriteLine("\nYou cannot add more to the array as it's already full.");
            else
            {
                char choice = ' ';
                do
                {
                    Console.Write("\nWould you like to save the current results into the array? " + (5 - arrayAddCount) + " spots left. (y/n) ");
                    choice = Console.ReadLine()[0];
                }
                while (choice != 'y' && choice != 'n');
                if (choice == 'y')
                {
                    savedA[arrayAddCount] = a;
                    savedB[arrayAddCount] = b;
                    savedC[arrayAddCount] = c;
                    savedAlpha[arrayAddCount] = alpha;
                    arrayAddCount++;
                }
            }
        }

        static void displayArray()
        {
            if (arrayAddCount == 0)
            {
                Console.WriteLine("\nThe saved results array is empty, therefore you cannot display it.");
            }
            else
            {
                int i = 0, j = 0;
                Console.WriteLine("\n  #  │        α        │        A        │        B        │        C        ");
                for (i = 0; i < arrayAddCount; i++)
                {
                    if (savedAlpha[i].ToString().Length > 17)
                        savedAlpha[i] = double.Parse(savedAlpha[i].ToString().Substring(0, 17));
                    if (savedA[i].ToString().Length > 17)
                        savedA[i] = double.Parse(savedA[i].ToString().Substring(0, 17));
                    if (savedB[i].ToString().Length > 17)
                        savedB[i] = double.Parse(savedB[i].ToString().Substring(0, 17));
                    if (savedC[i].ToString().Length > 17)
                        savedC[i] = double.Parse(savedC[i].ToString().Substring(0, 17));
                    Console.WriteLine("—————│—————————————————│—————————————————│—————————————————│—————————————————");
                    Console.Write("  " + (i + 1) + "  │");
                    string savedSpace = "";
                    for (j = 0; j < (((17 - savedAlpha[i].ToString().Length) / 2)); j++)
                    {
                        savedSpace += " ";
                    }
                    Console.Write(savedSpace);
                    Console.Write(savedAlpha[i]);
                    if (((savedAlpha[i].ToString().Length) % 2) == 0)
                        savedSpace += " ";
                    Console.Write(savedSpace);
                    Console.Write("│");
                    savedSpace = "";
                    for (j = 0; j < (((17 - savedA[i].ToString().Length) / 2)); j++)
                    {
                        savedSpace += " ";
                    }
                    Console.Write(savedSpace);
                    Console.Write(savedA[i]);
                    if (((savedA[i].ToString().Length) % 2) == 0)
                        savedSpace += " ";
                    Console.Write(savedSpace);
                    Console.Write("│");
                    savedSpace = "";
                    for (j = 0; j < (((17 - savedB[i].ToString().Length) / 2)); j++)
                    {
                        savedSpace += " ";
                    }
                    Console.Write(savedSpace);
                    Console.Write(savedB[i]);
                    if (((savedB[i].ToString().Length) % 2) == 0)
                        savedSpace += " ";
                    Console.Write(savedSpace);
                    Console.Write("│");
                    savedSpace = "";
                    for (j = 0; j < (((17 - savedC[i].ToString().Length) / 2)); j++)
                    {
                        savedSpace += " ";
                    }
                    Console.Write(savedSpace);
                    Console.Write(savedC[i]);
                    if (((savedC[i].ToString().Length) % 2) == 0)
                        savedSpace += " ";
                    Console.Write(savedSpace);
                    Console.Write("\n");
                }
                Console.Write("\n");
            }
        }
    }
}
