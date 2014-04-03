using System;
using System.Collections.Generic;

class PrimesRange
{
    static void Main()
    {
        //Write a method that calculates all prime numbers in given range and returns them as list of integers.
        Console.Title = "ConsoleApp - Prime numbers in given range";
        Console.WriteLine("Please enter the start of the range:");
        int startNum = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the end of the range:");
        int endNum = int.Parse(Console.ReadLine());
        Console.Write("Output: ");
        foreach (var prime in FindPrimesInRange(startNum, endNum))
        {
            Console.Write("{0} ",prime);
        }
        Console.ReadLine();
    }
    static List<int> FindPrimesInRange(int startNum, int endNum)
    {
        List<int> Primes = new List<int>();
        for (int i = startNum; i <= endNum; i++)
        {
            int counter = 0;
            for (int j = 1; j <= i; j++)
            {
                if (i % j == 0)
                {
                    counter++;
                }
            }
            if (counter == 2)
            {
                Primes.Add(i);
            }

        }
        return Primes;
    }
}

