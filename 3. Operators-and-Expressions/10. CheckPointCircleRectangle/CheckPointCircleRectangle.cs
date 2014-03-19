using System;
class CheckPointCircleRectangle
{
    static void Main()
    {
        //Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). 
        Console.Title = "ConsoleApp - Check if point is in circle and out of rectangle";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter dimension \"x\" of the point:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter dimension \"y\" of the point:");
        double y = double.Parse(Console.ReadLine());
        bool isOutsideRectangle = (x > 5 || x < -1) || (y > 1 || y < -1);
        x -= 1;
        y -= 1;
        bool isInCircle = (x * x) + (y * y) <= 2.25;


        if (isInCircle && isOutsideRectangle)
        {
            Console.WriteLine("The point is inside the circle and outside the rectangle?=TRUE");
        }
        else
        {
            Console.WriteLine("The point is inside the circle and outside the rectangle?=FALSE");
        }
        Console.ReadLine();
    }
}
