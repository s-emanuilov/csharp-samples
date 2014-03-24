using System;

class BeerTime
{
    static void Main()
    {
        //A beer time is after 1:00 PM and before 3:00 AM. Write a program that 
        //enters a time in format “hh:mm tt” (an hour in range [01...12], a minute 
        //in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer 
        //time” according to the definition above or “invalid time” if the time cannot 
        //be parsed. 
        Console.Title = "ConsoleApp - Beer time";
        Console.WriteLine("Please enter time in format \"hh:mm tt\": ");
        DateTime date = DateTime.Parse(Console.ReadLine());
        if (date.Hour>=13||date.Hour<3)
        {
            Console.WriteLine("Beer time!");
        }
        else
        {
            Console.WriteLine("Non-beer time");
        }
        Console.ReadLine();
    }
}

