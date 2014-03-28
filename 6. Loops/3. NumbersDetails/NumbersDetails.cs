using System;

class NumbersDetails
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of n integer numbers 
        //and returns the minimal, the maximal number, the sum and the average of all
        //numbers (displayed with 2 digits after the decimal point). The input starts 
        //by the number n (alone in a line) followed by n lines, each holding an integer number. 
        Console.Title = "ConsoleApp - Min, Max, Sum and Average of N Numbers";
        Console.WriteLine("Please enter the count of lines \"n\":");
        int n = int.Parse(Console.ReadLine());
        int min = 0, max = int.MinValue, number = 0;
        double avarage = 0, sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine("Please enter a number:");
            number = int.Parse(Console.ReadLine());

            max = Math.Max(max, number);
            if (number<max)
            {
                min = number;  
            }
            //min = Math.Min(min, number);
            sum += number;
            avarage = sum / n;
        }
        Console.WriteLine("Output:\nmin= {0}\nmax= {1}\nsum= {2}\navarage= {3:F2}", min, max, sum, avarage);
        Console.ReadLine();
    }
}

