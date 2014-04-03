using System;
using System.Numerics;

class PrimeChecker
{
    static void Main()
    {
        //Write a Boolean method IsPrime(n) that check whether a given integer number n is prime. 
        Console.Title = "ConsoleApp - Prime Checker";
        Console.WriteLine("Please enter a number:");
        BigInteger num = BigInteger.Parse(Console.ReadLine());
        Console.WriteLine("The number {0} is prime?: {1}", num, IsPrime(num));
        Console.ReadLine();
    }
    static bool IsPrime(BigInteger n)
    {
        int counter = 0;
        for (int i = 1; i <= Math.Sqrt((double)n); i++)
        {
            if (n % i == 0)
            {
                counter++;
            }
        }

        if (counter == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

