using System;

class NotDivisible3And7
{
    static void Main(string[] args)
    {
        //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space. 
        Console.Title = "ConsoleApp - Print the numbers from 1 to n, not divisable by 3 or 7";
        Console.WriteLine("Please enter positive integer:");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Output: ");
        for (int i = 1; i <= num; i++)
        {
            if (i % 3 == 0 || i % 7 == 0)
            {
                continue;
            }
            Console.Write("{0} ", i);
        }
        Console.ReadLine();
    }
}

