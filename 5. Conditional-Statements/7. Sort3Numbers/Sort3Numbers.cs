using System;

class Sort3Numbers
{
    static void Main()
    {
        //Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality. 
        Console.Title = "ConsoleApp - Sort 3 numbers";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter a number \"a\":");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"b\":");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"c\":");
        double c = Double.Parse(Console.ReadLine());
        if (a >= b)
        {
            if (a >= c)
            {
                if (b >= c)
                {
                    Console.WriteLine("Sorted numbers: {0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("Sorted numbers: {0} {1} {2}", a, c, b);
                }

            }
            else
            {
                Console.WriteLine("Sorted numbers: {0} {1} {2}", c, a, b);
            }
        }
        else
        {
            if (b >= c)
            {
                if (a >= c)
                {
                    Console.WriteLine("Sorted numbers: {0} {1} {2}", b, a, c);
                }
                else
                {
                    Console.WriteLine("Sorted numbers: {0} {1} {2}", b, c, a);
                }
            }
            else
            {
                Console.WriteLine("Sorted numbers: {0} {1} {2}", c, b, a);
            }
        }
        Console.ReadLine();
    }
}

