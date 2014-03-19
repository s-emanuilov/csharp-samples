using System;

    class Trapezoids
    {
        static void Main()
        {
            //Write an expression that calculates trapezoid's area by given sides a and b and height h. 
            Console.Title = "ConsoleApp - Trapezoids";
            Console.WriteLine("Important! You have to use the right decimal separator for your system!");
            Console.WriteLine("Please enter size of side \"a\":");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter size of side \"b\":");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter size of the high \"h\":");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the trapezoid is:" + (((a + b) / 2) * h));
            Console.ReadLine();
        }
    }

