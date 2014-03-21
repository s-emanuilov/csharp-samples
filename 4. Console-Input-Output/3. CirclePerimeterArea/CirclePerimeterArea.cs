using System;

class CirclePerimeterArea
{
    static void Main()
    {
        //Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. 
        Console.Title = "ConsoleApp - Print circle perimeter and area";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");       
        Console.WriteLine("Please enter \"r\"");
        double radius = double.Parse(Console.ReadLine());
        double perimeter = 2 * Math.PI * radius;
        double area = Math.PI * radius * radius;
        Console.WriteLine("Circle with \"r\" = {0} has perimeter = {1:0.00} and area = {2:0.00}", radius, perimeter, area);
        Console.ReadLine();
    }
}

