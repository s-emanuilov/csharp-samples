using System;

class QuadraticEquation
{
    static void Main()
    {
        //Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). 
        Console.Title = "ConsoleApp - QuadricEquation";
        Console.WriteLine("Important! You have to use the right decimal separator for your system!");
        Console.WriteLine("Please enter coefficient \"a\":");
        double a = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficient \"b\":");
        double b = Double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficient \"c\":");
        double c = Double.Parse(Console.ReadLine());
        double desc=b*b-4*a*c;
        if (desc>0)
        {
            double x1 = (-b + Math.Sqrt(desc)) / (2 * a);
            double x2 = (-b - Math.Sqrt(desc)) / (2 * a);
            Console.WriteLine("There is two real rootrs x1={0}, x2={1}", x1,x2);
        }
        else if (desc==0)
        {
          double x = -(b/(2*a));
          Console.WriteLine("There is one real root = {0}", x);
        }
        else
        {
            Console.WriteLine("There is no real roots!");
        }
        Console.ReadLine();
    }
}

