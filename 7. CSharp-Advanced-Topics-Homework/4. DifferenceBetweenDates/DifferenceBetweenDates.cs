using System;

class DifferenceBetweenDates
{
    static void Main()
    {
        //Write a program that enters two dates in format dd.MM.yyyy and returns the number of days between them. 
        Console.Title = "ConsoleApp - Difference between two dates";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter the first date (dd.MM.yyyy):");
        DateTime firstDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the second date (dd.MM.yyyy):");
        DateTime secondDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Days between: {0}", Difference(firstDate, secondDate));
        Console.ReadLine();
    }
    static int Difference(DateTime first, DateTime second)
    {
        return (int)(second - first).TotalDays;
    }
}

