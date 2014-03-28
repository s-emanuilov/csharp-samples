using System;
using System.Numerics;
    class TrailingZeroes
    {
        static void Main()
        {
            //Write a program that calculates with how many zeroes the factorial of a given number n has at its end. Your program should work well for very big numbers, e.g. n=100000. 
            Console.Title = "ConsoleApp - Calculates with how many zeroes the factorial of a given number";
            
            Console.WriteLine("Please enter a number \"n\":");
            int n = int.Parse(Console.ReadLine());
            BigInteger nFact = 1;
            int counter = 0;
            BigInteger power = 10;
            for (int i = 1; i <= n; i++)
            {
                nFact *= i;
            }
            for (int j = 1; j <= n; j++)
            {
                if (nFact%power==0)
                {
                    power *= 10;
                    counter++;
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(nFact);
            Console.WriteLine("The trailing Zeroes are: {0} ",counter);
            Console.ReadLine();
        }
    }

