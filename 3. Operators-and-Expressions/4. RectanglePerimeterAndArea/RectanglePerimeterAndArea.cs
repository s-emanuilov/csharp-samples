using System;

class RectanglePerimeterAndArea
{
    static void Main()
    {
        //Write an expression that calculates rectangle’s perimeter and area by given width and height.
        Console.Title = "ConsoleApp - Calculate rectangle’s perimeter and area";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter the side of the rectangle:");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the rectangle:");
        double height = double.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the rectangle is: {0}\nThe area of the rectangle is: {1}", (2 * side + 2 * height), (side * height));
        Console.ReadLine();
    }
}
