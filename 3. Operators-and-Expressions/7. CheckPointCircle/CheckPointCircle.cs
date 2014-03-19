using System;
class CheckPointCircle
{
    static void Main()
    {
        //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
        Console.Title = "ConsoleApp - CheckPointCircle";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter dimension \"x\" of the point:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter dimension \"y\" of the point:");
        double y = double.Parse(Console.ReadLine());
        if ((x * x) + (y * y) <= 4)
        {
            Console.WriteLine("The point is inside the circle!");
        }
        else
        {
            Console.WriteLine("The point is NOT in the circle!");
        }
        Console.ReadLine();
    }
}
