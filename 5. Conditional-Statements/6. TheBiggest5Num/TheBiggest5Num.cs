using System;

class TheBiggest5Num
{
    static void Main()
    {
        //Write a program that finds the biggest of five numbers by using only five if statements. 
        Console.Title = "ConsoleApp - Finds the biggest of 5 numbers";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter a number \"a\":");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"b\":");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"c\":");
        double c = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"d\":");
        double d = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a number \"e\":");
        double e = Double.Parse(Console.ReadLine());
        if (a >= b && a >= c && a >= d && a >= e)
        {
            Console.WriteLine("The bigest is: {0}",a);
        }
        else if (b >= a && b >= c && b >= d && b >= e)
        {
            Console.WriteLine("The bigest is: {0}",b);
        }
        else if (c >= a && c >= b && c >= d && c >= e)
        {
            Console.WriteLine("The bigest is: {0}",c);
        }
        else if (d >= a && d >= b && d >= c && d >= e)
        {
            Console.WriteLine("The bigest is: {0}",d);
        }
        else
        {
            Console.WriteLine("The bigest is: {0}", e);
        }
        Console.ReadLine();
    }
}

