using System;

class Numbers1ToN
{
    static void Main()
    {
        //Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space. 
        Console.Title = "ConsoleApp - Print the numbers from 1 to n";
        Console.WriteLine("Please enter positive integer:");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Output: ");
        for (int i = 1; i <= num; i++)
        {
            Console.Write("{0} ", i);
        }
        Console.ReadLine();
    }
}

