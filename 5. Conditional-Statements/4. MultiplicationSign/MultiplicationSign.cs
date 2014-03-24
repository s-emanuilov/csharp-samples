using System;

class MultiplicationSign
{
    static void Main()
    {
        //Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. 
        Console.Title = "ConsoleApp - Verify tge multiplication sign";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter a number \"a\":");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"b\":");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"c\":");
        double c = Double.Parse(Console.ReadLine());
        if ((a < 0 && b < 0 && c < 0))
        {
            Console.WriteLine("Result: -");
        }
        else if ((a > 0 && b > 0 && c > 0) || (a < 0 && b < 0) || c < 0)
        {
            Console.WriteLine("Result: +");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("Result: 0");
        }
        else
        {
            Console.WriteLine("Result: -");
        }
        Console.ReadLine();
    }
}

