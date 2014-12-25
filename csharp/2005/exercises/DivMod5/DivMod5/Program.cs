using System;
using System.Collections.Generic;
using System.Text;

namespace DivMod5
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.Write("Please insert a sexy 5-digit number. ");
            {
                bool ok = false;
                while (!ok)
                {
                    try
                    {
                        number = int.Parse(Console.ReadLine());
                        if (number < 10000 || number > 99999)
                        {
                            Console.Write("This isn't working. I want a 5-digit number. ");
                        }
                        else
                            ok = true;
                    }
                    catch (FormatException)
                    {
                        Console.Write("Format exception has been handled. Please try again. ");
                    }
                }
            }
            int ones, tenths, hundreds, thousands, tenThousands, temp;
            ones = number % 10;
            temp = number / 10;
            tenths = temp % 10;
            temp = temp / 10;
            hundreds = temp % 10;
            temp = temp / 10;
            thousands = temp % 10;
            temp = temp / 10;
            tenThousands = temp % 10;
            int sum = ones + tenths + hundreds + thousands + tenThousands;
            Console.Write("The sum of the digits would be a little like: ");
            Console.WriteLine(ones + " + " + tenths + " + " + hundreds + " + " + thousands +
                " + " + tenThousands + " = " + sum + ". Kthanks.");
            Console.ReadKey(true);
        }
    }
}
