using System;

class Fibonacci
{
    static void Main()
    {
        //Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. 
        Console.Title="ConsoleApp - Fibonacci";
        Console.WriteLine("Please enter a number \"n\":");
        int n = int.Parse(Console.ReadLine());
        Console.Write("The first {0} members: ", n);
        int[] fibonacci = new int[3] { 0, 1, 1 };
        if (n == 1)
        {
            Console.Write("{0} ", fibonacci[0]);
        }
        else if (n == 2)
        {
            Console.Write("{0} {1} ", fibonacci[0], fibonacci[1]);
        }
        else
        {
            Console.Write("{0} {1} ", fibonacci[0], fibonacci[1]);
            for (int i = 1; i <= n-2; i++)
            {

                fibonacci[2] = fibonacci[0] + fibonacci[1];
                fibonacci[0] = fibonacci[1];
                fibonacci[1] = fibonacci[2];

                Console.Write("{0} ", fibonacci[2]);
            }
        }

        Console.ReadLine();
    }
}

